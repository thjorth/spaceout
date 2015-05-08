$(document).ready(function () {
    console.log("yes");

    $("#menu a").click(function () {
        var href = $(this).attr('href');
        $.ajax({
            url: href,
            type: 'GET',
            dataType: 'html'
        })
        .done(function() {
            console.log("success");
        })
        .fail(function() {
            console.log("error");
        })
        .always(function() {
            console.log("complete");
        });
    });
});
