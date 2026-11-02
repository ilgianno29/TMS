// *****************************************************************************************************************************
//
// disegna gli oggetti sulla mappa (ordini da pianificare, pianificati, depositi e viaggi)
//
// *****************************************************************************************************************************

function drawMap(mapObjects, CenterViaggio) {

    if (mapObjects != null) {
        //
        // check se deve aggiornare la mappa
        //
        alert('');
        if (mapObjects.LastUpdate != MapLastUpdate) {
            if (map == null) {
                //
                // Inizializzazione della mappa
                //
                init('mapContainer', null, null, false);
                var CenterMapOnPointGeocoding = true;
                var ReverseGeocoding = true;
                var CenterMapOnMapRect = false;
                var ViewTruckAttributes = false;
                customizeToolbar(CenterMapOnPointGeocoding, ReverseGeocoding, CenterMapOnMapRect, ViewTruckAttributes);
                centerMapOnBoundingRect(mapObjects.BoundingRectMappa);
            }

            deleteAllElements();

            var OrderedFunctions = [];

            if (mapObjects.viewTourRouting) {
                OrderedFunctions.push(function () { drawTourRouting(mapObjects.Viaggi, 'R', false); });
            }
            if (mapObjects.viewTourRoutingPianificato) {
                OrderedFunctions.push(function () { drawTourRouting(mapObjects.Viaggi, 'P', false); });
            }
            if (mapObjects.viewTourLine) {
                OrderedFunctions.push(function () { drawTourLine(mapObjects.Viaggi, 'R', false); });
            }
            if (mapObjects.viewTourLinePianificato) {
                OrderedFunctions.push(function () { drawTourLine(mapObjects.Viaggi, 'P', false); });
            }
            if (mapObjects.viewTourGPS) {
                OrderedFunctions.push(function () { drawTourPointGPS(mapObjects.Viaggi, false); });
            }
            if (mapObjects.viewUltimaPosizioneMezzi) {
                OrderedFunctions.push(function () { drawViaggiMezzi(mapObjects.Viaggi, false); });
            }
            if (mapObjects.viewTourTemp) {
                OrderedFunctions.push(function () { drawTourPointTemp(mapObjects.Viaggi, false); });
            }
            var tipo = 'R';
            if ((mapObjects.viewTourRoutingPianificato) || (mapObjects.viewTourLinePianificato)) {
                tipo = 'P';
            }
            OrderedFunctions.push(function () { drawTourPoint(mapObjects.Viaggi, tipo, false); });
            //
            // exec delle functions ordinate
            //
            for (i = 0; i < OrderedFunctions.length; i++) {
                OrderedFunctions[i]();
            }

            if ((CenterViaggio) || (mapObjects.viewUltimaPosizioneMezzi)) {
                centerMapOnBoundingRect(mapObjects.BoundingRectMappa);
            }

            MapLastUpdate = mapObjects.LastUpdate

        }

    } else {
        alert("Oggetto mapObjects nullo.");
    }
};

// *****************************************************************************************************************************
//
// disegna i punti dei viaggi
//
// *****************************************************************************************************************************

