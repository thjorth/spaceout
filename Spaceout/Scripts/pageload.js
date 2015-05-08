$(document).ready(function () {
    console.log("yes");
    window.onpopstate = function (event) {
        $("#loading").show();
        console.log("pathname: " + location.pathname);
        loadContent(location.pathname);
    };

    function loadContent(href) {
        $("#body").load(href + " #body", function (data) {
            var $html = $("<div />").append($.parseHTML(data));
            $("head>title").remove();
            $html.find("title").prependTo("head");   
        });
    }

    $("#menu a").click(function (event) {
        event.preventDefault();
        var href = $(this).attr('href');

        loadContent(href);
        history.pushState({}, $("head>title").text(), href);
    });
});
