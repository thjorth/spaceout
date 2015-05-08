$(document).ready(function () {
    console.log("yes");
    window.onpopstate = function (event) {
        $("#loading").show();
        console.log("pathname: " + location.pathname);
        loadContent(location.pathname);
    };

    function loadContent(href) {
        var r = new XMLHttpRequest();
        r.open("GET", href, true);
        r.setRequestHeader("X-Requested-With", "XMLHttpRequest");
        r.onreadystatechange = function () {
            if (r.readyState != 4 || r.status != 200) return;
            var response = JSON.parse(r.response);
            $(".main-content").html(response.Body);
            console.log("success");
            console.log(r.getAllResponseHeaders());
            $("title").text(response.Title);
        };
        r.send();
    }

    $("#menu a").click(function (event) {
        event.preventDefault();
        var href = $(this).attr('href');

        loadContent(href);
        history.pushState({}, $("head>title").text(), href);
    });
});
