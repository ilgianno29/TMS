// *****************************************************************************************************************************
//
// variabili globali
//
// *****************************************************************************************************************************
var webcomponent = com.ptvag.webcomponent;
var CoordUtil = webcomponent.map.CoordUtil;
var vector = webcomponent.map.vector;
var map;
var vectorLayer;                                    // normale layer "vector" per disegnare immagini, cerchi, linee, ecc
var draggableVectorLayer;                           // vector layer per disegnare oggetti con proprietà di drag&drop
var toolbarLayer;                                   // toolbar della mappa
var zoomDefault = 10;
var newPositionGEO;                                 // nuovo punto con le coordinate geodecimal ricavate dallo spostamento dell'icona
var idIconOnCenter = 'iconOnCenter';
var idDraggableVectorLayer = 'draggable';
var MapLastUpdate = "";
var viewTruckAttributes;                            // valorizzata di default a false e gestita e dal pulsante viewTruckAttributesButton nella toolbar della mappa

// *****************************************************************************************************************************
//
// classe custom per la definizione di un Vector Layer con opzioni di drag&drop (fornita da PTV)
//
// *****************************************************************************************************************************

qxp.OO.defineClass("custom.DraggableVectorLayer", com.ptvag.webcomponent.map.layer.VectorLayer,
    function (floaterLayer, isSecondary) {

        com.ptvag.webcomponent.map.layer.VectorLayer.call(this, floaterLayer, (isSecondary == null ? true : isSecondary));

        var self = this;
        var mapPackage = com.ptvag.webcomponent.map;
        var vectorPackage = mapPackage.vector;
        var CoordUtil = mapPackage.CoordUtil;
        var EventUtils = com.ptvag.webcomponent.util.EventUtils;

        var elementDetectionDist = 30;
        var elementDetectionSquareDist =
            elementDetectionDist * elementDetectionDist;
        var significantMovementDist = 7;
        var significantMovementSquareDist =
            significantMovementDist * significantMovementDist;

        var mDragElement = null;
        var mDragStartPoint;
        var mStartPoint;
        var mSignificantMovement;
        var mElements = {};

        var superAddElement = self.addElement;
        self.addElement = function (element) {
            var id = superAddElement.apply(self, arguments);
            mElements[id] = element;
            return id;
        };

        var superRemoveElement = self.removeElement;
        self.removeElement = function (id) {
            var element = mElements[id];
            if (element != null) {
                delete mElements[id];
            }
            superRemoveElement.apply(self, arguments);
        };

        var positionElement = function (element, position) {
            var alreadyInBulkMode = self.inBulkMode();
            if (!alreadyInBulkMode) {
                self.startBulkMode();
            }
            element.setX(position.x);
            element.setY(position.y);
            if (!alreadyInBulkMode) {
                self.endBulkMode();
            }
        };

        var superOnMouseDown = self.onMouseDown;
        self.onMouseDown = function (evt) {
            if (mDragElement != null) {
                // safeguard
                if (mSignificantMovement) {
                    positionElement(mDragElement, mDragStartPoint);
                }
                mDragElement = null;
            }
            if (!com.ptvag.webcomponent.util.EventUtils.isLeftMouseButton(evt)) {
                return superOnMouseDown.apply(self, arguments);
            }
            mStartPoint = { relMouseX: evt.relMouseX, relMouseY: evt.relMouseY };
            var startPoint = self.getMap().translateMouseCoords(mStartPoint);
            var bounds = self.getMap().getRect();
            var left = bounds.left;
            var right = bounds.right;
            var top = bounds.top;
            var bottom = bounds.bottom;
            var minDist = -1;
            var visibleZoom = self.getMap().getVisibleZoom();
            startPointPix = CoordUtil.smartUnit2Pixel(startPoint, visibleZoom);
            for (var id in mElements) {
                var element = mElements[id];
                if (!element._draggable) {
                    continue;
                }
                if (!element.setX) {
                    continue;
                }
                var x = element.getX();
                var y = element.getY();
                if (x < left || x > right || y < bottom || y > top) {
                    continue;
                }
                var pixPoint = CoordUtil.smartUnit2Pixel(
                    { x: x, y: y }, visibleZoom);
                var distX = pixPoint.x - startPointPix.x;
                var distY = pixPoint.y - startPointPix.y;
                var squareDist = distX * distX + distY * distY;
                if (squareDist <= elementDetectionSquareDist) {
                    if (minDist < 0 || squareDist < minDist) {
                        minDist = squareDist;
                        mDragElement = element;
                    }
                }
            }
            if (mDragElement != null) {
                mSignificantMovement = false;
                mDragStartPoint = {
                    x: mDragElement.getX(),
                    y: mDragElement.getY()
                };
                return true;
            }
            return superOnMouseDown.apply(self, arguments);
        };

        var superOnMouseMove = self.onMouseMove;
        self.onMouseMove = function (evt) {
            if (mDragElement == null) {
                return superOnMouseDown.apply(self, arguments);
            }
            var newPoint = self.getMap().translateMouseCoords(evt);
            if (!mSignificantMovement) {
                var distX = evt.relMouseX - mStartPoint.relMouseX;
                var distY = evt.relMouseY - mStartPoint.relMouseY;
                var squareDist = distX * distX + distY * distY;
                if (squareDist > significantMovementSquareDist) {
                    mSignificantMovement = true;
                }
            }
            if (mSignificantMovement) {
                positionElement(mDragElement, newPoint);
            }
            return false;
        };

        var superOnMouseUp = self.onMouseUp;
        self.onMouseUp = function (evt) {
            if (mDragElement == null) {
                return superOnMouseUp.apply(self, arguments);
            }
            if (mSignificantMovement) {
                if (self.hasEventListeners("elementDropped")) {
                    self.createDispatchDataEvent("elementDropped",
                        { element: mDragElement, previousPosition: mDragStartPoint });
                }
            }
            mDragElement = null;
            return true;
        };

        var superOnMouseOut = self.onMouseOut;
        self.onMouseOut = function (evt) {
            if (mDragElement == null) {
                return superOnMouseOut.apply(self, arguments);
            }
            if (mDragElement != null) {
                if (mSignificantMovement) {
                    positionElement(mDragElement, mDragStartPoint);
                }
                mDragElement = null;
            }
            return false;
        };

        var superOnKeyDown = self.onKeyDown;
        self.onKeyDown = function (evt) {
            if (evt.keyCode != EventUtils.KEY_CODE_ESC ||
                mDragElement == null) {
                return superOnKeyDown.apply(self, arguments);
            }
            self.onMouseOut();
            return true;
        }
    });

