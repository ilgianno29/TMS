function WFIpageLoad() {

    /********************************************************************
    *   SPEDIZIONI LIBERE
    ********************************************************************/
    $(".grdSpedizioniLibere tr.DataRow .CellCheckControl input").off("click");
    $(".grdSpedizioniLibere tr.DataRow .CellCheckControl input").on("click", function (event) {
        $(".grdSpedizioniLibere .WFIRowSelected").draggable({
            helper: function (event) {
                return $("<div class='RowDraggable-Dragging'>Spostami su un appuntamento</div>");
            },
            revert: "invalid",
            containment: "div#SchedulerContainer",
            scroll: false,
            delay: 300,
            cursorAt: {
                top: 10,
                left: 10
            },
            start: function (event, ui) {
                $("div.Pianificabile").droppable({
                    drop: function (event, ui) {
                        var IdApp = $(this).find("input#AppointmentData")[0].value;
                        doPostbackWithArguments("ASSOCIA_SPEDIZIONE", "APPID=" + IdApp + ";" + Unibols);
                    },
                    accept: ".grdSpedizioniLibere .WFIRowSelected",
                    activeClass: "CanAccept",
                    hoverClass: "CanAcceptHover",
                    tolerance: "pointer"
                });
                var Unibols = "UNIBOL=";
                $(".grdSpedizioniLibere tr.WFIRowSelected td.KeyField").each(function (i) {
                    if (i == 0) {
                        Unibols = Unibols + $(this)[0].innerText;
                    } else {
                        Unibols = Unibols + ',' + $(this)[0].innerText;
                    }
                });
            },
            stop: function (event, ui) {
                $("div.Pianificabile").droppable("destroy");
            }
        });
    });

    $(".grdSpedizioniLibere tr.HeaderRow th.IboWebGridViewSelectionColumn input").off("mouseup");
    $(".grdSpedizioniLibere tr.HeaderRow th.IboWebGridViewSelectionColumn input").on("mouseup", function (event) {
        $(".grdSpedizioniLibere .WFIRowSelected").draggable({
            helper: function (event) {
                return $("<div class='RowDraggable-Dragging'>Spostami su un appuntamento</div>");
            },
            revert: "invalid",
            containment: "div#SchedulerContainer",
            scroll: false,
            delay: 300,
            cursorAt: {
                top: 10,
                left: 10
            },
            start: function (event, ui) {
                $("div.Pianificabile").droppable({
                    drop: function (event, ui) {
                        var IdApp = $(this).find("input#AppointmentData")[0].value;
                        doPostbackWithArguments("ASSOCIA_SPEDIZIONE", "APPID=" + IdApp + ";" + Unibols);
                    },
                    accept: ".grdSpedizioniLibere .WFIRowSelected",
                    activeClass: "CanAccept",
                    hoverClass: "CanAcceptHover",
                    tolerance: "pointer"
                });
                var Unibols = "UNIBOL=";
                $(".grdSpedizioniLibere tr.WFIRowSelected td.KeyField").each(function (i) {
                    if (i == 0) {
                        Unibols = Unibols + $(this)[0].innerText;
                    } else {
                        Unibols = Unibols + ',' + $(this)[0].innerText;
                    }
                });
            },
            stop: function (event, ui) {
                $("div.Pianificabile").droppable("destroy");
            }
        });
    });

    /********************************************************************
    *   SPEDIZIONI VIAGGIO
    ********************************************************************/
    $(".grdSpedizioniViaggi tr.DataRow .CellCheckControl input").off("click");
    $(".grdSpedizioniViaggi tr.DataRow .CellCheckControl input").on("click", function (event) {
        $(".grdSpedizioniViaggi .WFIRowSelected").draggable({
            helper: function (event) {
                return $("<div class='RowDraggable-Dragging'>Spostami su un appuntamento</div>");
            },
            revert: "invalid",
            containment: "div#SchedulerContainer",
            scroll: false,
            delay: 300,
            cursorAt: {
                top: 10,
                left: 10
            },
            start: function (event, ui) {
                //$("div.Pianificabile").droppable({
                //    drop: function (event, ui) {
                //        var IdApp = $(this).find("input#AppointmentData")[0].value;
                //        //doPostbackWithArguments("ASSOCIA_SPEDIZIONE", "APPID=" + IdApp + ";" + Unibols);
                //    },
                //    accept: ".grdSpedizioniViaggi .WFIRowSelected",
                //    activeClass: "CanAccept",
                //    hoverClass: "CanAcceptHover",
                //    tolerance: "pointer"
                //});
                $("div.Pianificabile").droppable({
                    drop: function (event, ui) {
                        var IdApp = $(this).find("input#AppointmentData")[0].value;
                        doPostbackWithArguments("SPOSTA_SPEDIZIONE", "APPID=" + IdApp + ";" + Unibols);
                    },
                    accept: ".grdSpedizioniViaggi .WFIRowSelected",
                    activeClass: "CanAccept",
                    hoverClass: "CanAcceptHover",
                    tolerance: "pointer"
                });
                var Unibols = "UNIBOL=";
                $(".grdSpedizioniViaggi tr.WFIRowSelected td.KeyField").each(function (i) {
                    if (i == 0) {
                        Unibols = Unibols + $(this)[0].innerText;
                    } else {
                        Unibols = Unibols + ',' + $(this)[0].innerText;
                    }
                });
            },
            stop: function (event, ui) {
                $("div.Pianificabile").droppable("destroy");
            }
        });
    });

    $(".grdSpedizioniViaggi tr.HeaderRow th.IboWebGridViewSelectionColumn input").off("mouseup");
    $(".grdSpedizioniViaggi tr.HeaderRow th.IboWebGridViewSelectionColumn input").on("mouseup", function (event) {
        $(".grdSpedizioniViaggi .WFIRowSelected").draggable({
            helper: function (event) {
                return $("<div class='RowDraggable-Dragging'>I'm a custom helper</div>");
            },
            revert: "invalid",
            containment: "div#SchedulerContainer",
            scroll: false,
            delay: 300,
            cursorAt: {
                top: 10,
                left: 10
            },
            start: function (event, ui) {
                $(".RowDroppable").droppable({
                    drop: function (event, ui) {
                        /*$(this).find("")*/
                        doPostbackWithArguments("CREA_VIAGGIO", "ARG1=1;ARG2=2;");
                    },
                    accept: ".grdSpedizioniViaggi .WFIRowSelected",
                    activeClass: "CanAccept",
                    hoverClass: "CanAcceptHover",
                    tolerance: "pointer"
                });
            },
            stop: function (event, ui) {
                $(".RowDroppable").droppable("destroy");
            }
        });
    });

    /********************************************************************
    *   APPUNTAMENTI
    ********************************************************************/

    $(".div.AppointmentItemRowTemplate .AppointmentItemTemplate.Occupato input").off("click");
    $(".div.AppointmentItemRowTemplate .AppointmentItemTemplate.Occupato input").on("click", function (event) {
        $(".div.AppointmentItemRowTemplate .Selected").draggable({
            helper: function (event) {
                return $("<div class='AppointmentDraggable-Dragging'>Spostami su un appuntamento</div>");
            },
            revert: "invalid",
            containment: "div#SchedulerContainer",
            scroll: false,
            delay: 300,
            cursorAt: {
                top: 10,
                left: 10
            },
            start: function (event, ui) {
                $(".div.AppointmentItemRowTemplate .Pianificabile").droppable({
                    drop: function (event, ui) {
                        var IdApp = $(this).find("input#AppointmentData")[0].value;
                        doPostbackWithArguments("ASSOCIA_SPEDIZIONE", "APPID=" + IdApp + ";" + Unibols);
                    },
                    accept: ".div.AppointmentItemRowTemplate .Occupato.Selected",
                    activeClass: "CanAccept",
                    hoverClass: "CanAcceptHover",
                    tolerance: "pointer"
                });
                var Unibols = "UNIBOL=";
                //$(".grdSpedizioniLibere tr.WFIRowSelected td.KeyField").each(function (i) {
                //    if (i == 0) {
                //        Unibols = Unibols + $(this)[0].innerText;
                //    } else {
                //        Unibols = Unibols + ',' + $(this)[0].innerText;
                //    }
                //});
            },
            stop: function (event, ui) {
                $(".div.AppointmentItemRowTemplate .Pianificabile").droppable("destroy");
            }
        });
    });

    //$(".AppointmentDraggable").draggable({
    //    helper: function (event) {
    //        return $("<div class='AppointmentDraggable-Dragging'>I'm a custom helper</div>");
    //    },
    //    revert: "invalid",
    //    containment: "div.ResourcePlusPivotPanel",
    //    scroll: true,
    //    delay: 300,
    //    cursorAt: {
    //        top: 10,
    //        left: 10
    //    },
    //    start: function (event, ui) {
    //        $("#PostbackAllowed")[0].value = "N";
    //        $(".AppointmentDroppable").droppable({
    //            drop: function (event, ui) {
    //                /*$(this).find("")*/
    //                doPostbackWithArguments("UNISCI_VIAGGI", "ARG1=1;ARG2=2;");
    //            },
    //            accept: ".Occupato.AppointmentDraggable",
    //            activeClass: "CanAccept",
    //            hoverClass: "CanAcceptHover",
    //            tolerance: "pointer"
    //        });
    //    },
    //    stop: function (event, ui) {
    //        $("#PostbackAllowed")[0].value = "S";
    //        $(".AppointmentDroppable").droppable("destroy");
    //    },
    //});

    $("div.AppointmentItemTemplateContainer").off("click");
    $("div.AppointmentItemTemplateContainer").on("click", function (event) {

        var Arguments = $(this).find("#AppointmentData")[0].value;
        if ($(this)[0].classList.contains("Selected")) {
            $(this)[0].classList.remove("Selected");
        } else {
            $(this)[0].classList.remove("Selected");
            $(this)[0].classList.add("Selected");
        }

        if (!($(this)[0].classList.contains("Libero"))) {
            doPostbackWithArguments("SELEZIONA_APPUNTAMENTO", Arguments);        
        } else {
            WFI.Callback_SendToServer("SELEZIONA_APPUNTAMENTO;" + Arguments, "");
        }                
    });

    $("#ctl00_phPageContent_TcMain_tpSpedizioni_tab a.ajax__tab_tab").off("click");
    $("#ctl00_phPageContent_TcMain_tpSpedizioni_tab a.ajax__tab_tab").on("click", function (event) {
        doPostbackWithArguments("CAMBIO_TAB", "0");
    });

    $("#ctl00_phPageContent_TcMain_tpSpedizioniPianificate_tab a.ajax__tab_tab").off("click");
    $("#ctl00_phPageContent_TcMain_tpSpedizioniPianificate_tab a.ajax__tab_tab").on("click", function (event) {
        doPostbackWithArguments("CAMBIO_TAB", "1");
    });

    $("#ctl00_phPageContent_TcMain_tpMezziIndisponibili_tab a.ajax__tab_tab").off("click");
    $("#ctl00_phPageContent_TcMain_tpMezziIndisponibili_tab a.ajax__tab_tab").on("click", function (event) {
        doPostbackWithArguments("CAMBIO_TAB", "2");
    });
}

