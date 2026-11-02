var contextMenuIsVisible = false;
var firstTime = true;

function WFIpageLoad() {
    /*
        GESTIONE Resize delle colonne
    */
    if ($.cookie('StdGrdColWidth') != null) {
        var columns = $.cookie('StdGrdColWidth').split(',');
        var i = 0;
        $('.StdGrdColRisizable HeaderRow th').each(function () {
            $(this).width(columns[i++]);
        });
        i = 0;
        $('.StdGrdColRisizable DataRow td').each(function () {
            $(this).width(columns[i++]);
        });
    }
    $(".StdGrdColRisizable").colResizable({
        liveDrag: true,
        gripInnerHtml: "<div class='grip'></div>",
        draggingClass: "dragging",
        onResize: onSampleResized
    });
    contextMenuIsVisible = false;

    var EnableApplyFilter = true;
    if (EnableApplyFilter) {
        $(".IboWebGridView .DataRow td.BoundField").on("mousedown", function (e) {
            if (e.which == 1) {
                //
                // Left Button pressed + CTRL + SHIFT
                //
                if ((e.ctrlKey) && (e.shiftKey)) {
                    var dataIndex = $(this).attr("data-index");
                    var dataText = this.innerHTML;
                    e.preventDefault();
                    __doPostBack(ContentUpdatePanelId, "APPLYFILTER;" + dataText + ";" + dataIndex);
                    return false;
                }
            }
        });
    }
    //
    // dichiarazione del dictionary degli shortcuts
    //
    var shortCutsDictionary = [];
    var shortCutsDictionaryCTRL = [];

    if (firstTime) {
        //
        // creazione del dictionary degli shortcuts (CON SHIFT)
        //
        var shortCutsString = $("#hdnShortCuts")[0].value;
        if (shortCutsString != "") {
            var t1 = shortCutsString.split(";");
            t1.forEach(function (item, index) {
                var t2 = item.split("=");
                shortCutsDictionary[t2[0]] = t2[1];
            });
        }
        //
        // creazione del dictionary degli shortcuts (CON CTRL)
        //
        shortCutsString = $("#hdnShortCutsWithCTRL")[0].value;
        if (shortCutsString != "") {
            var t1 = shortCutsString.split(";");
            t1.forEach(function (item, index) {
                var t2 = item.split("=");
                shortCutsDictionaryCTRL[t2[0]] = t2[1];
            });
        }

        $("body").on("keydown", function (e) {
            if ((e.shiftKey) & (!(e.ctrlKey))) {
                //
                // PREMUTO SHIFT
                //
                // shortcuts riservati (S, D, Q)
                //
                if (e.keyCode == 83) {
                    // Premuto SHIFT-S (SELEZIONA TUTTO)                
                    __doPostBack(ContentUpdatePanelId, "SELECT_ALL;");
                    return false;

                } else if (e.keyCode == 68) {
                    // Premuto SHIFT-D (DESELEZIONA TUTTO)                
                    __doPostBack(ContentUpdatePanelId, "DESELECT_ALL;");
                    return false;

                } else if (e.keyCode == 81) {
                    // Premuto SHIFT-Q (SI POSIZIONA SULLA CASELLA DI FILTRO RAPIDO (SE VISIBILE))                
                    try {
                        $("input.IncasControl.IboWebTextBox.GridHeaderCellSearchTextTxt").focus();
                        e.preventDefault();
                        return false;
                    }
                    catch (e) { };

                } else if (e.keyCode == 72) {
                    // Premuto SHIFT-H (HELP)                
                    try {
                        e.preventDefault();
                        $("#GridHeaderCellInfo")[0].click();
                        return false;
                    }
                    catch (e) { };

                } else {

                    var carattere = String.fromCharCode(e.keyCode);

                    if (shortCutsDictionary[carattere] != undefined) {
                        try {
                            e.preventDefault();
                            $("div.ToolbarCell.WFIToolbarButton_" + shortCutsDictionary[carattere] + " a")[0].click();
                            return false;
                        }
                        catch (e) { };
                    }
                }
            }
            if (!(e.shiftKey) & (e.ctrlKey)) {
                //
                // PREMUTO CTRL
                //
                var CTRLcarattere = String.fromCharCode(e.keyCode);

                if (shortCutsDictionaryCTRL[CTRLcarattere] != undefined) {
                    try {
                        e.preventDefault();
                        $("div.ToolbarCell.WFIToolbarButton_" + shortCutsDictionaryCTRL[CTRLcarattere] + " a")[0].click();
                        return false;
                    }
                    catch (e) { };
                }
            }
        });
    }
    firstTime = false;
}
var onSampleResized = function (e) {
    var columns = $(e.currentTarget).find("th");
    var msg = "";
    columns.each(function () { msg += $(this).width() + ","; })
    $.cookie("StdGrdColWidth", msg);
};