// *****************************************************************************************************************************
//
// inizializzazione mappa
// initMap      -> versione vecchia
// initMap4Lazo -> versione nuova che utilizza un layer di tipo custom.VectorLayer per il lazo (QUI NON IMPLEMENTATA, VEDERE DELSYTOUR)
//
// *****************************************************************************************************************************

function init(mapContainer, boundingRect, centerPointGeo, iconOnCenter) {
    //
    // se lat e lon sono valorizzate prende quelle altrimenti si centra su Roma
    //
    if ((centerPointGeo != null) && !(isNaN(centerPointGeo.x)) && !(isNaN(centerPointGeo.y))) {
        var geoCenter = centerPointGeo;
    } else {
        var geoCenter = { x: 11.180278, y: 43.758056 };
    };
    //
    // conversione geodecimal -> smartunit
    //
    var smartUnitCenter = geo2SU(geoCenter);

    initMap(mapContainer, boundingRect, smartUnitCenter, zoomDefault);
    //
    // inserisce un'icona nel punto centrale della mappa
    //
    if (iconOnCenter == true) {
        iconOnMap(smartUnitCenter, "../Images/PuntoConsegna.png", idIconOnCenter, true);
    }
};

function initMap(mapContainer, boundingRect, centerPointSU, zoom) {

    var mapContainer = document.getElementById(mapContainer);

    var setCenter = false;

    if ((boundingRect != null) && (mapObjects.Viaggi.length > 0)) {

        if (boundingRect.length == 4) {

            var leftBottom = { x: parseFloat(boundingRect[0]), y: parseFloat(boundingRect[1]) };
            var rightTop = { x: parseFloat(boundingRect[2]), y: parseFloat(boundingRect[3]) };

            var leftBottomSU = geo2SU(leftBottom);
            var rightTopSU = geo2SU(rightTop);

            var rect = { left: leftBottomSU.x, top: rightTopSU.y, right: rightTopSU.x, bottom: leftBottomSU.y };

            map = new webcomponent.map.Map(mapContainer, rect);        
        }
        else {
            setCenter = true;
        };

    } else {
        setCenter = true;
    };
    //
    // se non ha settato il boundingRect setta la mappa con il centro
    //
    if (setCenter == true) {
        map = new webcomponent.map.Map(mapContainer);
        map.setCenter(centerPointSU);
        map.setZoom(zoom = null ? zoomDefault : zoom);
    }
    //
    // FUNZIONA SOLO SU IE. SOSTIUTITO CON EVENTO OnClientResized DEL RADPANE CHE CONTIENE LA MAPPA
    // per la form di pianificazione tour. Setta il resize anche sul div della mappa
    // permette di aggiornare le dimensioni del div della mappa alla modifica del pannello (tramite splitter)
    //    document.getElementById("mapContainer").onresize = function () {
    //        map.updateSize();
    //    };
    //
    // se l'evento onresize è già stato definito aggiunge map.updateSize() altrimenti lo ridefinisce
    //
    if (window.onresize) {
        var prev_func = window.onresize;
        window.onresize = function () {  // new function for resize
            prev_func.call(window);  // call the old one, setting the
            map.updateSize();
        };
    } else {
        window.onresize = function () {
            map.updateSize();
        };
    }

    //map.setZoom(zoom = null ? zoomDefault : zoom);
    //map.addEventListener('changeZoom', propertyChangeListener);
    //
    // abilita il layer con la posizione del mouse e il layer debug per le coordinate nei diversi formati
    //
    //map.getLayer("position").setEnabled(true);
    //map.getLayer("debug").setEnabled(true);

}

