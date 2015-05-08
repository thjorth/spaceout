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
            history.pushState({}, $("head>title").text(), href);
        });
    }

    $("#menu a").click(function (event) {
        event.preventDefault();
        var href = $(this).attr('href');
        //$.ajax({
        //    url: href,
        //    type: 'GET',
        //    dataType: 'html'
        //})
        //.done(function (data, status, xhr) {
        //    console.log("status: %s", status);
        //    var $html = $("<div />").append($.parseHTML(data));
        //    $("head>title").remove();
        //    $html.find("title").prependTo("head");
        //    history.pushState({}, $("head>title").text(), href);
        //    console.log(data);
        //})
        //.fail(function() {
        //    console.log("error");
        //})
        //.always(function() {
        //    console.log("complete");
        //});
        loadContent(href);
    });
});