function drawTourPoint(viaggi, tipo, centerOnSelected) {

    var pointsOfTour = [];
    var colore;

    var pointsId = [];
    var pointsTooltip = [];
    var pointsFixedTooltip = [];
    var pointsIcon = [];
    var centerMapOnPoint = [];
    //
    // ordina prima i viaggi selezionati
    //
    viaggi = viaggi.sort(sortSelezionati);

    for (var i = 0; i < viaggi.length; i++) {

        if ((viaggi[i].Visibile) || (viaggi[i].Selezionato)) {

            if ((viaggi[i].Punti != null) && (viaggi[i].PuntiPianificati != null)) {
                //
                // se deve disegnare i punti reali disegna anche i pianificati che non sono stati effettuati
                //
                if (tipo == 'R') {
                    //
                    // cicla i punti pianificati
                    //
                    for (var j = 0; j < viaggi[i].PuntiPianificati.length; j++) {
                        //
                        // cicla i punti alla ricerca di eventuali punti pianificati ma non effettuati
                        //
                        var trovato = false;
                        for (var k = 0; k < viaggi[i].Punti.length; k++) {
                            if (viaggi[i].PuntiPianificati[j].ID == 'P' + viaggi[i].Punti[k].ID) {
                                trovato = true;
                            }
                        }
                        if (!trovato) {
                            var punto = {};
                            punto.x = viaggi[i].PuntiPianificati[j].Longitudine;
                            punto.y = viaggi[i].PuntiPianificati[j].Latitudine;

                            pointsOfTour.push(punto)

                            pointsId.push(viaggi[i].PuntiPianificati[j].ID);
                            pointsTooltip.push(viaggi[i].PuntiPianificati[j].Tooltip);
                            pointsFixedTooltip.push(viaggi[i].PuntiPianificati[j].FixToolTip);

                            if (viaggi[i].PuntiPianificati[j].Selezionato) {
                                pointsIcon.push(viaggi[i].PuntiPianificati[j].IconaSelezionato);
                            } else {
                                pointsIcon.push(viaggi[i].PuntiPianificati[j].Icona);
                            }
                            //
                            // costruisce l'array per la centratura della mappa sul punto selezionato solo se è attiva la modalità
                            //
                            if (centerOnSelected) {
                                centerMapOnPoint.push(viaggi[i].PuntiPianificati[j].Selezionato);
                            } else {
                                centerMapOnPoint.push(false);
                            }
                        }
                    }
                    //
                    // cicla i punti reali
                    //
                    for (var j = 0; j < viaggi[i].Punti.length; j++) {
                        var punto = {};
                        punto.x = viaggi[i].Punti[j].Longitudine;
                        punto.y = viaggi[i].Punti[j].Latitudine;
                        pointsOfTour.push(punto)

                        pointsId.push(viaggi[i].Punti[j].ID);
                        pointsTooltip.push(viaggi[i].Punti[j].Tooltip);
                        pointsFixedTooltip.push(viaggi[i].Punti[j].FixTooltip);

                        if (viaggi[i].Punti[j].Selezionato) {
                            pointsIcon.push(viaggi[i].Punti[j].IconaSelezionato);
                        } else {
                            pointsIcon.push(viaggi[i].Punti[j].Icona);
                        }
                        //
                        // costruisce l'array per la centratura della mappa sul punto selezionato solo se è attiva la modalità
                        //
                        if (centerOnSelected) {
                            centerMapOnPoint.push(viaggi[i].Punti[j].Selezionato);
                        } else {
                            centerMapOnPoint.push(false);
                        }
                    }
                } else {
                    //
                    // cicla e i punti pianificati
                    //
                    for (var j = 0; j < viaggi[i].PuntiPianificati.length; j++) {

                        var punto = {};
                        punto.x = viaggi[i].PuntiPianificati[j].Longitudine;
                        punto.y = viaggi[i].PuntiPianificati[j].Latitudine;

                        pointsOfTour.push(punto)

                        pointsId.push(viaggi[i].PuntiPianificati[j].ID);
                        pointsTooltip.push(viaggi[i].PuntiPianificati[j].Tooltip);
                        pointsFixedTooltip.push(viaggi[i].PuntiPianificati[j].FixToolTip);

                        if (viaggi[i].PuntiPianificati[j].Selezionato) {
                            pointsIcon.push(viaggi[i].PuntiPianificati[j].IconaSelezionato);
                        } else {
                            pointsIcon.push(viaggi[i].PuntiPianificati[j].Icona);
                        }
                        //
                        // costruisce l'array per la centratura della mappa sul punto selezionato solo se è attiva la modalità
                        //
                        if (centerOnSelected) {
                            centerMapOnPoint.push(viaggi[i].PuntiPianificati[j].Selezionato);
                        } else {
                            centerMapOnPoint.push(false);
                        }

                    }
                }
            }
            //
            // centra la mappa sul viaggio selezionato solo se è attiva la modalità
            //
            if ((centerOnSelected) && (viaggi[i].Selezionato)) {
                centerMapOnBoundingRect(viaggi[i].BoundingRect);
            }
        }
    }

    drawPoints(pointsOfTour, pointsId, pointsTooltip, pointsIcon, centerMapOnPoint, false);
};