// *****************************************************************************************************************************
//
// Funzione di customizzazione della toolbar
//
// *****************************************************************************************************************************
function customizeToolbar(CenterMapOnPointGeocoding, ReverseGeocoding, CenterMapOnMapRect, ViewTruckAttributes) {
    //
    // imposto le proprietà della toolbar di default
    //
    toolbarLayer = map.getLayer("toolbar");
    toolbarLayer.set({ areaLeft: 2, areaTop: 2 });
    toolbarLayer.setButtonOpacityDisabled(0.1);
    toolbarLayer.setButtonOpacityOut(0.2);
    //    
    // Rimuovo i pulsanti di zoom
    //
    //toolbarLayer.removeElement("zoom-out");
    //toolbarLayer.removeElement("spacing-between-zoom");
    //toolbarLayer.removeElement("zoom-in");
    //toolbarLayer.removeElement("spacing-after-zoom");
    toolbarLayer.removeElement("zoom-mode");
    toolbarLayer.removeElement("move-mode");
    toolbarLayer.removeElement("spacing-after-mode");
    toolbarLayer.removeElement("overview");
    toolbarLayer.removeElement("spacing-after-overview");
    toolbarLayer.removeElement("map-view");
    toolbarLayer.removeElement("spacing-between-view-1");
    toolbarLayer.removeElement("hybrid-view");
    toolbarLayer.removeElement("spacing-between-view-2");
    toolbarLayer.removeElement("aerial-view");
    toolbarLayer.removeElement("spacing-after-view");
    toolbarLayer.removeElement("spacing-after-address-lookup");
    //toolbarLayer.removeElement("reset");
    toolbarLayer.removeElement("spacing-after-reset");
    toolbarLayer.removeElement("history-back");
    toolbarLayer.removeElement("spacing-between-history");
    toolbarLayer.removeElement("history-forward");
    toolbarLayer.removeElement("measurement");

    map.removeLayer("zoomslider");
    map.removeLayer("compass");
    //
    // pulsante a due stati per visualizzazione truck attributes su mappa (per debug del percorso)
    //    
    if (ViewTruckAttributes) {
        //
        // viewTruckAttributes è una var di pagina
        //        
        viewTruckAttributes = false;
        toolbarLayer.addElement({
            id: "viewTruckAttributesButton",
            imgUrl: updateViewTruckAttributesButton("IMG"),
            width: 17,
            height: 17,
            tooltip: updateViewTruckAttributesButton("TOOLTIP"),
            enabled: true,
            clickHandler: function () {
                //
                // inverte la modalità di viewTruckAttributes e cambia l'icona del pulsante e tooltip
                //                
                viewTruckAttributes = !viewTruckAttributes;
                updateViewTruckAttributesButton();                
                drawMap(mapObjects);
            }
        });
    }
    //toolbarLayer.addElement({ width: 7, id: "spacer-after-debug-button" });
    //
    // pulsante per centrare la mappa su due coordinate
    // memorizzo l'elemento per mantenere l'icona
    //
    var elem2 = toolbarLayer.removeElement("reset");
    if (CenterMapOnPointGeocoding) {
        toolbarLayer.addElement({
            id: "centerMapOnPointGeocoding",
            imgUrl: elem2.imgUrl,
            width: 17,
            height: 17,
            tooltip: "Centra la mappa sulle coordinate",
            enabled: true,
            clickHandler: function () {
                var centerPointGeo = { x: document.getElementById('txtLongitudine').value, y: document.getElementById('txtLatitudine').value };
                centerPointGeo.x = parseFloat(centerPointGeo.x);
                centerPointGeo.y = parseFloat(centerPointGeo.y);
                if (draggableVectorLayer.elementExists(idIconOnCenter)) {
                    draggableVectorLayer.removeElement(idIconOnCenter);
                }
                centerMap(centerPointGeo, map.getZoom());
                //
                // conversione geodecimal -> smartunit
                //
                var smartUnitCenter = geo2SU(centerPointGeo);
                iconOnMap(smartUnitCenter, "../Images/PuntoConsegna.png", idIconOnCenter, true);
            }
        });
        toolbarLayer.addElement({ width: 2, id: "spacer-after-centerMapOnPointGeocoding" });
    }
    //
    // pulsante per centrare la mappa sul rettangolo contenente tutti gli elementi
    // utilizza lo stesso elemento del pulsante CenterMapOnPointGeocoding (al momento o abilito uno o l'altro)
    //
    if (CenterMapOnMapRect) {
        toolbarLayer.addElement({
            id: "centraTuttoButton",
            imgUrl: "../Images/CentraTutto.png",
            width: 17,
            height: 17,
            tooltip: "Centra la mappa sul contenuto",
            enabled: true,
            clickHandler: function () {
                centerMapOnBoundingRect(mapObjects.BoundingRectMappa);
            }
        });
        toolbarLayer.addElement({ width: 2, id: "spacer-after-centraTuttoButton" });
    }
    //
    // pulsante per reverse geocoding
    //
    if (ReverseGeocoding) {
        toolbarLayer.addElement({
            id: "reverseGeocodingButton",
            imgUrl: "../Images/Check.png",
            width: 17,
            height: 17,
            tooltip: "Recupera l'indirizzo a partire dalle coordinate del punto",
            enabled: true,
            clickHandler: function () {
                $("#btnReverseGeocoding").trigger('click');
            }
        });
        toolbarLayer.addElement({ width: 2, id: "spacer-after-reverseGeocodingButton" });
    }
};

