$(document).ready(function () {
    console.log("yes");
    $("#loading").hide();
    window.onpopstate = function (event) {
        $("#loading").show();
        console.log("pathname: " + location.pathname);
        loadContent(location.pathname);
    };

    function loadContent(href) {
        $.ajax({
            url: href
        })
        .done(function(data, status, xhr) {
            $(".main-content").html(data);
            console.log("success");
            console.log(xhr.getAllResponseHeaders());
        })
        .fail(function() {
            console.log("error");
        })
        .always(function() {
            console.log("complete");
            $("#loading").hide();
        });
        
    }

    $("#menu a").click(function (event) {
        event.preventDefault();
        $("#loading").show();
        var href = $(this).attr('href');

        loadContent(href);
        history.pushState({}, $("head>title").text(), href);
    });
});