function drawTourPointOLD(viaggi, centerOnSelected) {

    var pointsOfTour = [];
    var colore;

    var pointsId = [];
    var pointsTooltip = [];
    var pointsFixedTooltip = [];
    var pointsIcon = [];
    var centerMapOnPoint = [];

    for (var i = 0; i < viaggi.length; i++) {

        if ((viaggi[i].Visibile) || (viaggi[i].Selezionato)) {

            if ((viaggi[i].Punti != null) && (viaggi[i].PuntiPianificati != null)) {

                viaggi[i].Punti = viaggi[i].Punti.sort(sortOnZOrder);
                viaggi[i].PuntiPianificati = viaggi[i].PuntiPianificati.sort(sortOnZOrder);

                if (viaggi[i].Punti[0].ZOrder < viaggi[i].PuntiPianificati[0].ZOrder) {

                    //viaggi[i].Punti = viaggi[i].Punti.sort(sortSelezionati);

                    for (var j = 0; j < viaggi[i].Punti.length; j++) {
                        var punto = {};
                        punto.x = viaggi[i].Punti[j].Longitudine;
                        punto.y = viaggi[i].Punti[j].Latitudine;
                        pointsOfTour.push(punto)

                        pointsId.push(viaggi[i].Punti[j].ID);
                        pointsTooltip.push(viaggi[i].Punti[j].Tooltip);
                        pointsFixedTooltip.push(viaggi[i].Punti[j].FixTooltip);

                        if (viaggi[i].Punti[j].Selezionato) {
                            pointsIcon.push(viaggi[i].Punti[j].IconaSelezionato);
                        } else {
                            pointsIcon.push(viaggi[i].Punti[j].Icona);
                        }
                        //
                        // costruisce l'array per la centratura della mappa sul punto selezionato solo se è attiva la modalità
                        //
                        if (centerOnSelected) {
                            centerMapOnPoint.push(viaggi[i].Punti[j].Selezionato);
                        } else {
                            centerMapOnPoint.push(false);
                        }
                    }
                    //
                    //DEVO FARE VEDERE ANCHE I PUNTI CHE SONO PIANIFICATI MA NON SONO STATI EFFETTUATI
                    //
                    //viaggi[i].PuntiPianificati = viaggi[i].PuntiPianificati.sort(sortSelezionati);
                    //viaggi[i].PuntiPianificati = viaggi[i].PuntiPianificati.sort(sortOnZOrder);

                    for (var j = 0; j < viaggi[i].PuntiPianificati.length; j++) {
                        var punto = {};
                        punto.x = viaggi[i].PuntiPianificati[j].Longitudine;
                        punto.y = viaggi[i].PuntiPianificati[j].Latitudine;

                        pointsOfTour.push(punto)

                        pointsId.push(viaggi[i].PuntiPianificati[j].ID);
                        pointsTooltip.push(viaggi[i].PuntiPianificati[j].Tooltip);
                        pointsFixedTooltip.push(viaggi[i].PuntiPianificati[j].FixToolTip);

                        if (viaggi[i].PuntiPianificati[j].Selezionato) {
                            pointsIcon.push(viaggi[i].PuntiPianificati[j].IconaSelezionato);
                        } else {
                            pointsIcon.push(viaggi[i].PuntiPianificati[j].Icona);
                        }
                        //
                        // costruisce l'array per la centratura della mappa sul punto selezionato solo se è attiva la modalità
                        //
                        if (centerOnSelected) {
                            centerMapOnPoint.push(viaggi[i].PuntiPianificati[j].Selezionato);
                        } else {
                            centerMapOnPoint.push(false);
                        }

                    }
                } else {
                    //DEVO FARE VEDERE ANCHE I PUNTI CHE SONO PIANIFICATI MA NON SONO STATI EFFETTUATI

                    //viaggi[i].PuntiPianificati = viaggi[i].PuntiPianificati.sort(sortSelezionati);
                    //viaggi[i].PuntiPianificati = viaggi[i].PuntiPianificati.sort(sortOnZOrder);

                    for (var j = 0; j < viaggi[i].PuntiPianificati.length; j++) {
                        var punto = {};
                        punto.x = viaggi[i].PuntiPianificati[j].Longitudine;
                        punto.y = viaggi[i].PuntiPianificati[j].Latitudine;

                        pointsOfTour.push(punto)

                        pointsId.push(viaggi[i].PuntiPianificati[j].ID);
                        pointsTooltip.push(viaggi[i].PuntiPianificati[j].Tooltip);
                        pointsFixedTooltip.push(viaggi[i].PuntiPianificati[j].FixToolTip);

                        if (viaggi[i].PuntiPianificati[j].Selezionato) {
                            pointsIcon.push(viaggi[i].PuntiPianificati[j].IconaSelezionato);
                        } else {
                            pointsIcon.push(viaggi[i].PuntiPianificati[j].Icona);
                        }
                        //
                        // costruisce l'array per la centratura della mappa sul punto selezionato solo se è attiva la modalità
                        //
                        if (centerOnSelected) {
                            centerMapOnPoint.push(viaggi[i].PuntiPianificati[j].Selezionato);
                        } else {
                            centerMapOnPoint.push(false);
                        }
                    }

                    //viaggi[i].Punti = viaggi[i].Punti.sort(sortSelezionati);

                    for (var j = 0; j < viaggi[i].Punti.length; j++) {
                        var punto = {};
                        punto.x = viaggi[i].Punti[j].Longitudine;
                        punto.y = viaggi[i].Punti[j].Latitudine;
                        pointsOfTour.push(punto)

                        pointsId.push(viaggi[i].Punti[j].ID);
                        pointsTooltip.push(viaggi[i].Punti[j].Tooltip);
                        pointsFixedTooltip.push(viaggi[i].Punti[j].FixTooltip);

                        if (viaggi[i].Punti[j].Selezionato) {
                            pointsIcon.push(viaggi[i].Punti[j].IconaSelezionato);
                        } else {
                            pointsIcon.push(viaggi[i].Punti[j].Icona);
                        }
                        //
                        // costruisce l'array per la centratura della mappa sul punto selezionato solo se è attiva la modalità
                        //
                        if (centerOnSelected) {
                            centerMapOnPoint.push(viaggi[i].Punti[j].Selezionato);
                        } else {
                            centerMapOnPoint.push(false);
                        }

                    }
                }
            }
            //
            // centra la mappa sul viaggio selezionato solo se è attiva la modalità
            //
            if ((centerOnSelected) && (viaggi[i].Selezionato)) {
                centerMapOnBoundingRect(viaggi[i].BoundingRect);
            }
        }
    }

    drawPoints(pointsOfTour, pointsId, pointsTooltip, pointsIcon, centerMapOnPoint, false);
};

