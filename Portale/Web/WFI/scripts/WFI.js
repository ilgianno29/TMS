
var WFI = new WFICore();
function get_WFIinstance() {
    return WFI;
}
function WFICore() {
    var asyncState = true;
    $(function () {
        XMLHttpRequest.prototype.original_open = XMLHttpRequest.prototype.open;
        XMLHttpRequest.prototype.open = function (method, url, async, user, password) {
            async = asyncState;
            var eventArgs = Array.prototype.slice.call(arguments);
            return this.original_open.apply(this, eventArgs);
        }
    })
    /*
        Gestione log to Console javascript
    */
    this.Now = function () {
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!
        var yyyy = today.getFullYear();
        var hh = today.getHours();
        var mi = today.getMinutes();
        var ss = today.getSeconds();
        var ms = today.getMilliseconds();
        if (dd < 10) {
            dd = '0' + dd;
        }
        if (mm < 10) {
            mm = '0' + mm;
        }
        if (hh < 10) {
            hh = '0' + hh;
        }
        if (mi < 10) {
            mi = '0' + mi;
        }
        if (ss < 10) {
            ss = '0' + ss;
        }
        if (ms < 10) {
            ms = '00' + ms;
        } else {
            if (ms < 100) {
                ms = '0' + ms;
            }
        }
        today = mm + '/' + dd + '/' + yyyy + ' ' + hh + '.' + mi + '.' + ss + '.' + ms;
        return today;
    }
    this.IsDebug = function () { return true; }
    this.WriteToConsole = function (info) {
        try {
            if (this.IsDebug()) { console.log(this.Now() + ': ' + info); }
        } catch (e) { }
    }
    /*
        Funzione per determinare la larghezza della scrollbar
    */
    this.getScrollBarWidth = function () {
        var inner = document.createElement('p');
        inner.style.width = "100%";
        inner.style.height = "200px";

        var outer = document.createElement('div');
        outer.style.position = "absolute";
        outer.style.top = "0px";
        outer.style.left = "0px";
        outer.style.visibility = "hidden";
        outer.style.width = "200px";
        outer.style.height = "150px";
        outer.style.overflow = "hidden";
        outer.appendChild(inner);

        document.body.appendChild(outer);
        var w1 = inner.offsetWidth;
        outer.style.overflow = 'scroll';
        var w2 = inner.offsetWidth;
        if (w1 == w2) w2 = outer.clientWidth;

        document.body.removeChild(outer);

        return (w1 - w2);
    };

    /*
    Gestione Focus Incas
    */
    var _btn;
    this.btn = function () {
        return _btn;
    }
    this.IncasSetFocus = function () {
        var CtrlFocused;
        var CtrlFocused2;
        CtrlFocused = document.getElementById('HFIncasFocus');
        CtrlFocused2 = document.getElementById('HFIncasFocus2');
        if (CtrlFocused2 != null) {
            if (CtrlFocused2.value != '') { _btn = CtrlFocused2; }
            else { _btn = CtrlFocused; }
        }
        else { _btn = CtrlFocused; }
        if (_btn != null) {
            var btn1 = document.getElementById(_btn.value);
            if (btn1 != null) {
                setTimeout("WFI.IncasSetFocusApply();", 100);
            }
        }
    }
    this.IncasSetFocusApply = function () {
        document.getElementById(WFI.btn().value).focus();
        WFI.btn().value = '';
    }

    /*
    Funzione per disabilitare F5 sul browser e il tasto backspace
    */
    $(function () {
        var rx = /INPUT|TEXTAREA/i;
        var rxT = /RADIO|CHECKBOX|SUBMIT/i;

        $(document).bind("keydown keypress", function (e) {
            if ((e.which == 116) && (e.charCode == 0)) {
                e.preventDefault();
            }
            else {
                var preventKeyPress;
                if (e.keyCode == 8) {
                    var d = e.srcElement || e.target;
                    if (rx.test(e.target.tagName)) {
                        var preventPressBasedOnType = false;
                        if (d.attributes["type"]) {
                            preventPressBasedOnType = rxT.test(d.attributes["type"].value);
                        }
                        preventKeyPress = d.readOnly || d.disabled || preventPressBasedOnType;
                    } else { preventKeyPress = true; }
                } else { preventKeyPress = false; }
                if (preventKeyPress) { e.preventDefault(); }
            }
        });
    });

    /*
    Funzione per autocompleteextender
    */
    this.SetHFMPSelectedValue = function (source, eventArgs) {
        document.getElementById("HFMPGeneralSearch").value = eventArgs.get_value();
        document.getElementById("MPGeneralSearchGo").click();
    }
    /*
    Funzione di visualizzazione menu contestuale dalle griglie interne (WFIMasterDetail)
    */
    this.showMenuCtx = function (e, ToolbarClientId) {
        var contextMenu = $find(ToolbarClientId);
        $telerik.cancelRawEvent(e);
        if ((!e.relatedTarget) || (!$telerik.isDescendantOrSelf(contextMenu.get_element(), e.relatedTarget))) {
            contextMenu.show(e);
        }
    }

    /*
    Funzioni per la gestione IFrame
    */
    var _timer;
    var _waitingForResponse = false;
    var _getResponse = false;
    var _TimerEnabled = false;

    this.IFrameWaitingManager = function () {
        if ($("#IFrameManager_StartPolling")[0].value == "1") {
            _getResponse = false;
            _TimerEnabled = true;
            if ($("#IFrameManager_AutoResize")[0].value == "1") {
                IFrameManager_AutoResize();
                $("#IFrameManager_AutoResize")[0].value = "0";
            }
            _timer = setInterval(function () { IFrameWaitingManager_Timer() }, 500);
        }
        else {
            if (!(_timer == undefined)) {
                clearInterval(_timer);
            }
        }
    }
    this.IFrameClearInterval = function () {
        clearInterval(_timer);
    }
    function WaitingForIFrameResponse(param1) {
        var dataValue = "{param1:'" + param1 + "'}";
        //PageMethods.WaitingForIFrameResponse(param1, WaitingForIFrameResponse_OnComplete, WaitingForIFrameResponse_OnTimeout, WaitingForIFrameResponse_OnError);
        try {
            if (document.getElementById("ctl00_MasterIFrame").contentWindow.get_WFIinstance().CanIClose()) {
                WaitingForIFrameResponse_OnComplete(1);
                return;
            }
        }
        catch (e) {
        }
        WaitingForIFrameResponse_OnComplete(0);
    }
    var _CanIClose = false;
    this.CanIClose = function () {
        return _CanIClose;
    }
    this.set_CanIClose = function (valBool) {
        _CanIClose = valBool;
    }
    function WaitingForIFrameResponse_OnComplete(cnt) {
        var ret = cnt;
        if (ret == 1) {
            /*
            Waiting finito devo causare un postback
            */
            _getResponse = true;
            $("#IFrameManager_StopPolling")[0].click();
            _TimerEnabled = false;
        }
        _waitingForResponse = false;
    }
    function IFrameWaitingManager_Timer() {
        if (_TimerEnabled) {
            if ((!_waitingForResponse) && (!_getResponse)) {
                _waitingForResponse = true;
                var param1 = "";
                WaitingForIFrameResponse(param1);
            }
        }
    }
    /*
     IFRAME AutoResize
    */
    function IFrameManager_AutoResize() {
        // Set specific variable to represent all iframe tags.
        if ($(".Browser_SAFARI .IFrameContainerDiv .MasterIFrame").length > 0) {
            $(".Browser_SAFARI .IFrameContainerDiv .MasterIFrame").load(function () {
                setTimeout(myfunc = function (mythis) {
                    var h = 25;
                    try {
                        h = $("div.IFrameTitle")[0].offsetHeight;
                    } catch (e) { }
                    $(".Browser_SAFARI #IFrameGlobalContainer .IFrameContainer")[0].style.height = mythis.contentWindow.document.body.offsetHeight + h + 'px';
                    mythis.style.height = mythis.contentWindow.document.body.offsetHeight + 'px';
                    //$(".Browser_SAFARI .IFrameContainerDiv .MasterIFrame").unbind("load");                    
                }(this), 0);
            });
        } else {
            if ($(".IFrameContainerDiv .MasterIFrame").length > 0) {
                $(".IFrameContainerDiv .MasterIFrame").load(function () {
                    try {
                        var h = 25;
                        try {
                            h = $("div.IFrameTitle")[0].offsetHeight;
                        } catch (e) { }
                        //dimensione della finestra (comprensiva di titolo + IFrame)
                        $("#IFrameGlobalContainer .IFrameContainer")[0].style.height = this.contentWindow.document.body.offsetHeight + h + 'px';
                        // dimensione dell'IFrame
                        this.style.height = this.contentWindow.document.body.offsetHeight + 'px';
                        $(".IFrameContainerDiv .MasterIFrame").unbind("load");
                    }
                    catch (e) { };
                });
            }
        }
    }
    /*
   Funzioni per la gestione del polling della progressbar
   */
    var _ProgressBarTimer;
    var _ProgressBarWaitingForResponse = false;
    var _ProgressBarGetResponse = false;
    var _ProgressBarTimerEnabled = false;
    var _ProgressBarTimeStarted = new Date();

    this.ProgressbarWaitingManager = function () {
        if ($("#Progressbar_StartPolling")[0].value > 0) {
            _ProgressBarGetResponse = false;
            _ProgressBarTimerEnabled = true;
            _ProgressBarTimeStarted = new Date();
            _ProgressBarTimer = setInterval(function () { ProgressBarWaitingManager_Timer() }, $("#Progressbar_StartPolling")[0].value);
            $("#Progressbar_StartPolling")[0].value = "";
        }
        else {
            if (!(_ProgressBarTimer == undefined)) {
                clearInterval(_ProgressBarTimer);
            }
        }
    }
    this.ProgressbarClearInterval = function () {
        clearInterval(_ProgressBarTimer);
    }
    function WaitingForProgressbarResponse(param1) {
        var dataValue = "{param1:'" + param1 + "'}";
        var Title = "";
        var MainMessage = "";
        var DetailMessage = "";
        var Percentage = 0;
        PageMethods.WaitingForProgressbarResponse(dataValue, WaitingForProgressbarResponse_OnComplete, WaitingForProgressbarResponse_OnTimeout, WaitingForProgressbarResponse_OnError);
    }
    function WaitingForProgressbarResponse_OnComplete(cnt) {
        var ret = cnt;
        try {
            if (ret.Percentage == 100) {
                /*
                attesa finita devo causare un postback
                */
                _ProgressBarGetResponse = true;
                $("#Progressbar_StopPolling")[0].click();
                _ProgressBarTimerEnabled = false;
                _ProgressBarTimeElapsed = 0;
            }
            else {
                /*
                attesa non finita. Aggiorno l'interfaccia della progressbar
                */
                if (ret.ProgressbarType == 0) {
                    //
                    // Progress bar con percentuale
                    //
                    $("#ProgressbarCaption")[0].innerHTML = ret.Title;
                    $("#ProgressbarDescription")[0].innerHTML = ret.MainMessage;
                    $("#ProgressbarDetail")[0].innerHTML = ret.DetailMessage;
                    if (ret.PercentageVisible) {
                        $("#lblProgressbarPercentuale")[0].innerHTML = ret.Percentage + "%";
                    }
                    else {
                        $("#lblProgressbarPercentuale")[0].innerHTML = "";
                    }
                    $("#ProgressBarLayout").css("width", ret.Percentage + "%");
                }
                else {
                    //
                    // Progress bar con immagine gif statica e secondi di attesa
                    //
                    if (ret.ProgressbarType == 1) {
                        $("#lblProgressbarTimeElapsed")[0].innerHTML = ret.TimeElapsed + " sec.";
                    }
                }
            }
            _ProgressBarWaitingForResponse = false;
        }
        catch (e) {
        }
    }
    function WaitingForProgressbarResponse_OnTimeout(cnt) {
    }
    function WaitingForProgressbarResponse_OnError(cnt) {
    }
    function ProgressBarWaitingManager_Timer() {
        if (_ProgressBarTimerEnabled) {
            if ((!_ProgressBarWaitingForResponse) && (!_ProgressBarGetResponse)) {
                _ProgressBarWaitingForResponse = true;
                var param1 = "";
                WaitingForProgressbarResponse(param1);
            }
        }
    }

    //
    //    Funzioni per la gestione del polling del Keep alive
    //
    var _KeepAliveTimer;
    var _KeepAliveWaitingForResponse = false;
    var _KeepAliveGetResponse = false;
    var _KeepAliveTimerEnabled = false;
    var _KeepAliveTimeStarted = new Date();

    this.KeepAliveWaitingManager = function () {
        if ($("#KeepAlive_StartPolling")[0].value > 0) {
            _KeepAliveGetResponse = false;
            _KeepAliveTimerEnabled = true;
            _KeepAliveTimeStarted = new Date();
            _KeepAliveTimer = setInterval(function () { KeepAliveWaitingManager_Timer() }, $("#KeepAlive_StartPolling")[0].value);
            $("#KeepAlive_StartPolling")[0].value = "";
        }
        else {
            if (!(_KeepAliveTimer == undefined)) {
                clearInterval(_KeepAliveTimer);
            }
        }
    }
    this.KeepAliveClearInterval = function () {
        clearInterval(_KeepAliveTimer);
    }
    function WaitingForKeepAliveResponse(EventParam) {
        var dataValue = EventParam;
        PageMethods.RealTimeEventPolling(dataValue, WaitingForForKeepAliveResponse_OnComplete, WaitingForForKeepAliveResponse_OnTimeout, WaitingForForKeepAliveResponse_OnError);
    }
    function WaitingForForKeepAliveResponse_OnComplete(cnt) {
        var ret = cnt;
        try {
            _KeepAliveWaitingForResponse = false;
        }
        catch (e) {
        }
    }
    function WaitingForForKeepAliveResponse_OnTimeout(cnt) {
        _KeepAliveWaitingForResponse = false;
    }
    function WaitingForForKeepAliveResponse_OnError(cnt) {
        _KeepAliveWaitingForResponse = false;
    }
    function KeepAliveWaitingManager_Timer() {
        if (_KeepAliveTimerEnabled) {
            if ((!_KeepAliveWaitingForResponse) && (!_KeepAliveGetResponse)) {
                _KeepAliveWaitingForResponse = true;
                WaitingForKeepAliveResponse("KEEP_ALIVE");
            }
        }
    }
    //
    // Funzioni per JavascriptEval
    //
    this.JavascriptEvalFunc = function () {
        var code = document.getElementById("JavascriptEval");
        if (code != "") {
            try { eval(code.value); } catch (e) { };
            code.value = "";
        }
    }
    //
    // Funzione WFIgetPosition (ritorna la posizione x, y di un oggetto)
    //
    this.getPosition = function (obj) {
        var pos = Array();
        pos['left'] = 0;
        pos['top'] = 0;
        if (obj) {
            while (obj.offsetParent) {
                pos['left'] += obj.offsetLeft - obj.scrollLeft;
                pos['top'] += obj.offsetTop - obj.scrollTop;
                var tmp = obj.parentNode;
                while (tmp != obj.offsetParent) {
                    pos['left'] -= tmp.scrollLeft;
                    pos['top'] -= tmp.scrollTop;
                    tmp = tmp.parentNode;
                }
                obj = obj.offsetParent;
            }
            pos['left'] += obj.offsetLeft;
            pos['top'] += obj.offsetTop;
        }
        return { x: pos['left'], y: pos['top'] };
    }
    //
    // MaskedEditFix.js
    //
    // Fixes issue with delete key not working on Ipad browsers.
    //
    this.MaskedEditFix = function () {
        try {
            var p = Sys.Extended.UI.MaskedEditBehavior.prototype,
                en = p._ExecuteNav;
            p._ExecuteNav = function (e) {
                var type = e.type;
                if (type == 'keydown') { e.type = 'keypress' };
                en.apply(this, arguments);
                e.type = type;
            }
        } catch (e) {
            return;
        }
    }
    //
    // Configrm Dialog
    //
    var WFIdialogConfirmed = false;
    this.ConfirmDialog = function (obj, title, dialogText, dlgwidth, dlgHeight) {
        String.Format = function () {
            var s = arguments[0];
            for (var i = 0; i < arguments.length - 1; i++) {
                var reg = new RegExp("\\{" + i + "\\}", "gm");
                s = s.replace(reg, arguments[i + 1]);
            }
            return s;
        }
        if (title == "") { title = "&nbsp;"; }
        if (dlgHeight == "undefined") { dlgHeight = "auto"; }
        if (dlgwidth == "undefined") { dlgwidth = "auto"; }
        if (!WFIdialogConfirmed) {
            $(obj.parentElement).append(String.Format("<div id='WFIConfirmDialog' title='{0}'><p>{1}</p></div>", title, dialogText));
            $('#WFIConfirmDialog').dialog
            ({
                minHeight: 200,
                maxHeight: 500,
                minWidth: 400,
                maxWidth: 800,
                height: dlgHeight,
                width: dlgwidth,
                modal: true,
                resizable: false,
                closeOnEscape: true,
                draggable: true,
                dialogClass: "WFIConfirmDialog",
                close: function (event, ui) { $(obj.parentElement).find('#WFIConfirmDialog').remove(); },
                buttons:
                {
                    'Si': function () {
                        $(this).dialog('close');
                        WFIdialogConfirmed = true;
                        if (obj) obj.click();
                    },
                    'No': function () {
                        $(this).dialog('close');
                    }
                }
            });
        }
        return WFIdialogConfirmed;
    }
    //
    // Funzione WFIgetPosition (ritorna la posizione x, y di un oggetto)
    //
    this.setScreenDimensions = function () {
        $("#ScreenDimensions")[0].value = window.screen.height + ";" + window.screen.width + ";" + window.innerHeight + ";" + window.innerWidth
    }

    this.WFICookiesBar = function () {
        try {
            if (_WFICookiesBarConfig.enabled) {
                $.cookieBar(_WFICookiesBarConfig);
                //
                // _WFICookiesBarConfig è definito sulla master page
                //
            }
        } catch (e) { };
    }
    //
    // determina se siamo in un postback oppure al primo rendering
    //
    this.isPostback = function () {
        try {
            var _ispostback = $("input#HF_IsPostBack")[0].value;
            var ret = false;
            if (_ispostback == "0") {
                ret = false;
            }
            else if (_ispostback == "1") {
                ret = true;
            }
            return ret
        } catch (e) { return "" };
    }
    //
    // Gestione eventi di pagina
    //
    this.pageLoad = function () {
        var startTime = Date.now();
        this.WriteToConsole("pageLoad BEGIN");
        this.WriteToConsole("setScreenDimensions");
        try { this.setScreenDimensions(); } catch (e) { };
        this.WriteToConsole("htmltooltipFunc");
        try { htmltooltipFunc(); } catch (e) { };
        this.WriteToConsole("IncasSetFocus");
        try { this.IncasSetFocus(); } catch (e) { };
        this.WriteToConsole("IFrameWaitingManager");
        try { this.IFrameWaitingManager(); } catch (e) { this.IFrameClearInterval(); };
        this.WriteToConsole("ProgressbarWaitingManager");
        try { this.ProgressbarWaitingManager(); } catch (e) { this.ProgressbarClearInterval(); };
        this.WriteToConsole("KeepAliveWaitingManager");
        try { this.KeepAliveWaitingManager(); } catch (e) { this.KeepAliveClearInterval(); };
        this.WriteToConsole("JavascriptEvalFunc");
        try { this.JavascriptEvalFunc(); } catch (e) { };
        this.WriteToConsole("WFITooltipify");
        try { this.WFITooltipify(); } catch (e) { };
        this.WriteToConsole("WFIScrollableGrid");
        try {
            /*
                   Gestione scorrimento verticale fisso per griglie MS
            */
            if (WFI.browserDetect() != "SAFARI") {
                var defaults = {
                    ScrollHeight: 0
                };
                $('.IboWebGridView.stdGrdScrollable').Scrollable(defaults);
            } else {
                //
                // Safari non funziona con questa estensione almeno fino alla 5.1.7
                //                
            }

        } catch (e) { };

        try {
            /*
                   dropdownlist in stile jquery ui
            */
            $(".ui-selectmenu-menu.ui-front.incas-ui-selectmenu-menu").remove();
            $(".IboWebDropDownList.jquery-ui-style").selectmenu({
                change: function (event, ui) { $(".IboWebDropDownList.jquery-ui-style").change(); }
            }); $(".ui-selectmenu-menu").addClass("incas-ui-selectmenu-menu"); $(".ui-selectmenu-button").addClass("incas-ui-selectmenu-menu");
        } catch (e) { };
        this.WriteToConsole("MaskedEditFix");
        try { this.MaskedEditFix(); } catch (e) { };
        this.WriteToConsole("WFIAutoComplete");
        try { this.WFIAutoComplete(); } catch (e) { };
        this.WriteToConsole("WFICookiesBar");
        try { this.WFICookiesBar(); } catch (e) { };
        this.WriteToConsole("jqDropdown INIT");
        try { $.fn.jqDropdown('init'); } catch (e) { };
        //
        // inizializzazione imageViewer
        //
        this.WriteToConsole("Image Viewer INIT");
        try {
            if ($('.WFI-gallery-items').length > 0) {
                var viewer = ImageViewer();
                $('.WFI-gallery-items').click(function () {
                    var imgSrc = this.src;
                    var highResolutionImage = $(this).data('high-res-src');
                    viewer.show(imgSrc, highResolutionImage);
                });
            }
        } catch (e) { };
        //
        // Caricamento dei scrolldiv
        //
        this.WriteToConsole("Caricamento dei scrolldiv");
        try {
            $("div.WFIMantainScrollPosition").scrollPosLoad();
        } catch (e) { };
        this.WriteToConsole("WFIpageLoad");
        try { if (typeof WFIpageLoad == 'function') { WFIpageLoad(); } } catch (e) { };
        var EndTime = Date.now();
        this.WriteToConsole("pageLoad END. Total Time: " + (EndTime - startTime));
    }
    this.pageUnload = function () {
    }
    this.pageBeginRequest = function () {
        //
        // eliminazione elementi tooltip
        //
        try {
            if ($("#JqueryToolTipManagerEnable")[0].value == "1") {
                $("[title],a.WFIAjaxHtmlTooltip").tooltip("destroy");
            }
        } catch (e) { };
        //
        // Salvataggio posizione scrollbar
        //
        try {
            $("div.WFIMantainScrollPosition").scrollPosSave();
        } catch (e) { };
        try {
            WFIpageBeginRequest();
        } catch (e) { };
    }
    this.PageLoaded = function () {
        try { WFIpageLoaded(); } catch (e) { };
    }
    this.browserDetect = function () {
        return $("#BrowserDetect")[0].value;
    }
    var hashtableId = {};
    this.WFITooltipify = function () {
        var _wfi = this;
        /*
            Supporto per Tooltipify di Jquery-UI
        */
        var hashtable = {};
        setTimeout(function () {
            if ($("#JqueryToolTipManagerEnable")[0].value == "1") {
                $(".JqueryUIToolTipDiv").remove();
                $(".ui-tooltip").remove();
                if (!(_wfi.isPostback)) {
                    //
                    // svuoto la cache per Id
                    //
                    hashtableId = {};
                }
                $("[title],a.WFIAjaxHtmlTooltip,[wfititleid],.wfititleid").tooltip({
                    items: "[title], a.WFIAjaxHtmlTooltip, [wfititleid], .wfititleid",
                    show: { effect: "fadeIn", delay: parseInt($("#JqueryToolTipManager_ShowDelay")[0].value), duration: parseInt($("#JqueryToolTipManager_AnimationDuration")[0].value) },
                    open: function (event, ui) {
                        var element = $(this);
                        if ((element.is("[title]")) || (element.is("a.WFIAjaxHtmlTooltip")) || (element.is("[wfititleid]")) || (element.is(".wfititleid"))) {
                            if (typeof event.originalEvent != "undefined") {
                                var element = $(event.originalEvent.target);
                                var titleDataDuration = 0;
                                var NotCloseIfHover = false;
                                var TimeoutVar;
                                //
                                // Gestione durata del tooltip
                                //
                                if (element.is("[title-data-duration]")) {
                                    titleDataDuration = parseInt(element.attr("title-data-duration"));
                                } else {
                                    titleDataDuration = parseInt($("#JqueryToolTipManagerDuration")[0].value);
                                }
                                //
                                // Gestione modalità NotCloseIfHover
                                //
                                if (element.is("[title-data-notCloseIfHover]")) {
                                    NotCloseIfHover = (element.attr("title-data-notCloseIfHover") == "1");
                                } else {
                                    NotCloseIfHover = ($("#JqueryToolTipManager_NotCloseIfHover")[0].value == "1");
                                }
                                if (NotCloseIfHover) {
                                    ui.tooltip.hover(
                                    function () {
                                        //
                                        // se vado dentro il tooltip, resetto il timeout che mi fa chiudere il tooltip. Il tooltip rimarrà sempre aperto fino a che non uscirò con il mouse dai suoi bordi
                                        //
                                        clearTimeout(TimeoutVar);
                                        $(this).stop(true).fadeTo(300, 1);
                                    },
                                    function () {
                                        var that = $(this);
                                        setTimeout(function () {
                                            that.fadeOut("300", function () { $(this).remove(); })
                                        }, 300);
                                    }
                                );
                                }
                                //
                                // Chiusura automatica del tooltip dopo x millisecondi
                                //
                                TimeoutVar = setTimeout(function () {
                                    $(ui.tooltip).hide('fade', 300);
                                }, titleDataDuration);
                            } else {
                                setTimeout(function () {
                                    $(ui.tooltip).hide();
                                }, 1);
                            }
                        }
                        if (element.is("a.WFIAjaxHtmlTooltip")) {
                            //
                            // Ajax tooltip
                            //
                            var param1 = element.find("#TooltipSelect")[0].value;
                            //
                            // verifico se è presente in cache
                            //
                            var cont = hashtable[param1];
                            element.tooltip("option", "content", cont);
                        }
                        if ((element.is("[wfititleid]")) || (element.is(".wfititleid"))) {
                            //
                            // Ajax tooltip
                            //
                            var param1 = element.attr("WFITitleId");
                            if (param1 == undefined) {
                                param1 = element.attr("id");
                            }
                            //
                            // verifico se è presente in cache
                            //
                            var cont = hashtableId[param1];
                            element.tooltip("option", "content", cont);
                        }
                    },
                    position: {
                        my: "left top+5",
                        at: "left bottom",
                        collision: "flipfit flip"
                    },
                    hide: {
                        delay: 300
                    },
                    content: function () {
                        var element = $(this);
                        if (element.is("[title]")) {
                            var text = element.attr("title");
                            if (text != "") {
                                return "<div class='JqueryUIToolTipDiv'>" + text + "</div>";
                            }
                            else { return "" };
                        }
                        if (element.is("a.WFIAjaxHtmlTooltip")) {
                            //return "loading content ...";
                            //
                            // Ajax tooltip
                            //
                            var param1 = element.find("#TooltipSelect")[0].value;
                            //
                            // verifico se è presente in cache
                            //
                            var cont = hashtable[param1];
                            if (cont == undefined) {
                                asyncState = false;
                                PageMethods.getWFIAjaxTooltipContent(param1,
                                    function (cnt) {
                                        var res = cnt;
                                        hashtable[param1] = res;
                                        cont = res;
                                    },
                                    function (cnt) {
                                    },
                                    function (cnt) {
                                    });
                                asyncState = true;
                            }
                            return cont;
                        }
                        if ((element.is("[wfititleid]")) || (element.is(".wfititleid"))) {
                            //return "loading content ...";
                            //
                            // Ajax tooltip
                            //
                            var param1 = element.attr("WFITitleId");
                            if (param1 == undefined) {
                                param1 = element.attr("id");
                            }
                            //
                            // verifico se è presente in cache
                            //
                            var cont = hashtableId[param1];
                            if (cont == undefined) {
                                asyncState = false;
                                PageMethods.getWFIAjaxTooltipContentById(param1,
                                    function (cnt) {
                                        var res = cnt;
                                        hashtableId[param1] = res;
                                        cont = res;
                                    },
                                    function (cnt) {
                                    },
                                    function (cnt) {
                                    });
                                asyncState = true;
                            }
                            return cont
                        }
                    },
                });
            }
            else {
                $("[title]").each(function () {
                    $(this).attr("title", $(this).attr("title").replace(/<br \/>/gi, " "));
                    $(this).attr("title", $(this).attr("title").replace(/<strong>/gi, ""));
                    $(this).attr("title", $(this).attr("title").replace(/<\/strong>/gi, ""));
                    $(this).attr("title", $(this).attr("title").replace(/<b>/gi, ""));
                    $(this).attr("title", $(this).attr("title").replace(/<\/b>/gi, ""));
                    $(this).attr("title", $(this).attr("title").replace(/<i>/gi, ""));
                    $(this).attr("title", $(this).attr("title").replace(/<\/i>/gi, ""));
                    $(this).attr("title", $(this).attr("title").replace(/<\/hr>/gi, ""));
                })
            }
        }, 200);
    }
    this.WFIAutoComplete = function () {
        $("input.WFIAutoComplete").autocomplete({
            source: function (request, response) {
                var param = { keyword: request.term, tag: this.element[0].getAttribute("autocomplete-tag") };
                var MyUrlArray = location.pathname.split("/");
                var MyUrl = MyUrlArray[MyUrlArray.length - 1];
                var MyFunc = "GetAutocompleteItems"
                if (this.element[0].getAttribute("autocomplete-serverfunc") != undefined) {
                    MyFunc = this.element[0].getAttribute("autocomplete-serverfunc");
                }
                $.ajax({
                    url: MyUrl + "/" + MyFunc,
                    data: JSON.stringify(param),
                    dataType: "json",
                    type: "POST",
                    contentType: "application/json; charset=iso-8859-1",
                    dataFilter: function (data) { return data; },
                    success: function (data) {
                        response($.map(data.d, function (item) {
                            return {
                                value: item
                            }
                        }))
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) { }
                });
            },
            select: function (event, ui) {
                if (ui.item) {
                    try {
                        //
                        // Punto per eventuale personalizzazione
                        //
                        this.WFIautocompleteselect(event, ui);
                    }
                    catch (e) {
                        try { this.value = ui.item.value; } catch (e) { }
                    };
                }
                return false;
            },
            focus: function (event, ui) {
                if (ui.item) {
                    try {
                        //
                        // Punto per eventuale personalizzazione
                        //
                        this.WFIautocompletefocus(event, ui);
                    }
                    catch (e) {
                        try { this.value = ui.item.label; } catch (e) { }
                    };
                }
                return false;
            },
            response: function (event, ui) {
                for (var i = 0; i < ui.content.length; i++) {
                    if (ui.content[i].value.indexOf(" @@@ ") > -1) {
                        var tmpArray = ui.content[i].value.split(" @@@ ");
                        ui.content[i].value = tmpArray[0];
                        ui.content[i].label = tmpArray[1] + ' (' + tmpArray[0] + ')';
                    }
                    else {
                        if (ui.content[i].value.indexOf(" %%% ") > -1) {
                            var tmpArray = ui.content[i].value.split(" %%% ");
                            ui.content[i].value = tmpArray[0];
                            ui.content[i].label = tmpArray[1];
                        }
                    }
                }
            },
            create: function (event, ui) {
                var minLength = this.getAttribute("autocomplete-minlength");
                if (minLength == undefined) {
                    $(this).autocomplete("option", "minLength", 2);
                }
                else {
                    $(this).autocomplete("option", "minLength", minLength);
                }
            },
        });
    }
    this.LastPostback = function () {
        var lp = $("input#HF_LastPostBack")[0].value;
        var dateTimeArray = lp.split(" ");
        var dateArray = dateTimeArray[0].split("-");
        var timeArray = dateTimeArray[1].split(":");
        var dateLastPostback = new Date(
                                        dateArray[2],
                                       (dateArray[1]) - 1, // Careful, month starts at 0!
                                       (dateArray[0]),
                                       (timeArray[0]),
                                       (timeArray[1]),
                                       (timeArray[2])
                                   );
        return dateLastPostback;
    }

    //
    // Gestione callback lato client
    //
    this.Callback_ReceiveServerData = function (ReturnValue) {
        try {
            if (ReturnValue != "") {
                var res = ReturnValue.split(";");
                if (res[0] == "TEST") { alert(res[1]); }
                else {
                    return _Callback_ReceiveServerData(ReturnValue);
                }
            }
        } catch (e) { }
    }
    this.Callback_SendToServer = function (arguments, context) {
        try { return _WFICallback_SendToServer(arguments, context); } catch (e) { }
    }
    //
    // gestisce i WFI postback di pagina
    //
    this.doWFIPostbackWithArguments = function (comando, argomenti) {
        try {
            if ($("#WFIPostbackAllowed")[0].value == "S") {
                $("#WFIPostbackCommand")[0].value = comando;
                $("#WFIPostbackArguments")[0].value = argomenti;
                $("#WFIPostbackRun")[0].click();
            }
        } catch (e) { }
    }
}
//
// Hook up Application event handlers.
//
var app = Sys.Application;
app.add_load(ApplicationLoad);
app.add_init(ApplicationInit);
app.add_disposing(ApplicationDisposing);
app.add_unload(ApplicationUnload);

