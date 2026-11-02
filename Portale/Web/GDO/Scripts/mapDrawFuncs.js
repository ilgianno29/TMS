
// *****************************************************************************************************************************
// 
// Disegna una serie di punti
// 
// geoDecimalCoords:        array delle coordinate GeoDecimal dei punti da disegnare. Ogni elemento è un oggetto con due campi (x e y). (formato: "punto[0], punto[1], punto[2], ecc." con punto={x, y})
// pointsId:                array degli ID dei punti
// pointsTooltip:           array dei tooltip
// pointsIcon:              array delle icone
// centerMapOnPoint:        array di boolean che specifica l'eventuale punto di centratura della mappa (se un punto è stato selezionato)
// calculateBoundingRect:   true/false se calcolare e centrare la mappa su tutti i punti
// 
// *****************************************************************************************************************************
function drawPoints(geoDecimalCoords, pointsId, pointsTooltip, pointsIcon, centerMapOnPoint, calculateBoundingRect) {
    //
    // almeno un punto
    //
    if (geoDecimalCoords.length >= 1) {
        //
        // per la trasformazione delle coordinate
        //
        var geoDecimalCoordsTransf = [];
        for (var i = 0; i < geoDecimalCoords.length; i++) {
            //
            // le coordinate geocenter devono essere moltiplicate per 100000 (es: 1214532, 5558152)
            //
            var p = { x: geoDecimalCoords[i].x * 100000, y: geoDecimalCoords[i].y * 100000 };
            geoDecimalCoordsTransf.push(p);
        }
        //
        // trasformazione in array di coordinate SmartUnit
        //
        var pointsSU = CoordUtil.geoDecimalList2SmartUnitList(geoDecimalCoordsTransf);

        if (vectorLayer == null) {
            vectorLayer = map.getLayer("vector");
        }
        //
        // se è presente l'icona al centro della mappa la nasconde
        //
        if (vectorLayer.elementExists(idIconOnCenter)) {
            vectorLayer.removeElement(idIconOnCenter);
        }
        //
        // cicla i punti inserendo l'icona
        //
        for (var i = 0; i < pointsSU.length; i++) {

            var draggable = false;
            var image = pointsIcon[i];

            deleteElements(pointsId[i]);
            iconOnMap(pointsSU[i], image, 'point' + pointsId[i], draggable);

            if ((pointsTooltip != null) && (pointsTooltip[i] != null)) {
                tooltipOnPoint(pointsSU[i], '<div class="ToolTipPoint">' + pointsTooltip[i] + '</div>', "tooltip" + pointsId[i], 10);
            }
        }
        //
        // se deve calcolare il boundig rect
        //
        if (calculateBoundingRect) {
            var rectCoords = calculateRect(geoDecimalCoords);
            var leftBottomSU = CoordUtil.geoDecimal2SmartUnit({ x: rectCoords[0] * 100000, y: rectCoords[1] * 100000 });
            var rightTopSU = CoordUtil.geoDecimal2SmartUnit({ x: rectCoords[2] * 100000, y: rectCoords[3] * 100000 });
            map.setRect(leftBottomSU.x, rightTopSU.y, rightTopSU.x, leftBottomSU.y, false);
        }
        //
        // estrae il punto o i punti selezionati
        //
        var centerMapOnPoints = [];
        for (var i = 0; i < centerMapOnPoint.length; i++) {
            if (centerMapOnPoint[i]) {
                var punto = {};
                punto.x = geoDecimalCoords[i].x;
                punto.y = geoDecimalCoords[i].y;
                centerMapOnPoints.push(punto);
            }
        }
        //
        // con un punto solo centra la mappa sul punto mantenendo lo zoom esistente
        // con più punti calcola il bounding rect
        //
        if (centerMapOnPoints.length == 1) {
            centerMap(centerMapOnPoints[0], map.getZoom());
        } else if (centerMapOnPoints.length > 1) {
            for (var i = 0; i < centerMapOnPoints.length; i++) {
                var rectCoords = calculateRect(centerMapOnPoints);
                var leftBottomSU = CoordUtil.geoDecimal2SmartUnit({ x: rectCoords[0] * 100000, y: rectCoords[1] * 100000 });
                var rightTopSU = CoordUtil.geoDecimal2SmartUnit({ x: rectCoords[2] * 100000, y: rectCoords[3] * 100000 });
                map.setRect(leftBottomSU.x, rightTopSU.y, rightTopSU.x, leftBottomSU.y, false);
            }
        }
    }
};

