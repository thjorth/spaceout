$(document).ready(function () {
    console.log("yes");

    $("#menu a").click(function (event) {
        event.preventDefault();
        var href = $(this).attr('href');
        $.ajax({
            url: href,
            type: 'GET',
            dataType: 'html'
        })
        .done(function (html) {
            console.log("success", html);
        })
        .fail(function() {
            console.log("error");
        })
        .always(function() {
            console.log("complete");
        });
    });
});