// *****************************************************************************************************************************
//
// disegna i punti GPS dei viaggi
//
// *****************************************************************************************************************************

function drawTourPointGPS(viaggi, centerOnSelected) {

    var pointsOfTour = [];
    var colore;

    var pointsId = [];
    var pointsTooltip = [];
    var pointsIcon = [];
    var centerMapOnPoint = [];

    for (var i = 0; i < viaggi.length; i++) {

        if ((viaggi[i].Selezionato)) {

            if (viaggi[i].PuntiGPS != null) {

                for (var j = 0; j < viaggi[i].PuntiGPS.length; j++) {
                    var punto = {};
                    punto.x = viaggi[i].PuntiGPS[j].Longitudine;
                    punto.y = viaggi[i].PuntiGPS[j].Latitudine;
                    pointsOfTour.push(punto)

                    pointsId.push('GPS' + viaggi[i].PuntiGPS[j].ID);
                    pointsTooltip.push(viaggi[i].PuntiGPS[j].Tooltip);

                    pointsIcon.push(viaggi[i].PuntiGPS[j].Icona);
                    //
                    // costruisce l'array per la centratura della mappa sul punto selezionato solo se è attiva la modalità
                    //
                    if (centerOnSelected) {
                        centerMapOnPoint.push(viaggi[i].PuntiGPS[j].Selezionato);
                    } else {
                        centerMapOnPoint.push(false);
                    }

                }
                drawPoints(pointsOfTour, pointsId, pointsTooltip, pointsIcon, centerMapOnPoint, false);
            }
            //
            // centra la mappa sul viaggio selezionato solo se è attiva la modalità
            //
            if ((centerOnSelected) && (viaggi[i].Selezionato)) {
                centerMapOnBoundingRect(viaggi[i].boundingRect);
            }
        }
    }
};