// *****************************************************************************************************************************
// 
// Disegna una serie di linee
// 
// geoDecimalCoords:        array delle coordinate GeoDecimal dei punti da disegnare. Ogni elemento è un oggetto con due campi (x e y). (formato: "punto[0], punto[1], punto[2], ecc." con punto={x, y})
// linesId:                 ID dell'insieme di linee create
// linesTooltip:            tooltip associato alle linee
// color:                   colore delle linee formato rgb (es: rgba(10,10,255,0.5))
// calculateBoundingRect:   true/false se calcolare e centrare la mappa sui punti
// 
// *****************************************************************************************************************************

function drawLines(geoDecimalCoords, linesId, linesTooltip, color, calculateBoundingRect) {

    // almeno due punti
    if (geoDecimalCoords.length >= 2) {

        // per la trasformazione delle coordinate
        var geoDecimalCoordsTransf = geoDecimalCoords;

        // per il rettangolo su cui centrare la mappa
        var minX = geoDecimalCoords[0].x * 100000;
        var maxX = geoDecimalCoords[0].x * 100000;
        var minY = geoDecimalCoords[0].y * 100000;
        var maxY = geoDecimalCoords[0].y * 100000;

        for (var i = 0; i < geoDecimalCoords.length; i++) {

            // le coordinate geocenter devono essere moltiplicate per 100000 (es: 1214532, 5558152)
            geoDecimalCoordsTransf[i].x *= 100000;
            geoDecimalCoordsTransf[i].y *= 100000;

            if (calculateBoundingRect == true) {

                // prende min/max di X e Y
                if (geoDecimalCoordsTransf[i].x > maxX) {
                    maxX = geoDecimalCoordsTransf[i].x;
                }
                if (geoDecimalCoordsTransf[i].x < minX) {
                    minX = geoDecimalCoordsTransf[i].x;
                }
                if (geoDecimalCoordsTransf[i].y > maxY) {
                    maxY = geoDecimalCoordsTransf[i].y;
                }
                if (geoDecimalCoordsTransf[i].y < minY) {
                    minY = geoDecimalCoordsTransf[i].y;
                }
            }
        }

        var leftBottomSU = CoordUtil.geoDecimal2SmartUnit({ x: minX, y: minY });
        var rightTopSU = CoordUtil.geoDecimal2SmartUnit({ x: maxX, y: maxY });

        // trasformazione in array di coordinate SmartUnit
        var pointsSU = CoordUtil.geoDecimalList2SmartUnitList(geoDecimalCoordsTransf);

        if (vectorLayer == null) {
            vectorLayer = map.getLayer("vector");
        }

        if (vectorLayer.elementExists(linesId)) {
            // rimuove prima il tooltip se esiste
            if (vectorLayer.elementExists("tooltip" + linesId)) {
                vectorLayer.removeElement("tooltip" + linesId);
            }
            vectorLayer.removeElement(linesId);
        } else {
            if (vectorLayer.elementExists(idIconOnCenter)) {
                vectorLayer.removeElement(idIconOnCenter);
            }

            if (color == null) {
                color = 'rgba(255,0,0,1)';
            }

            var line = new vector.Line(color, 5, pointsSU, null, linesId);
            line.setArrowsOnLine(true);
            vectorLayer.addElement(line);

            tooltipOnObject(line, '<div class="ToolTipPoint">' + linesTooltip + '</div>', "tooltip" + linesId);

            if (calculateBoundingRect == true) {
                map.setRect(leftBottomSU.x, rightTopSU.y, rightTopSU.x, leftBottomSU.y, false);
            }
        }    
    }
}