// Application event handlers for component developers.
function ApplicationInit(sender) {
    var prm = Sys.WebForms.PageRequestManager.getInstance();
    if (!prm.get_isInAsyncPostBack()) {
        prm.add_initializeRequest(InitializeRequest);
        prm.add_beginRequest(BeginRequest);
        prm.add_pageLoading(PageLoading);
        prm.add_pageLoaded(PageLoaded);
        prm.add_endRequest(EndRequest);
    }
}
function ApplicationLoad(sender, args) {
    try { WFI.ApplicationLoad(sender, args); } catch (e) { };
}
function ApplicationUnload(sender) {
    try { WFI.ApplicationUnload(sender); } catch (e) { };
}
function ApplicationDisposing(sender) {
    try { WFI.ApplicationDisposing(sender); } catch (e) { };
}
//
// Evento di load della pagina
//
function pageLoad() {
    try { WFI.pageLoad(); } catch (e) { var a = 0; };
}
//
// Evento di unload della pagina
//
function pageUnload() {
    try { WFI.pageUnload(); } catch (e) { };
}
//
// PageRequestManager event handlers.
//
function InitializeRequest(sender, args) {
    try { WFI.pageInitializeRequest(sender, args); } catch (e) { };
}
function BeginRequest(sender, args) {
    try { WFI.pageBeginRequest(sender, args); } catch (e) { };
}
function PageLoading(sender, args) {
    try { WFI.PageLoading(); } catch (e) { };
}
function PageLoaded(sender, args) {
    try { WFI.PageLoaded(sender, args); } catch (e) { };
}
function EndRequest(sender, args) {
    try { WFI.EndRequest(sender, args); } catch (e) { };
}