// *****************************************************************************************************************************
//
// disegna le linee dei viaggi
//
// *****************************************************************************************************************************

function drawTourLine(viaggi, tipo, centerOnSelected) {

    for (var i = 0; i < viaggi.length; i++) {

        if ((viaggi[i].Visibile) || (viaggi[i].Selezionato)) {

            if (viaggi[i].Selezionato) {
                if (tipo == 'R') {
                    colore = 'rgba(' + viaggi[i].ColoreLineeSelezionato.R + ',' + viaggi[i].ColoreLineeSelezionato.G + ',' + viaggi[i].ColoreLineeSelezionato.B + ',1)';
                } else {
                    colore = 'rgba(' + viaggi[i].ColoreLineeSelezionatoPianificato.R + ',' + viaggi[i].ColoreLineeSelezionatoPianificato.G + ',' + viaggi[i].ColoreLineeSelezionatoPianificato.B + ',1)';
                }

            } else {
                colore = 'rgba(' + viaggi[i].Colore.R + ',' + viaggi[i].Colore.G + ',' + viaggi[i].Colore.B + ',1)';
            }

            if (tipo == 'R') {

                var pointsOfTour = []

                if (viaggi[i].Punti != null) {

                    for (var j = 0; j < viaggi[i].Punti.length; j++) {
                        if (viaggi[i].Punti[j].Esito != 3) {
                            var punto = {};
                            punto.x = viaggi[i].Punti[j].Longitudine;
                            punto.y = viaggi[i].Punti[j].Latitudine;
                            pointsOfTour.push(punto)
                        }
                    }
                    var tooltip = viaggi[i].ID + '-' + viaggi[i].Mezzo;
                    drawLines(pointsOfTour, 'LR' + viaggi[i].ID, tooltip, colore, false);
                }
            } else if (tipo == 'P') {
                var pointsOfTour = new Array(viaggi[i].PuntiPianificati.length);

                if (viaggi[i].PuntiPianificati != null) {

                    for (var j = 0; j < viaggi[i].PuntiPianificati.length; j++) {
                        var punto = {};
                        punto.x = viaggi[i].PuntiPianificati[j].Longitudine;
                        punto.y = viaggi[i].PuntiPianificati[j].Latitudine;
                        pointsOfTour[j] = punto;
                    }
                    var tooltip = viaggi[i].ID + '-' + viaggi[i].Mezzo;
                    drawLines(pointsOfTour, 'LP' + viaggi[i].ID, tooltip, colore, false);
                }
            }
            //
            // centra la mappa sul viaggio selezionato solo se è attiva la modalità
            //
            if (centerOnSelected) {
                centerMapOnBoundingRect(viaggi[i].boundingRect);
            }
        }
    }
};

