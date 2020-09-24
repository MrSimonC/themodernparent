window.simonFunctions = {
    setBodyClass: function (className) {
        window.document.body.classList.add(className)
    },

    pageLoadAnimation: function () {
        $body = $('body');
        window.setTimeout(function () {
            $body.removeClass('is-preload');
        }, 100);
    },

    loadScript: function (scriptPath) {
        // scriptPath relative to wwwroot e.g. "assets/js/main.js"
        var script = document.createElement("script");
        script.src = scriptPath;
        script.type = "text/javascript";

        document["body"].appendChild(script);
    }
};