//--------------------------------------------------------------------------------------------
//
// I N I Z I O   S C R I P T S   A G G I U N T I V I
//
//--------------------------------------------------------------------------------------------

//
//
// ScrollableGridPlugin.js
//
//
(function ($) {
    $.fn.Scrollable = function (options) {
        var defaults = {
            ScrollHeight: 300,
            Width: 0
        };
        var options = $.extend(defaults, options);
        return this.each(function () {

            var grid = $(this)[0];

            if ($(grid).attr("data-Elab") == "Yes") { } else {
                if ($(grid).is(":visible")) {
                    $(grid).attr("data-Elab", "Yes");
                    var parentDiv = grid.parentNode;
                    var parentDivId = parentDiv.parentNode.id;
                    $(parentDiv).css('visibility', 'hidden');
                    $(grid).css('visibility', 'visible');
                    var originalWidth = grid.style.width;
                    var gridWidth = grid.offsetWidth;
                    var BarWidth = getScrollBarWidth();

                    if (options.ScrollHeight == 0) {
                        options.ScrollHeight = parseInt(grid.style.height);
                        if (options.ScrollHeight == 9999) {
                            //
                            // altezza automatica
                            //
                            if ($(grid).is(".TipoGriglia_S")) {
                                //
                                // Griglia standard
                                //
                                if ($("div#ThinPanelTopHeader").length > 0) {
                                    //
                                    // intestazione dell'applicazione piccola
                                    //
                                    options.ScrollHeight = window.innerHeight - 250;
                                } else {
                                    //
                                    // intestazione dell'applicazione grande
                                    //
                                    options.ScrollHeight = window.innerHeight - 335;
                                }
                            } else if ($(grid).is(".TipoGriglia_I")) {
                                //
                                // Griglia interna
                                //
                                options.ScrollHeight = $(grid.parentElement.parentElement).innerHeight() - 40;
                                if (options.ScrollHeight > 9000) {
                                    options.ScrollHeight = $(grid.parentElement.parentElement.parentElement).innerHeight() - 40;
                                }
                            }
                        }
                    }
                    grid.style.removeProperty('height');
                    var headerCellWidths = new Array();

                    //var tmpVar = grid.getElementsByTagName("TH");
                    //for (var i = 0; i < tmpVar.length; i++) {
                    //    headerCellWidths[i] = window.getComputedStyle(tmpVar[i], null).getPropertyValue('width');
                    //}
                    //for (var i = 0; i < grid.getElementsByTagName("TH").length; i++) {
                    //    grid.getElementsByTagName("TH")[i].style.width = headerCellWidths[i];
                    //}

                    var tmpVar = $(grid).find("tr.HeaderRow th");
                    for (var i = 0; i < tmpVar.length; i++) {
                        headerCellWidths[i] = window.getComputedStyle(tmpVar[i], null).getPropertyValue('width');
                    }
                    for (var i = 0; i < tmpVar.length; i++) {
                        tmpVar[i].style.width = headerCellWidths[i];
                    }
                    grid.parentNode.appendChild(document.createElement("div"));

                    var table;
                    var table2;
                    var tBody;

                    if ($(grid.getElementsByTagName("TR")[0]).hasClass("PagerRow")) {

                        table = document.createElement("table");
                        for (i = 0; i < grid.attributes.length; i++) {
                            if (grid.attributes[i].specified && grid.attributes[i].name != "id") {
                                table.setAttribute(grid.attributes[i].name, grid.attributes[i].value);
                            }
                        }
                        table.className = table.className + " ScrollableGridHeader"
                        table.style.cssText = grid.style.cssText + "table-layout:fixed;";
                        table.style.width = gridWidth + "px";
                        tBody = document.createElement("tbody");

                        $(tBody).append($(grid).find("tr.PagerRow"));
                        table.appendChild(tBody);
                        options.ScrollHeight = options.ScrollHeight - 30

                        table2 = document.createElement("table");
                        for (i = 0; i < grid.attributes.length; i++) {
                            if (grid.attributes[i].specified && grid.attributes[i].name != "id") {
                                table2.setAttribute(grid.attributes[i].name, grid.attributes[i].value);
                            }
                        }
                        table2.className = table2.className + " ScrollableGridHeader"
                        table2.style.cssText = grid.style.cssText + "table-layout:fixed;";
                        table2.style.width = gridWidth + "px";
                        tBody = document.createElement("tbody");

                        $(tBody).append($(grid).find("tr.HeaderRow"));
                        table2.appendChild(tBody);

                    } else {
                        table = document.createElement("table");
                        for (i = 0; i < grid.attributes.length; i++) {
                            if (grid.attributes[i].specified && grid.attributes[i].name != "id") {
                                table.setAttribute(grid.attributes[i].name, grid.attributes[i].value);
                            }
                        }
                        table.className = table.className + " ScrollableGridHeader"
                        table.style.cssText = grid.style.cssText + "table-layout:fixed;";
                        table.style.width = gridWidth + "px";
                        tBody = document.createElement("tbody");
                        $(tBody).append($(grid).find("tr.HeaderRow"));
                        table.appendChild(tBody);
                    }


                    var gridRow = $(grid).find("tr.HeaderRow")[0];
                    var gridRow = grid.getElementsByTagName("TR")[0];
                    var cells = gridRow.getElementsByTagName("TD");

                    for (var i = 0; i < cells.length; i++) {
                        //
                        // la costante 2 arriva dalla differenza del padding tra le celle dell'intestazione e quelle del contenuto della tabella. Sull'intestazione abbiamo 2 e sui dati 3 
                        // quindi 3*2 - 2*2 =2 
                        //
                        cells[i].style.width = headerCellWidths[i].replace('px', '') - 2 + "px";
                    }

                    parentDiv.removeChild(grid);

                    if (options.Width > 0) {
                        gridWidth = options.Width;
                    }
                    //
                    // contenitore scrollabile per i dati
                    //
                    var scrollableDiv = document.createElement("div");
                    gridWidth = parseInt(gridWidth);
                    scrollableDiv.style.cssText = "overflow-y:auto;overflow-x:auto;height:" + options.ScrollHeight + "px;width:100%;";
                    scrollableDiv.id = parentDivId + "_ScrollDiv";
                    $(scrollableDiv).addClass("IboWebGridView").addClass("grdGriglia").addClass("stdGrdScrollableBody").addClass("WFIMantainScrollPosition");
                    grid.style.cssText = grid.style.cssText + "table-layout:fixed;" + "width:" + gridWidth + "px;";
                    scrollableDiv.appendChild(grid);
                    //
                    // contenitore per l'header
                    //
                    var dummyHeader = document.createElement("div");
                    dummyHeader.style.cssText = "overflow:hidden;";

                    setTimeout(function () {
                        if ($(scrollableDiv).hasScrollBar().vertical) {
                            dummyHeader.style.cssText = "overflow:hidden;width:calc(100% - " + BarWidth + "px);";
                        } else {
                            dummyHeader.style.cssText = "overflow:hidden;width:calc(100% - 0px);";                            
                        }
                    }, 100);

                    if ($(scrollableDiv).hasScrollBar().vertical) {
                        dummyHeader.style.cssText = "overflow:hidden;width:calc(100% - " + BarWidth + "px);";
                    } else {                        
                        dummyHeader.style.cssText = "overflow:hidden;width:calc(100% - 0px);";
                    }
                    $(dummyHeader).addClass("IboWebGridView").addClass("grdGriglia").addClass("stdGrdScrollableHeader");
                    dummyHeader.appendChild(table);
                    if (table2 != undefined) {
                        dummyHeader.appendChild(table2);
                    }
                    parentDiv.appendChild(dummyHeader);
                    parentDiv.appendChild(scrollableDiv);
                    //
                    // contenitore per il footer
                    //
                    var FooterDiv = document.createElement("div");
                    var FooterTable = document.createElement("table");
                    for (i = 0; i < grid.attributes.length; i++) {
                        if (grid.attributes[i].specified && grid.attributes[i].name != "id") {
                            FooterTable.setAttribute(grid.attributes[i].name, grid.attributes[i].value);
                        }
                    }

                    FooterTable.style.width = originalWidth;
                    FooterDiv.appendChild(FooterTable);
                    $(FooterDiv).addClass("IboWebGridView").addClass("grdGriglia").addClass("stdGrdScrollableFooter");
                    var t = $(grid).find("tr.PagerRow").detach();
                    t.appendTo(FooterTable);
                    parentDiv.appendChild(FooterDiv);

                    $(scrollableDiv).scroll(function () {
                        $(dummyHeader).scrollLeft($(scrollableDiv).scrollLeft());
                    });

                    $(parentDiv).css('visibility', 'visible');
                    $(parentDiv).css('overflow', 'hidden');
                    $(parentDiv).css('max-height', 'inherit');

                    options.ScrollHeight = 0;

                    function getScrollBarWidth() {
                        return WFI.getScrollBarWidth();
                    };
                } else {
                    $(grid).css('visibility', 'unset');
                    $(grid).css('height', 'unset');
                }
            }
        });
    };
})(jQuery);
//
//
// HtmlTooltip.js
//
//
function htmltooltipFunc() {
    kGetPosition = function (obj) {
        var pos = Array();
        pos['left'] = 0;
        pos['top'] = 0;
        if (obj) {
            while (obj.offsetParent) {
                pos['left'] += obj.offsetLeft - obj.scrollLeft;
                pos['top'] += obj.offsetTop - obj.scrollTop;
                var tmp = obj.parentNode;
                while (tmp != obj.offsetParent) {
                    pos['left'] -= tmp.scrollLeft;
                    pos['top'] -= tmp.scrollTop;
                    tmp = tmp.parentNode;
                }
                obj = obj.offsetParent;
            }
            pos['left'] += obj.offsetLeft;
            pos['top'] += obj.offsetTop;
        }
        return { x: pos['left'], y: pos['top'] };
    }

    var htmltooltip = {
        tipclass: 'htmltooltip',
        fadeeffect: [true, 300],
        anchors: [],
        tooltips: [], //array to contain references to all tooltip DIVs on the page
        positiontip: function ($, tipindex, e) {
            var anchor = this.anchors[tipindex];
            var tooltip = this.tooltips[tipindex];
            var scrollLeft = window.pageXOffset ? window.pageXOffset : this.iebody.scrollLeft;
            var scrollTop = window.pageYOffset ? window.pageYOffset : this.iebody.scrollTop;
            var docwidth = (window.innerWidth) ? window.innerWidth - 15 : htmltooltip.iebody.clientWidth - 15;
            var docheight = (window.innerHeight) ? window.innerHeight - 18 : htmltooltip.iebody.clientHeight - 15;
            var tipx = anchor.dimensions.offsetx;
            var tipy = anchor.dimensions.offsety + anchor.dimensions.h;
            var k = 15;
            tipy = kGetPosition(anchor).y + anchor.dimensions.h + k;
            tipy = (tipy > docheight) ? tipy - tooltip.dimensions.h - anchor.dimensions.h - k - k : tipy;
            tipx = kGetPosition(anchor).x;
            tipx = (tipx + tooltip.dimensions.w > docwidth) ? tipx - ((tipx + tooltip.dimensions.w) - docwidth + k + k) : tipx; //account for right edge            
            $(tooltip).css({ left: tipx, top: tipy });
        },
        showtip: function ($, tipindex, e) {
            var tooltip = this.tooltips[tipindex];
            if (this.fadeeffect[0])
                $(tooltip).hide().fadeIn(this.fadeeffect[1]);
            else
                $(tooltip).show();
        },
        hidetip: function ($, tipindex, e) {
            var tooltip = this.tooltips[tipindex];
            if (this.fadeeffect[0])
                $(tooltip).fadeOut(this.fadeeffect[1]);
            else
                $(tooltip).hide();
        },
        updateanchordimensions: function ($) {
            var $anchors = $('a.' + htmltooltip.tipclass);
            $anchors.each(function (index) {
                this.dimensions = { w: this.offsetWidth, h: this.offsetHeight, offsetx: $(this).offset().left, offsety: $(this).offset().top };
            })
        },
        render: function () {
            //jQuery(document).ready(function ($) {
            htmltooltip.iebody = (document.compatMode && document.compatMode != "BackCompat") ? document.documentElement : document.body;
            //$('body>div.' + htmltooltip.tipclass).remove();
            var $anchors = $('a.' + htmltooltip.tipclass);
            var $tooltips = $('div.' + htmltooltip.tipclass);
            $anchors.each(function (index) {
                //find all links with "title=htmltooltip" declaration
                //store anchor dimensions
                this.dimensions = { w: this.offsetWidth, h: this.offsetHeight, offsetx: $(this).offset().left, offsety: $(this).offset().top };
                //store index of corresponding tooltip
                this.tippos = index + ' pos';
                //ref corresponding tooltip
                var tooltip = $tooltips.eq(index).get(0);
                //if no corresponding tooltip found
                if (tooltip == null) return;
                tooltip.dimensions = { w: tooltip.offsetWidth, h: tooltip.offsetHeight };
                //add tooltip to end of BODY for easier positioning
                //$(tooltip).remove().appendTo('body');
                //store reference to each tooltip
                htmltooltip.tooltips.push(tooltip);
                //store reference to each anchor
                htmltooltip.anchors.push(this);
                var $anchor = $(this);
                var to = 0;
                $anchor.hover(
                    function (e) {
                        //onMouseover element
                        var that = this;
                        var ex = e;
                        to = setTimeout(function () {
                            htmltooltip.positiontip($, parseInt(that.tippos), ex);
                            htmltooltip.showtip($, parseInt(that.tippos), ex);
                            to = 0;
                        }, 500);
                    },
                    function (e) { //onMouseout element
                        if (to != 0) {
                            clearTimeout(to);
                            to = 0;
                        }
                        htmltooltip.hidetip($, parseInt(this.tippos), e);
                    })
                $(window).bind("resize", function () { htmltooltip.updateanchordimensions($) });
            })
            //})
        }
    }
    htmltooltip.render();
}

