/// <reference path="jquery-1.9.1.js" />
$("#gallery").hide();

var i;

function photo_in(int) {
    $("#preview-gallery").slideUp(1000);
    $("#gallery").show(500);
    $("#photoBody").append("<img id=\"" + i + "\" class=\"img-responsive slide\" src=\"../Images/Galery/IMG_" + i + ".jpg\" />");
}

function photo_slider_left(int) {
    $("#" + i).remove();
    ++i;
    if (i === 37) {
        i = 1;
    }
    $("#photoBody").append("<img id=\"" + i + "\" class=\"img-responsive slide\" src=\"../Images/Galery/IMG_" + i + ".jpg\" />");
}

function photo_slider_right(int) {
    $("#" + i).remove();
    --i;
    if (i === 0) {
        i = 36;
    }
    $("#photoBody").append("<img id=\"" + i + "\" class=\"img-responsive slide\" src=\"../Images/Galery/IMG_" + i + ".jpg\" />").slideDown(500);
}

$(document).ready(function () {
    $("#preview").click(function () {
        photo_slider_right(i);
    });

    $("#next").click(function () {
        photo_slider_left(i);
    });
});


$(document).ready(function () {
    $("[id^=start]").click(function () {
        if ($(this).is("#start1")) {
            i = 1;
        }
        else if ($(this).is("#start2")) {
            i = 7;
        }
        else if ($(this).is("#start3")) {
            i = 13;
        }
        else if ($(this).is("#start4")) {
            i = 19;
        }
        else if ($(this).is("#start5")) {
            i = 25;
        }
        else if ($(this).is("#start6")) {
            i = 31;
        }
        photo_in(i);

    });

});

var galleryClose = function () {
    $("#preview-gallery").slideDown(1000);
    $("#gallery").hide();
    $("#photoBody img").remove();
};

var preview = function () {
    $("#close").click(galleryClose);
};



$(document).ready(preview);