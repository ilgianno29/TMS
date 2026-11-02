//
//
// **************************************** GENERALE ****************************************
//
// 
// viene chiamata ad ogni postback, anche asincrona per centrare la mappa su longitudine e latitudine
function WFIpageLoad() {

    // preleva le coordinate dalle due textbox
    var centerPointGeo = { x: $("#txtLongitudine").val(), y: $("#txtLatitudine").val() };
    centerPointGeo.x = parseFloat(centerPointGeo.x);
    centerPointGeo.y = parseFloat(centerPointGeo.y);

    // se esistono le coordinate 
    if (!(isNaN(centerPointGeo.x)) && !(isNaN(centerPointGeo.y))) {

        // mostra il div della mappa e nasconde l'altro
        $("#mapContainer").show();
        $("#NoGeocodingExist").hide();

        if (map == null) {
            // init della mappa e della toolbar
            init('mapContainer', null, centerPointGeo, true);
            var CenterMapOnPointGeocoding = true;
            var ReverseGeocoding = true;
            var CenterMapOnMapRect = false;
            var ViewTruckAttributes = true;
            customizeToolbar(CenterMapOnPointGeocoding, ReverseGeocoding, CenterMapOnMapRect, ViewTruckAttributes);
            //
            // per la pagina di geocodifica cambia il comportamento del pulsante di visualizzazione TA
            //
            changeHandlerOnViewTruckAttributesMapButton();
        }
        else {
            // centra la mappa e inserisce l'icona al centro
            if (draggableVectorLayer.elementExists(idIconOnCenter)) {
                draggableVectorLayer.removeElement(idIconOnCenter);
            }
            centerMap(centerPointGeo, map.getZoom());
            // conversione geodecimal -> smartunit
            var smartUnitCenter = geo2SU(centerPointGeo);
            iconOnMap(smartUnitCenter, "../Images/PuntoConsegna.png", idIconOnCenter, true);
        }
    } else {
        // se non esistono nasconde il div della mappa e mostra l'altro div
        $("#mapContainer").hide();
        $("#NoGeocodingExist").show();
    }
};

// *****************************************************************************************************************************
//
// Funzione che modifica il comportamento di default del pulsante per la visualizzazione dei Truck Attributes
//
// *****************************************************************************************************************************

function changeHandlerOnViewTruckAttributesMapButton() {

    var btn = toolbarLayer.removeElement("viewTruckAttributesButton");

    var ViewTruckAttrituesOnURL = "../Images/ViewTAOn.png";
    var ViewTruckAttrituesOffURL = "../Images/ViewTAOff.png";
    viewTruckAttributes = false;
    
    toolbarLayer.addElement({
        id: btn.id,
        imgUrl: (viewTruckAttributes ? ViewTruckAttrituesOnURL : ViewTruckAttrituesOffURL),
        width: btn.width,
        height: btn.height,
        tooltip: btn.tooltip,
        enabled: btn.enabled,
        clickHandler: function () {
            //
            // inverte la modalità di viewTruckAttributes e cambia l'icona del pulsante e tooltip
            //
            viewTruckAttributes = !viewTruckAttributes;
            var ViewTruckAttrituesOnURL = "../Images/ViewTAOn.png";
            var ViewTruckAttrituesOffURL = "../Images/ViewTAOff.png";
            toolbarLayer.setButtonImage("viewTruckAttributesButton", (viewTruckAttributes ? ViewTruckAttrituesOnURL : ViewTruckAttrituesOffURL));
            toolbarLayer.setButtonTooltip("viewTruckAttributesButton", (viewTruckAttributes ? "Visualizza Truck Attributes ON" : "Visualizza Truck Attributes OFF"));
            
            //
            // visualizza o meno i TA sulla mappa in base alla var viewTruckAttributes (la var xMapServer viene definita nella pagina aspx)
            //            
            viewTruckAttributesOnMap(viewTruckAttributes, xMapServer)
        }
    });
};