// *****************************************************************************************************************************
//
// Funzioni di conversione coordinate
//
// *****************************************************************************************************************************

function geo2SU(pointGeo) {

    var geo = { x: pointGeo.x, y: pointGeo.y };
    //
    // le coordinate geocenter devono essere moltiplicate per 100000 (es: 1214532, 5558152)
    //
    geo.x *= 100000;
    geo.y *= 100000;
    //
    // converte in smartunit
    //
    var smartUnit = CoordUtil.geoDecimal2SmartUnit(geo);

    return smartUnit;
};

function su2Geo(pointSU) {

    var su = { x: pointSU.x, y: pointSU.y };
    //
    // converte in geodecimal
    //
    var geo = CoordUtil.smartUnit2GeoDecimal(su);
    //
    // le coordinate geodecimal devono essere divise per 100000
    //
    geo.x /= 100000;
    geo.y /= 100000;

    return geo;
};

function convertCoordStringGeo2Array(coordStr) {
    //
    // converte una stringa di coordinate geodecimal passate nel formato Long1,Lat1;Long2,Lat2;Long3,Lat3;.... in un array
    //
    var coordGeo = coordStr.split(";");
    return coordGeo;
};

// *****************************************************************************************************************************
//
// Funzione che disegna un'icona sulla mappa
// iconOnMap      -> versione vecchia che utilizza per le icone un oggetto vector.ImageMarker
// iconOnMap4Lazo -> versione nuova che utilizza per le icone un oggetto custom.VectorElement (QUI NON IMPLEMENTATA, VEDERE DELSYTOUR)
//
// *****************************************************************************************************************************