/*
 * jQuery Dropdown: A simple dropdown plugin
 *
 * Contribute: https://github.com/claviska/jquery-dropdown
 *
 * @license: MIT license: http://opensource.org/licenses/MIT
 *
 */
if (jQuery) (function ($) {

    $.extend($.fn, {
        jqDropdown: function (method, data) {

            switch (method) {
                case 'show':
                    show(null, $(this));
                    return $(this);
                case 'hide':
                    hide();
                    return $(this);
                case 'attach':
                    return $(this).attr('data-jq-dropdown', data);
                case 'detach':
                    hide();
                    return $(this).removeAttr('data-jq-dropdown');
                case 'disable':
                    return $(this).addClass('jq-dropdown-disabled');
                case 'enable':
                    hide();
                    return $(this).removeClass('jq-dropdown-disabled');
                case 'init':
                    init();
                    return $(this);
            }
        }
    });

    function show(event, object) {

        var trigger = event ? $(this) : object,
            jqDropdown = $(trigger.attr('data-jq-dropdown')),
            isOpen = trigger.hasClass('jq-dropdown-open');

        // In some cases we don't want to show it
        if (event) {
            if ($(event.target).hasClass('jq-dropdown-ignore')) return;

            event.preventDefault();
            event.stopPropagation();
        } else {
            if (trigger !== object.target && $(object.target).hasClass('jq-dropdown-ignore')) return;
        }
        hide();

        if (isOpen || trigger.hasClass('jq-dropdown-disabled')) return;

        // Show it
        trigger.addClass('jq-dropdown-open');
        jqDropdown
            .data('jq-dropdown-trigger', trigger)
            .show();

        // Position it
        position();

        // Trigger the show callback
        jqDropdown
            .trigger('show', {
                jqDropdown: jqDropdown,
                trigger: trigger
            });

    }

    function hide(event) {

        // In some cases we don't hide them
        var targetGroup = event ? $(event.target).parents().addBack() : null;

        // Are we clicking anywhere in a jq-dropdown?
        if (targetGroup && targetGroup.is('.jq-dropdown')) {
            // Is it a jq-dropdown menu?
            if (targetGroup.is('.jq-dropdown-menu')) {
                // Did we click on an option? If so close it.
                if (!targetGroup.is('A')) return;
            } else {
                // Nope, it's a panel. Leave it open.
                return;
            }
        }

        // Hide any jq-dropdown that may be showing
        $(document).find('.jq-dropdown:visible').each(function () {
            var jqDropdown = $(this);
            jqDropdown
                .hide()
                .removeData('jq-dropdown-trigger')
                .trigger('hide', { jqDropdown: jqDropdown });
        });

        // Remove all jq-dropdown-open classes
        $(document).find('.jq-dropdown-open').removeClass('jq-dropdown-open');

    }

    function position() {

        var jqDropdown = $('.jq-dropdown:visible').eq(0),
            trigger = jqDropdown.data('jq-dropdown-trigger'),
            hOffset = trigger ? parseInt(trigger.attr('data-horizontal-offset') || 0, 10) : null,
            vOffset = trigger ? parseInt(trigger.attr('data-vertical-offset') || 0, 10) : null;

        if (jqDropdown.length === 0 || !trigger) return;

        // Position the jq-dropdown relative-to-parent...
        if (jqDropdown.hasClass('jq-dropdown-relative')) {
            jqDropdown.css({
                left: jqDropdown.hasClass('jq-dropdown-anchor-right') ?
                    trigger.position().left - (jqDropdown.outerWidth(true) - trigger.outerWidth(true)) - parseInt(trigger.css('margin-right'), 10) + hOffset :
                    trigger.position().left + parseInt(trigger.css('margin-left'), 10) + hOffset,
                top: trigger.position().top + trigger.outerHeight(true) - parseInt(trigger.css('margin-top'), 10) + vOffset
            });
        } else {
            // ...or relative to document
            jqDropdown.css({
                left: jqDropdown.hasClass('jq-dropdown-anchor-right') ?
                    trigger.offset().left - (jqDropdown.outerWidth() - trigger.outerWidth()) + hOffset : trigger.offset().left + hOffset,
                top: trigger.offset().top + trigger.outerHeight() + vOffset
            });
        }
    }

    function init() {
        $(document).off('click.jq-dropdown', '[data-jq-dropdown]', show);
        $(document).off('click.jq-dropdown', hide);
        $(window).off('resize', position);
        $(document).on('click.jq-dropdown', '[data-jq-dropdown]', show);
        $(document).on('click.jq-dropdown', hide);
        $(window).on('resize', position);
    }

})(jQuery);