// *****************************************************************************************************************************
//
// disegna il routing dei viaggi
//
// *****************************************************************************************************************************

function drawTourRouting(viaggi, tipo, centerOnSelected) {

    for (var i = 0; i < viaggi.length; i++) {

        if (viaggi[i].Selezionato) {

            if (tipo == 'R') {
                if (viaggi[i].PuntiPercorsoReale != null) {
                    var pointsOfTour = new Array(viaggi[i].PuntiPercorsoReale.length);
                    colore = 'rgba(' + viaggi[i].ColoreTourSelezionato.R + ',' + viaggi[i].ColoreTourSelezionato.G + ',' + viaggi[i].ColoreTourSelezionato.B + ',1)';

                    for (var j = 0; j < viaggi[i].PuntiPercorsoReale.length; j++) {
                        var punto = {};
                        punto.x = viaggi[i].PuntiPercorsoReale[j].Longitudine;
                        punto.y = viaggi[i].PuntiPercorsoReale[j].Latitudine;
                        pointsOfTour[j] = punto;
                    }
                    var tooltip = viaggi[i].ID;
                    drawLines(pointsOfTour, 'R' + viaggi[i].ID, tooltip, colore, false);
                }
            } else if (tipo == 'P') {
                if (viaggi[i].PuntiPercorsoPianificato != null) {
                    var pointsOfTour = new Array(viaggi[i].PuntiPercorsoPianificato.length);
                    colore = 'rgba(' + viaggi[i].ColoreTourSelezionatoPianificato.R + ',' + viaggi[i].ColoreTourSelezionatoPianificato.G + ',' + viaggi[i].ColoreTourSelezionatoPianificato.B + ',1)';

                    for (var j = 0; j < viaggi[i].PuntiPercorsoPianificato.length; j++) {
                        var punto = {};
                        punto.x = viaggi[i].PuntiPercorsoPianificato[j].Longitudine;
                        punto.y = viaggi[i].PuntiPercorsoPianificato[j].Latitudine;
                        pointsOfTour[j] = punto;
                    }
                    var tooltip = viaggi[i].ID;
                    drawLines(pointsOfTour, 'P' + viaggi[i].ID, tooltip, colore, false);
                }
            }
            //
            // centra la mappa sul viaggio selezionato solo se è attiva la modalità
            //
            if (centerOnSelected) {
                centerMapOnBoundingRect(viaggi[i].boundingRect);
            }
        }
    }
};

// *****************************************************************************************************************************
//
// disegna gli ordini
//
// *****************************************************************************************************************************

function drawOrders(ordini, centerOnSelected) {
    //
    // ordina prima i non selezionati
    //
    ordini = ordini.sort(sortSelezionati);

    var pointsOfOrders = [];
    var pointsId = [];
    var pointsTooltip = [];
    var pointsIcon = [];
    var centerMapOnPoint = [];
    //
    // per gli ordini disegna sulla mappa solo il punto B (consegna)
    //
    for (var i = 0; i < ordini.length; i++) {

        //var puntoA = {};
        //if (ordini[i].puntoA != null) {
        //    puntoA.x = ordini[i].puntoA.Longitudine;
        //    puntoA.y = ordini[i].puntoA.Latitudine;
        //    pointsOfOrders.push(puntoA);
        //    pointsId.push(ordini[i].puntoA.ID);
        //    pointsTooltip.push(ordini[i].puntoA.Tooltip);
        //}

        var puntoB = {};
        puntoB.x = ordini[i].puntoB.Longitudine;
        puntoB.y = ordini[i].puntoB.Latitudine;
        pointsOfOrders.push(puntoB);
        pointsId.push(ordini[i].puntoB.ID);
        pointsTooltip.push(ordini[i].puntoB.Tooltip);

        if (ordini[i].Selezionato) {
            pointsIcon.push(ordini[i].puntoB.IconaSel);
        } else {
            pointsIcon.push(ordini[i].puntoB.Icona);
        }
        //
        // costruisce l'array per la centratura della mappa sul punto selezionato solo se è attiva la modalità
        //
        if (centerOnSelected) {
            centerMapOnPoint.push(ordini[i].Selezionato);
        } else {
            centerMapOnPoint.push(false);
        }
    }

    drawPoints(pointsOfOrders, pointsId, pointsTooltip, pointsIcon, centerMapOnPoint, false);
};