// *****************************************************************************************************************************
//
// serie di function per inserimento tooltip su punti
//
// *****************************************************************************************************************************

function tooltipOnPoint(pointSU, text, id, tolerance) {
    var tooltip = new vector.Tooltip();
    tooltip.set({ x: pointSU.x, y: pointSU.y, text: text, tolerance: tolerance, id: id });
    if (!(vectorLayer.elementExists(id))) {
        vectorLayer.addElement(tooltip);
    }
}

function tooltipOnPointXY(X,Y, text, id, tolerance) {
    var tooltip = new vector.Tooltip();
    tooltip.set({ x: X, y: Y, text: text, tolerance: tolerance, id: id });
    vectorLayer.addElement(tooltip);
}

function FixtooltipOnPoint(pointSU, text, id, tolerance) {
    var infobox = new com.ptvag.webcomponent.map.vector.InfoBox(id);
    infobox.set({ x: pointSU.x, y: pointSU.y, text: text.toString(), tolerance: tolerance, id: id.toString() });
    vectorLayer.addElement(infobox);
}

function FixtooltipOnPointColor(pointSU, text, id, tolerance,color) {
    var infobox = new com.ptvag.webcomponent.map.vector.InfoBox(id);
    infobox.set({ x: pointSU.x, y: pointSU.y, text: text.toString(), tolerance: tolerance, id: id.toString(), background: color });
    vectorLayer.addElement(infobox);
}

function FixtooltipOnPointXY(X,Y, text, id, tolerance) {
    var infobox = new com.ptvag.webcomponent.map.vector.InfoBox(id);
    infobox.set({ x: X, y: Y, text: text.toString(), tolerance: tolerance, id: id.toString() });
    vectorLayer.addElement(infobox);
}

function FixtooltipOnPointXYColor(X, Y, text, id, tolerance,color) {
    var infobox = new com.ptvag.webcomponent.map.vector.InfoBox(id);
    infobox.set({ x: X, y: Y, text: text.toString(), tolerance: tolerance, id: id.toString(), background: color });
    vectorLayer.addElement(infobox);
}

// *****************************************************************************************************************************
//
// inserisce un tooltip su un oggetto generico (in DelsyTour c'è una nuova versione che gestisce la priorità)
//
// *****************************************************************************************************************************

function tooltipOnObject(object, text, id) {
    var objectTooltip = new vector.Tooltip();
    objectTooltip.setText(text);
    objectTooltip.setAttachedElement(object);
    objectTooltip.setId(id);
    vectorLayer.addElement(objectTooltip);
}

// *****************************************************************************************************************************
//
// serie di function per disegnare un cerchio sui punti
//
// *****************************************************************************************************************************

function DrawCirclePoint(pointSU, id, size,color) {
    var circle = new com.ptvag.webcomponent.map.vector.Circle();
    circle.set({ x: pointSU.x, y: pointSU.y, id: id.toString(), background: color });
    circle.setPixelSize(size);
    circle.setColor(color);
    vectorLayer.addElement(circle);
}

function DrawCirclePointXY(X, Y,id, size) {
    var circle = new com.ptvag.webcomponent.map.vector.Circle();
    circle.set({ x: X, y: Y,id: id.toString() });
    circle.setPixelSize(size);
    vectorLayer.addElement(circle);
}

function DrawCirclePointXYColor(X, Y, id, size, color) {
    var circle = new com.ptvag.webcomponent.map.vector.Circle();
    circle.set({ x: X, y: Y,  id: id.toString(), background: color });
    circle.setPixelSize(size);
    vectorLayer.addElement(circle);
}

// *****************************************************************************************************************************
//
// cancella gli oggetti identificati da ids
//
// *****************************************************************************************************************************