/*
 * Copyright (C) 2012 PrimeBox (info@primebox.co.uk)
 * 
 * This work is licensed under the Creative Commons
 * Attribution 3.0 Unported License. To view a copy
 * of this license, visit
 * http://creativecommons.org/licenses/by/3.0/.
 * 
 * Documentation available at:
 * http://www.primebox.co.uk/projects/cookie-bar/
 * 
 * When using this software you use it at your own risk. We hold
 * no responsibility for any damage caused by using this plugin
 * or the documentation provided.
 */
(function ($) {
    $.cookieBar = function (options, val) {
        if (options == 'cookies') {
            var doReturn = 'cookies';
        } else if (options == 'set') {
            var doReturn = 'set';
        } else {
            var doReturn = false;
        }
        var defaults = {
            message: 'We use cookies to track usage and preferences.', //Message displayed on bar
            acceptButton: true, //Set to true to show accept/enable button
            acceptText: 'I Understand', //Text on accept/enable button
            acceptFunction: function (cookieValue) { if (cookieValue != 'enabled' && cookieValue != 'accepted') window.location = window.location.href; }, //Function to run after accept
            declineButton: false, //Set to true to show decline/disable button
            declineText: 'Disable Cookies', //Text on decline/disable button
            declineFunction: function (cookieValue) { if (cookieValue == 'enabled' || cookieValue == 'accepted') window.location = window.location.href; }, //Function to run after decline
            policyButton: false, //Set to true to show Privacy Policy button
            policyText: 'Privacy Policy', //Text on Privacy Policy button
            policyURL: '/privacy-policy/', //URL of Privacy Policy
            autoEnable: true, //Set to true for cookies to be accepted automatically. Banner still shows
            acceptOnContinue: false, //Set to true to accept cookies when visitor moves to another page
            acceptOnScroll: false, //Set to true to accept cookies when visitor scrolls X pixels up or down
            acceptAnyClick: false, //Set to true to accept cookies when visitor clicks anywhere on the page
            expireDays: 365, //Number of days for cookieBar cookie to be stored for
            renewOnVisit: false, //Renew the cookie upon revisit to website
            forceShow: false, //Force cookieBar to show regardless of user cookie preference
            effect: 'slide', //Options: slide, fade, hide
            element: 'body', //Element to append/prepend cookieBar to. Remember "." for class or "#" for id.
            append: false, //Set to true for cookieBar HTML to be placed at base of website. Actual position may change according to CSS
            fixed: false, //Set to true to add the class "fixed" to the cookie bar. Default CSS should fix the position
            bottom: false, //Force CSS when fixed, so bar appears at bottom of website
            zindex: '', //Can be set in CSS, although some may prefer to set here
            domain: String(window.location.hostname), //Location of privacy policy
            referrer: String(document.referrer) //Where visitor has come from
        };
        var options = $.extend(defaults, options);

        //Sets expiration date for cookie
        var expireDate = new Date();
        expireDate.setTime(expireDate.getTime() + (options.expireDays * 86400000));
        expireDate = expireDate.toGMTString();

        var cookieEntry = 'cb-enabled={value}; expires=' + expireDate + '; path=/';

        //Retrieves current cookie preference
        var i, cookieValue = '', aCookie, aCookies = document.cookie.split('; ');
        for (i = 0; i < aCookies.length; i++) {
            aCookie = aCookies[i].split('=');
            if (aCookie[0] == 'cb-enabled') {
                cookieValue = aCookie[1];
            }
        }
        //Sets up default cookie preference if not already set
        if (cookieValue == '' && doReturn != 'cookies' && options.autoEnable) {
            cookieValue = 'enabled';
            document.cookie = cookieEntry.replace('{value}', 'enabled');
        } else if ((cookieValue == 'accepted' || cookieValue == 'declined') && doReturn != 'cookies' && options.renewOnVisit) {
            document.cookie = cookieEntry.replace('{value}', cookieValue);
        }
        if (options.acceptOnContinue) {
            if (options.referrer.indexOf(options.domain) >= 0 && String(window.location.href).indexOf(options.policyURL) == -1 && doReturn != 'cookies' && doReturn != 'set' && cookieValue != 'accepted' && cookieValue != 'declined') {
                doReturn = 'set';
                val = 'accepted';
            }
        }
        if (doReturn == 'cookies') {
            //Returns true if cookies are enabled, false otherwise
            if (cookieValue == 'enabled' || cookieValue == 'accepted') {
                return true;
            } else {
                return false;
            }
        } else if (doReturn == 'set' && (val == 'accepted' || val == 'declined')) {
            //Sets value of cookie to 'accepted' or 'declined'
            document.cookie = cookieEntry.replace('{value}', val);
            if (val == 'accepted') {
                return true;
            } else {
                return false;
            }
        } else {
            //Sets up enable/accept button if required
            var message = options.message.replace('{policy_url}', options.policyURL);

            if (options.acceptButton) {
                var acceptButton = '<a href="" class="cb-enable">' + options.acceptText + '</a>';
            } else {
                var acceptButton = '';
            }
            //Sets up disable/decline button if required
            if (options.declineButton) {
                var declineButton = '<a href="" class="cb-disable">' + options.declineText + '</a>';
            } else {
                var declineButton = '';
            }
            //Sets up privacy policy button if required
            if (options.policyButton) {
                var policyButton = '<a href="' + options.policyURL + '" class="cb-policy">' + options.policyText + '</a>';
            } else {
                var policyButton = '';
            }
            //Whether to add "fixed" class to cookie bar
            if (options.fixed) {
                if (options.bottom) {
                    var fixed = ' class="fixed bottom"';
                } else {
                    var fixed = ' class="fixed"';
                }
            } else {
                var fixed = '';
            }
            if (options.zindex != '') {
                var zindex = ' style="z-index:' + options.zindex + ';"';
            } else {
                var zindex = '';
            }

            //Displays the cookie bar if arguments met
            if (options.forceShow || cookieValue == 'enabled' || cookieValue == '') {
                if (options.append) {
                    $(options.element).append('<div id="cookie-bar"' + fixed + zindex + '><p>' + message + acceptButton + declineButton + policyButton + '</p></div>');
                } else {
                    $(options.element).prepend('<div id="cookie-bar"' + fixed + zindex + '><p>' + message + acceptButton + declineButton + policyButton + '</p></div>');
                }
            }

            var removeBar = function (func) {
                if (options.acceptOnScroll) $(document).off('scroll');
                if (typeof (func) === 'function') func(cookieValue);
                if (options.effect == 'slide') {
                    $('#cookie-bar').slideUp(300, function () { $('#cookie-bar').remove(); });
                } else if (options.effect == 'fade') {
                    $('#cookie-bar').fadeOut(300, function () { $('#cookie-bar').remove(); });
                } else {
                    $('#cookie-bar').hide(0, function () { $('#cookie-bar').remove(); });
                }
                $(document).unbind('click', anyClick);
            };
            var cookieAccept = function () {
                document.cookie = cookieEntry.replace('{value}', 'accepted');
                removeBar(options.acceptFunction);
            };
            var cookieDecline = function () {
                var deleteDate = new Date();
                deleteDate.setTime(deleteDate.getTime() - (864000000));
                deleteDate = deleteDate.toGMTString();
                aCookies = document.cookie.split('; ');
                for (i = 0; i < aCookies.length; i++) {
                    aCookie = aCookies[i].split('=');
                    if (aCookie[0].indexOf('_') >= 0) {
                        document.cookie = aCookie[0] + '=0; expires=' + deleteDate + '; domain=' + options.domain.replace('www', '') + '; path=/';
                    } else {
                        document.cookie = aCookie[0] + '=0; expires=' + deleteDate + '; path=/';
                    }
                }
                document.cookie = cookieEntry.replace('{value}', 'declined');
                removeBar(options.declineFunction);
            };
            var anyClick = function (e) {
                if (!$(e.target).hasClass('cb-policy')) cookieAccept();
            };

            $('#cookie-bar .cb-enable').click(function () { cookieAccept(); return false; });
            $('#cookie-bar .cb-disable').click(function () { cookieDecline(); return false; });
            if (options.acceptOnScroll) {
                var scrollStart = $(document).scrollTop(), scrollNew, scrollDiff;
                $(document).on('scroll', function () {
                    scrollNew = $(document).scrollTop();
                    if (scrollNew > scrollStart) {
                        scrollDiff = scrollNew - scrollStart;
                    } else {
                        scrollDiff = scrollStart - scrollNew;
                    }
                    if (scrollDiff >= Math.round(options.acceptOnScroll)) cookieAccept();
                });
            }
            if (options.acceptAnyClick) {
                $(document).bind('click', anyClick);
            }
        }
    };
})(jQuery);