function iconOnMap(pointSU, image, id, dragAndDrop) {
    //
    // definizione icona
    //
    var iconOnPoint = new vector.ImageMarker();
    iconOnPoint.setX(pointSU.x);
    iconOnPoint.setY(pointSU.y);
    iconOnPoint.setUrl(image);
    iconOnPoint.setId(id);

    if (dragAndDrop == false) {
        //
        // standard layer
        //
        if (vectorLayer == null) {
            vectorLayer = map.getLayer("vector");
        }
        if (!(vectorLayer.elementExists(id))) {
            vectorLayer.addElement(iconOnPoint);
            //
            // area cliccabile associata all'icona
            //
            //var clickArea = new vector.ClickArea();
            //clickArea.set({ x: pointSU.x, y: pointSU.y, tolerance: 10 });
            //clickArea.setHandler(function (evt) {
            //    alert("Click at: " + evt.clickX + " / " + evt.clickY + "\n" +
            //    "Center of click area: " + evt.areaX + " / " + evt.areaY);
            //});
            //vectorLayer.addElement(clickArea);
        }

    } else {

        //
        // drag&drop layer
        //
        if (draggableVectorLayer == null) {
            draggableVectorLayer = new custom.DraggableVectorLayer(map.getLayer("floater"));
            draggableVectorLayer.setIncludeInPrint(true);
            draggableVectorLayer.setIsRelative(true);
            map.addLayer(draggableVectorLayer, idDraggableVectorLayer, null, map.getLayer("overview"));

            draggableVectorLayer.addEventListener("elementDropped", function (evt) {
                var data = evt.getData();
                var IconPositionSU = { x: data.element.getX(), y: data.element.getY() };
                var IconPositionGEO = su2Geo(IconPositionSU);
                document.getElementById("HFLongitudine").value = IconPositionGEO.x.toFixed(5);
                document.getElementById("HFLatitudine").value = IconPositionGEO.y.toFixed(5);
                document.getElementById("HFReverseGeocodingNeeded").value = 'S';
            });
        }

        iconOnPoint._draggable = true;
        draggableVectorLayer.addElement(iconOnPoint);
    }
};

