$(function () {
    var expanded = $('li > a');

    $.each(expanded, function (index, value) {
        var parent = $(this).parent();
        var p_expanded = parent.children("ul");

        if (p_expanded.length > 0) {
            $(this).on("click", Collapse);
        }
    });

    $("[data-toggle]").click(function () {
        var toggle_el = $(this).data("toggle");
        $(toggle_el).toggleClass("open-main");
        $("#left-panel").toggleClass("open-panel");

        if ($(this).hasClass("glyphicon-th-large")) {
            $(this).removeClass('glyphicon-th-large')
                   .addClass('glyphicon-th-list');
        } else {
            $(this).removeClass('glyphicon-th-list')
                   .addClass('glyphicon-th-large');
        }
    });

    $("#main").on("swipeleft", Left);
    $("#main").on("swiperight", Right);

    //ResponsiveHiddenMenu();
});

function Left() {
    $("#main").addClass("open-main");
    $("#left-panel").addClass("open-panel");
    $("[data-toggle]").removeClass('glyphicon-th-large')
           .addClass('glyphicon-th-list');
}

function Right() {
    $("#main").removeClass("open-main");
    $("#left-panel").removeClass("open-panel");
    $("[data-toggle]").removeClass('glyphicon-th-list')
           .addClass('glyphicon-th-large');
}

function Collapse() {
    var parent = $(this).parent();
    var p_expanded = parent.children("ul");

    display = p_expanded.css('display');
    if (display == 'none') {
        p_expanded.css('display', 'block');
    } else {
        p_expanded.css('display', 'none');
    }
}

//function ResponsiveHiddenMenu() {
//    $html = $('html');
//    if ($html.width() < 768) {
//        Left();
//    }
//}