// *****************************************************************************************************************************
//
// disegna i viaggi completi senza la prima e l'ultima tratta
//
// *****************************************************************************************************************************

function drawTourPartial(viaggi, centerOnSelected) {

    //for (var i = 0; i < viaggi.length; i++) {

    //    if ((viaggi[i].visibile) || (viaggi[i].selezionato)) {

    //        var pointsOfTour = new Array(viaggi[i].punti.length - 2);
    //        var colore;

    //        if (viaggi[i].selezionato) {
    //            colore = 'rgba(0,0,0,1)';
    //        } else {
    //            colore = 'rgba(' + viaggi[i].colore.R + ',' + viaggi[i].colore.G + ',' + viaggi[i].colore.B + ',1)';
    //        }

    //        if (viaggi[i].punti != null) {

    //            var inizio;
    //            var fine;
    //            // viaggi del tipo deposito, scarico, deposito rimangono invariati
    //            if (viaggi[i].punti.length == 3) {
    //                inizio = 0;
    //                fine = viaggi[i].punti.length;
    //            } else {    // tolgo il primo e l'ultimo punto
    //                inizio = 1;
    //                fine = viaggi[i].punti.length - 1;
    //            }
    //            for (var j = inizio; j < fine; j++) {
    //                var punto = {};
    //                punto.x = viaggi[i].punti[j].Longitudine;
    //                punto.y = viaggi[i].punti[j].Latitudine;
    //                pointsOfTour[j - 1] = punto;
    //            }
    //            drawLines(pointsOfTour, viaggi[i].ID, viaggi[i].Tooltip, colore, false);
    //            //
    //            // centra la mappa sul viaggio selezionato solo se è attiva la modalità
    //            //
    //            if ((centerOnSelected) && (viaggi[i].selezionato)) {
    //                centerMapOnBoundingRect(viaggi[i].boundingRect);
    //            }
    //        }
    //    }
    //}
};

// *****************************************************************************************************************************
//
// disegna i punti tmperatura dei viaggi
//
// *****************************************************************************************************************************

function drawTourPointTemp(viaggi, centerOnSelected) {

    var pointsOfTour = [];
    var colore;

    var pointsId = [];
    var pointsTooltip = [];
    var pointsIcon = [];
    var centerMapOnPoint = [];

    for (var i = 0; i < viaggi.length; i++) {

        if ((viaggi[i].Selezionato)) {

            if (viaggi[i].PuntiTemperature != null) {

                for (var j = 0; j < viaggi[i].PuntiTemperature.length; j++) {
                    var punto = {};
                    punto.x = viaggi[i].PuntiTemperature[j].Longitudine;
                    punto.y = viaggi[i].PuntiTemperature[j].Latitudine;
                    pointsOfTour.push(punto)

                    pointsId.push('TEMP' + viaggi[i].PuntiTemperature[j].ID);
                    pointsTooltip.push(viaggi[i].PuntiTemperature[j].Tooltip);

                    pointsIcon.push(viaggi[i].PuntiTemperature[j].Icona);
                    //
                    // costruisce l'array per la centratura della mappa sul punto selezionato solo se è attiva la modalità
                    //
                    if (centerOnSelected) {
                        centerMapOnPoint.push(viaggi[i].PuntiTemperature[j].Selezionato);
                    } else {
                        centerMapOnPoint.push(false);
                    }

                }
                drawPointsTemp(pointsOfTour, pointsId, pointsTooltip, pointsIcon, centerMapOnPoint, false);
            }
            //
            // centra la mappa sul viaggio selezionato solo se è attiva la modalità
            //
            if ((centerOnSelected) && (viaggi[i].Selezionato)) {
                centerMapOnBoundingRect(viaggi[i].boundingRect);
            }
        }
    }
};