//
// A little plugin to determine if the scrollbar is present or not
//
(function ($) {
    $.fn.hasScrollBar = function () {
        var e = this.get(0);
        return {
            vertical: e.scrollHeight > e.clientHeight,
            horizontal: e.scrollWidth > e.clientWidth
        };
    }
})(jQuery);

//
// MantainScrollPosition
//
(function ($) {

    //
    //
    // Store scroll position for and set it after reload     
    //
    //
    var myLocalStorage = {};

    $.fn.scrollPosSave = function () {
        $(this).each(function () {
            try {
                var myDiv = $(this)[0];
                myLocalStorage["Stor_" + myDiv.id] = myDiv.scrollTop;
            } catch (e) { }
        });
        return $(this);
    }

    $.fn.scrollPosLoad = function () {
        $(this).each(function () {
            try {
                var myDiv = $(this)[0];
                if (myLocalStorage["Stor_" + myDiv.id] != undefined) {
                    if (myLocalStorage["Stor_" + myDiv.id] != 0) {
                        myDiv.scrollTop = myLocalStorage["Stor_" + myDiv.id]
                    }
                }
            } catch (e) { }
        });
        return $(this);
    }
}(jQuery));

//
// Altre funzioni aggiunte a Jquery
//
(function ($) {
    //
    // Serve per forzare il ridisegno di un oggetto e i suoi discendenti
    //
    $.fn.redraw = function () {
        $(this).each(function () {
            var redraw = this.offsetHeight;
        });
    };

}(jQuery));