function autoSlide(event, obj) {
    var myParent = obj.parentElement.parentElement.parentElement;
    var nextidx = (parseInt($(myParent).find('.SS_current').index() + 1) == $(myParent).find('.SS_slide').length) ? 0 : parseInt($(myParent).find('.SS_current').index() + 1);
    $(myParent).find('.SS_current').fadeOut(200, function () {
        $(this).removeClass('SS_current');
        $(myParent).find('.SS_slide').eq(nextidx).fadeIn(200, function () {
            $(this).addClass('SS_current');
        });
    });
    event.stopPropagation();
}


function _Callback_ReceiveServerData(ReturnValue) {
    try {
        var res = ReturnValue.split("###");
        if (res[0] == "SELEZIONA_APPUNTAMENTO") {
            if (res[1] == "OK") {
                // tutto ok la selezione
            }
        }
    }
    catch (e) { }
}

function doPostbackWithArguments(Comando, Argomenti) {
    if ($("#PostbackAllowed")[0].value == "S") {
        $("#PostbackCommand")[0].value = Comando;
        $("#PostbackArguments")[0].value = Argomenti;
        $("#PostbackRun")[0].click();
    }

}







////////function WFIpageLoad() {

////////    $(".DataRow").draggable({
////////        helper: function (event) {
////////            return $("<div class='RowDraggable-Dragging'>I'm a custom helper</div>");
////////        },
////////        revert: "invalid",
////////        containment: "div#SchedulerContainer",
////////        scroll: false,
////////        delay: 300,
////////        cursorAt: {
////////            top: 10,
////////            left: 10
////////        },
////////        start: function (event, ui) {
////////            $(".RowDroppable").droppable({
////////                drop: function (event, ui) {
////////                    /*$(this).find("")*/
////////                    doPostbackWithArguments("CREA_VIAGGIO", "ARG1=1;ARG2=2;");
////////                },
////////                accept: ".WFIRowSelected",
////////                activeClass: "CanAccept",
////////                hoverClass: "CanAcceptHover",
////////                tolerance: "pointer"
////////            });
////////        },
////////        stop: function (event, ui) {
////////            $(".RowDroppable").droppable("destroy");
////////        }
////////    });

