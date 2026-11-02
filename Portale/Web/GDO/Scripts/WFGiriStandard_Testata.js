
// *****************************************************************************************************
//
//                                              GENERALE 
//
// *****************************************************************************************************
//
// viene chiamata ad ogni postback, anche asincrono
//
function WFIpageLoad() {

};

$(document).ready(function () {
    $(".WFICheckedDropDownList").dropdownchecklist({
        width: 550,
        maxDropHeight: 260,
        firstItemChecksAll: true,
        columns: 4,
        textFormatFunction: function (options) {
            var selectedOptions = options.filter(":selected");
            var t = "";
            for (i = 0; i < selectedOptions.length; i++) {
                if (selectedOptions[i].index > 0) {
                    t += selectedOptions[i].value;
                    if (i + 1 < selectedOptions.length) {
                        t += " ";
                    }
                }
            }
            return t;
        }
    });
})