// *****************************************************************************************************************************
//
// posiziona prima gli ordini non selezionati (nel caso di destinatari doppi viene evidenziato quello selezionato per ultimo sulla mappa)
//
// *****************************************************************************************************************************

function sortSelezionati(first, second) {

    if (first.Selezionato == second.Selezionato)
        return 0;
    if (first.Selezionato < second.Selezionato)
        return -1;
    else
        return 1;
};

// *****************************************************************************************************************************
//
// disegna i depositi
//
// *****************************************************************************************************************************

function drawDepots(depots, centerOnSelected) {
    //
    // ordina prima i non selezionati
    //
    //depots = depots.sort(sortSelezionati);

    //var pointsOfDepots = [];
    //var pointsId = [];
    //var pointsTooltip = [];
    //var pointsIcon = [];
    //var centerMapOnPoint = [];

    //for (var i = 0; i < depots.length; i++) {

    //    var punto = {};
    //    punto.x = depots[i].Longitudine;
    //    punto.y = depots[i].Latitudine;
    //    pointsOfDepots.push(punto);
    //    pointsId.push(depots[i].ID);
    //    pointsTooltip.push(depots[i].Tooltip);
    //    //pointsIcon.push(depots[i].Icona);
    //    //centerMapOnPoint.push(false);

    //    if (depots[i].Selezionato) {
    //        pointsIcon.push(depots[i].IconaSel);
    //    } else {
    //        pointsIcon.push(depots[i].Icona);
    //    }
    //    //
    //    // costruisce l'array per la centratura della mappa sul punto selezionato solo se è attiva la modalità
    //    //
    //    if (centerOnSelected) {
    //        centerMapOnPoint.push(depots[i].Selezionato);
    //    } else {
    //        centerMapOnPoint.push(false);
    //    }
    //}

    //drawPoints(pointsOfDepots, pointsId, pointsTooltip, pointsIcon, centerMapOnPoint, false);
};

// *****************************************************************************************************************************
//
// disegna i punti corrispondenti alla posizione dei singoli mezzi
//
// *****************************************************************************************************************************

function drawViaggiMezzi(viaggi) {

    for (var i = 0; i < viaggi.length; i++) {

        if (viaggi[i].PuntiGPS.length > 0) {

            var pointsGPS = new Array(1);
            var pointsGPSId = new Array(1);
            var pointsGPSTooltip = new Array(1);
            var pointsType = new Array(1);

            var puntoGPS = {};
            puntoGPS.x = viaggi[i].PuntiGPS[0].Longitudine;
            puntoGPS.y = viaggi[i].PuntiGPS[0].Latitudine;
            pointsGPS[0] = puntoGPS;

            pointsGPSId[0] = "UG" + viaggi[i].ID;
            pointsGPSTooltip[0] = viaggi[i].PuntiGPS[0].Tooltip;
            pointsType[0] = viaggi[i].PuntiGPS[0].Tipologia;
            //pointsGPSTooltip[0] = viaggi[i].Autista + '-' + viaggi[i].Mezzo;  //+ ' (km:' + viaggi[i].puntiGPS[index].km + ')';

            drawPointsViaggioMezzo(pointsGPS, pointsGPSId, pointsGPSTooltip, pointsType, viaggi[i].Colore, viaggi[i].TargaMezzo);
        }
    }
}

// *****************************************************************************************************************************
//
// sort basato sul z-order (viene attribuita una priorità lato server)
//
// *****************************************************************************************************************************

function sortOnZOrder(first, second) {

    if (first.hasOwnProperty('ZOrder') && second.hasOwnProperty('ZOrder')) {
        return first.ZOrder - second.ZOrder;
    } else {
        return first.puntoB.ZOrder - second.puntoB.ZOrder;
    }
};