////////    $(".AppointmentDraggable").draggable({
////////        helper: function (event) {
////////            return $("<div class='AppointmentDraggable-Dragging'>I'm a custom helper</div>");
////////        },
////////        revert: "invalid",
////////        containment: "div.ResourcePlusPivotPanel",
////////        scroll: true,
////////        delay: 300,
////////        cursorAt: {
////////            top: 10,
////////            left: 10
////////        },
////////        start: function (event, ui) {
////////            $("#PostbackAllowed")[0].value = "N";
////////            $(".AppointmentDroppable").droppable({
////////                drop: function (event, ui) {
////////                    /*$(this).find("")*/
////////                    doPostbackWithArguments("UNISCI_VIAGGI", "ARG1=1;ARG2=2;");
////////                },
////////                accept: ".Occupato.AppointmentDraggable",
////////                activeClass: "CanAccept",
////////                hoverClass: "CanAcceptHover",
////////                tolerance: "pointer"
////////            });
////////        },
////////        stop: function (event, ui) {
////////            $("#PostbackAllowed")[0].value = "S";
////////            $(".AppointmentDroppable").droppable("destroy");
////////        },
////////    });

////////    $("div.AppointmentItemTemplate").on("click", function (event) {
////////        var Arguments = $(this).find("#AppointmentData")[0].value;
////////        doPostbackWithArguments("SELEZIONA_APPUNTAMENTO", Arguments);
////////    });