function deleteElements(ids) {
    //
    // gestisce sia una stringa di ID separati dal carattere ";" che un array di ID
    //
    if (typeof ids == "string") {
        var arrayOfID = ids.split(";");
    } else {
        var arrayOfID = ids;
    }

    if (vectorLayer == null) {
        vectorLayer = map.getLayer("vector");
    }

    for (var i = 0; i < arrayOfID.length; i++) {
        if (vectorLayer.elementExists(arrayOfID[i])) {
            vectorLayer.removeElement(arrayOfID[i]);
        }
    }
}

// *****************************************************************************************************************************
//
// cancella tutti gli oggetti dalla mappa
//
// *****************************************************************************************************************************

function deleteAllElements() {

    if (vectorLayer == null) {
        vectorLayer = map.getLayer("vector");
    }
    vectorLayer.removeAllElements();

}

// *****************************************************************************************************************************
//
// disegna i punti corrispondenti alla posizione dei singoli mezzi
//
// *****************************************************************************************************************************

function drawPointsViaggioMezzo(geoDecimalCoords, pointsId, pointsTooltip, pointsType, colore, targa) {
    //
    // almeno un punto
    //
    if (geoDecimalCoords.length >= 1) {
        //
        // per la trasformazione delle coordinate
        //
        var geoDecimalCoordsTransf = geoDecimalCoords;
        //
        // per il rettangolo su cui centrare la mappa
        //
        var minX = geoDecimalCoords[0].x * 100000;
        var maxX = geoDecimalCoords[0].x * 100000;
        var minY = geoDecimalCoords[0].y * 100000;
        var maxY = geoDecimalCoords[0].y * 100000;

        for (var i = 0; i < geoDecimalCoords.length; i++) {
            //
            // le coordinate geocenter devono essere moltiplicate per 100000 (es: 1214532, 5558152)
            //
            geoDecimalCoordsTransf[i].x *= 100000;
            geoDecimalCoordsTransf[i].y *= 100000;
        }
        //
        // trasformazione in array di coordinate SmartUnit
        //
        var pointsSU = CoordUtil.geoDecimalList2SmartUnitList(geoDecimalCoordsTransf);

        if (vectorLayer == null) {
            vectorLayer = map.getLayer("vector");
        }
        //
        // se è presente l'icona al centro della mappa la nasconde
        //
        if (vectorLayer.elementExists(idIconOnCenter)) {
            vectorLayer.removeElement(idIconOnCenter);
        }
        //
        // cicla i punti inserendo l'icona e, se è stato passato un array di ID per tutti i punti, gli assegna il corretto ID
        // else assegna un ID progressivo
        //
        for (var i = 0; i < pointsSU.length; i++) {
            //
            // PUNTI GPS
            //
            deleteElements(pointsId[i]);
            
            //********************************
            //DISEGNARE ICONA CON CLICK
            //********************************
            //            if ((pointsType != null) && (pointsType.length == pointsSU.length)) {

            //                if ((pointsType[i] == 4)) {
            //                    var image = "../Images/icongreen.png";
            //                } else if (pointsType[i] == 5) {
            //                    var image = "../Images/TTSMezzo.png";
            //                } else if (pointsType[i] == 6) {
            //                    var image = "../Images/iconred.png";
            //                }
            //            }
            //            iconSizeScaleOnMapMezzi(pointsSU[i], pointsTooltip[i], image, pointsId[i], 250, pointsId[i], targa, colore)            
            //********************************

            //**************************************************
            //FIxTOOLTIP  CON TARGA - SFONDO DIVERSO SCRITTA BIANCA
            //**************************************************
            var colorFix
            if ((pointsType[i] == 4)) {
                colorFix = "#000000";
            } else if (pointsType[i] == 5 || pointsType[i] == 6) {
                colorFix = "#FF0000";
            }
            FixtooltipOnPointXYColor(pointsSU[i].x, pointsSU[i].y, '<span class="FixToolTipMezzo">' + targa + '</span>', "fixtooltip" + pointsId[i], 10, colorFix);

            //********************************
            //TOOLTIP CON INFORMAZIONE
            //********************************
            tooltipOnPoint(pointsSU[i], '<div class="ToolTipMezzo">' + pointsTooltip[i] + '</div>', "tooltip" + pointsId[i], 10);

            //********************************
            //PUNTINO
            //********************************
            DrawCirclePoint(pointsSU[i], "circle" + pointsId[i], 10, '#000000')
        }
    }
}

