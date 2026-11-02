var contextMenuIsVisible = false;
var firstTime = true;

function WFIpageLoad() {
    contextMenuIsVisible = false;

    var EnableApplyFilter = true;
    if (EnableApplyFilter) {
        $(".RadGrid .DataRow td.BoundField").on("mousedown", function (e) {
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

    if (firstTime) {
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

function gridSelectAllRow() {
    var grid = $find(gridId);
    grid.clearSelectedItems();
    var Rows = grid.get_masterTableView().get_dataItems();
    for (var i = 0; i < Rows.length; i++) {
        var row = Rows[i];
        row.set_selected(true);
    }
}
function gridDeselectAllRow() {
    var grid = $find(gridId);
    grid.clearSelectedItems();
    var Rows = grid.get_masterTableView().get_dataItems();
    for (var i = 0; i < Rows.length; i++) {
        var row = Rows[i];
        row.set_selected(false);
    }
}