////////    $(".DataRow").on("click", function (event) {
////////        $(".DataRow").draggable({
////////            helper: function (event) {
////////                return $("<div class='RowDraggable-Dragging'>I'm a custom helper</div>");
////////            },
////////            revert: "invalid",
////////            containment: "div#SchedulerContainer",
////////            scroll: false,
////////            delay: 300,
////////            cursorAt: {
////////                top: 10,
////////                left: 10
////////            },
////////            start: function (event, ui) {
////////                $(".RowDroppable").droppable({
////////                    drop: function (event, ui) {
////////                        /*$(this).find("")*/
////////                        doPostbackWithArguments("CREA_VIAGGIO", "ARG1=1;ARG2=2;");
////////                    },
////////                    accept: ".WFIRowSelected",
////////                    activeClass: "CanAccept",
////////                    hoverClass: "CanAcceptHover",
////////                    tolerance: "pointer"
////////                });
////////            },
////////            stop: function (event, ui) {
////////                $(".RowDroppable").droppable("destroy");
////////            }
////////        });
////////    });

////////}

////////function doPostbackWithArguments(Comando, Argomenti) {
////////    if ($("#PostbackAllowed")[0].value == "S") {
////////        $("#PostbackCommand")[0].value = Comando;
////////        $("#PostbackArguments")[0].value = Argomenti;
////////        $("#PostbackRun")[0].click();
////////    }

////////}