// *****************************************************************************************************************************
//
// Funzioni per centratura mappa
//
// *****************************************************************************************************************************

function centerMap(centerPointGeo, iconOnCenter, zoom) {

    map.setCenter(geo2SU(centerPointGeo));
    map.setZoom(zoom = null ? zoomDefault : zoom);
};

function centerMapOnBoundingRect(boundingRect) {

    if (boundingRect != null) {
        if (boundingRect[0] == 99999) {
            var leftBottom = { x: parseFloat("18.3118"), y: parseFloat("47.0530") };
            var rightTop = { x: parseFloat("6.3732"), y: parseFloat("35.2924") };

            var leftBottomSU = geo2SU(leftBottom);
            var rightTopSU = geo2SU(rightTop);
        } else {
            var leftBottom = { x: parseFloat(boundingRect[0]), y: parseFloat(boundingRect[1]) };
            var rightTop = { x: parseFloat(boundingRect[2]), y: parseFloat(boundingRect[3]) };

            var leftBottomSU = geo2SU(leftBottom);
            var rightTopSU = geo2SU(rightTop);
        }

        var rect = { left: leftBottomSU.x, top: rightTopSU.y, right: rightTopSU.x, bottom: leftBottomSU.y };
        map.setRect(leftBottomSU.x, rightTopSU.y, rightTopSU.x, leftBottomSU.y, false);
    }
};

function centerMapOnPoint(x, y) {

    var leftBottom = { x: parseFloat(x), y: parseFloat(y) };
    var rightTop = { x: parseFloat(x), y: parseFloat(y) };

    var leftBottomSU = geo2SU(leftBottom);
    var rightTopSU = geo2SU(rightTop);

    var rect = { left: leftBottomSU.x, top: rightTopSU.y, right: rightTopSU.x, bottom: leftBottomSU.y };
    map.setRect(leftBottomSU.x, rightTopSU.y, rightTopSU.x, leftBottomSU.y, false);

};

//
// per il pulsante viewTruckAttributes: ritorna o l'immagine o i tooltip da impostare oppure imposta le proprietà direttamente
//
function updateViewTruckAttributesButton(param) {

    var ViewTruckAttrituesOnURL = "../Images/ViewTAOn.png";
    var ViewTruckAttrituesOffURL = "../Images/ViewTAOff.png";
    var ViewTruckAttrituesOnTooltip = "Visualizza Truck Attributes ON";
    var ViewTruckAttrituesOffTooltip = "Visualizza Truck Attributes OFF";
    if (param == "IMG") {
        return (viewTruckAttributes ? ViewTruckAttrituesOnURL : ViewTruckAttrituesOffURL);
    } else if (param == "TOOLTIP") {
        return (viewTruckAttributes ? ViewTruckAttrituesOnTooltip : ViewTruckAttrituesOffTooltip);
    } else {
        toolbarLayer.setButtonImage("viewTruckAttributesButton", (viewTruckAttributes ? ViewTruckAttrituesOnURL : ViewTruckAttrituesOffURL));
        toolbarLayer.setButtonTooltip("viewTruckAttributesButton", (viewTruckAttributes ? ViewTruckAttrituesOnTooltip : ViewTruckAttrituesOffTooltip));
    }
}


// *****************************************************************************************************************************
//
// visualizza o meno i Truck Attributes su mappa
//
// *****************************************************************************************************************************

function viewTruckAttributesOnMap(view, xMapServer) {

    var manager = map.getServerDrawnObjectManager();
    var url = xMapServer + "/ajaxmaps";
    url = url + "/TruckAttributesLayer.xml?bbox=COORDWIN@@@size=IMGSIZE";

    if (view) {        
        manager.addPOICategory("xml", url);
    } else {
        manager.removePOICategory("xml", url);
    }
};