// *****************************************************************************************************************************
//
// disegna i punti corrispondenti alle temperature rilevate dai terminali
//
// *****************************************************************************************************************************

function drawPointsTemp(geoDecimalCoords, pointsId, pointsTooltip, pointsIcon, centerMapOnPoint, calculateBoundingRect) {
    //
    // almeno un punto
    //
    if (geoDecimalCoords.length >= 1) {
        //
        // per la trasformazione delle coordinate
        //
        var geoDecimalCoordsTransf = [];
        for (var i = 0; i < geoDecimalCoords.length; i++) {
            //
            // le coordinate geocenter devono essere moltiplicate per 100000 (es: 1214532, 5558152)
            //
            var p = { x: geoDecimalCoords[i].x * 100000, y: geoDecimalCoords[i].y * 100000 };
            geoDecimalCoordsTransf.push(p);
        }
        //
        // trasformazione in array di coordinate SmartUnit
        //
        var pointsSU = CoordUtil.geoDecimalList2SmartUnitList(geoDecimalCoordsTransf);

        if (vectorLayer == null) {
            vectorLayer = map.getLayer("vector");
        }
        //
        // se è presente l'icona al centro della mappa la nasconde
        //
        if (vectorLayer.elementExists(idIconOnCenter)) {
            vectorLayer.removeElement(idIconOnCenter);
        }
        //
        // cicla i punti inserendo l'icona
        //
        for (var i = 0; i < pointsSU.length; i++) {

            var draggable = false;
            var image = pointsIcon[i];

            deleteElements(pointsId[i]);
            iconOnMap(pointsSU[i], image, 'point' + pointsId[i], draggable);

            if ((pointsTooltip != null) && (pointsTooltip[i] != null)) {
                tooltipOnPoint(pointsSU[i], '<div class="TooltipTemperatura">' + pointsTooltip[i] + '</div>', "tooltip" + pointsId[i], 10);
            }
        }
        //
        // se deve calcolare il boundig rect
        //
        if (calculateBoundingRect) {
            var rectCoords = calculateRect(geoDecimalCoords);
            var leftBottomSU = CoordUtil.geoDecimal2SmartUnit({ x: rectCoords[0] * 100000, y: rectCoords[1] * 100000 });
            var rightTopSU = CoordUtil.geoDecimal2SmartUnit({ x: rectCoords[2] * 100000, y: rectCoords[3] * 100000 });
            map.setRect(leftBottomSU.x, rightTopSU.y, rightTopSU.x, leftBottomSU.y, false);
        }
        //
        // estrae il punto o i punti selezionati
        //
        var centerMapOnPoints = [];
        for (var i = 0; i < centerMapOnPoint.length; i++) {
            if (centerMapOnPoint[i]) {
                var punto = {};
                punto.x = geoDecimalCoords[i].x;
                punto.y = geoDecimalCoords[i].y;
                centerMapOnPoints.push(punto);
            }
        }
        //
        // con un punto solo centra la mappa sul punto mantenendo lo zoom esistente
        // con più punti calcola il bounding rect
        //
        if (centerMapOnPoints.length == 1) {
            centerMap(centerMapOnPoints[0], map.getZoom());
        } else if (centerMapOnPoints.length > 1) {
            for (var i = 0; i < centerMapOnPoints.length; i++) {
                var rectCoords = calculateRect(centerMapOnPoints);
                var leftBottomSU = CoordUtil.geoDecimal2SmartUnit({ x: rectCoords[0] * 100000, y: rectCoords[1] * 100000 });
                var rightTopSU = CoordUtil.geoDecimal2SmartUnit({ x: rectCoords[2] * 100000, y: rectCoords[3] * 100000 });
                map.setRect(leftBottomSU.x, rightTopSU.y, rightTopSU.x, leftBottomSU.y, false);
            }
        }
    }
};