/// <reference path="jquery-1.10.2.js" />

$("[class^=title]").hide();
$("[class^=text]").hide();

    $(document).ready(function () {
        $("#onas").click(function () {
            $("[class^=t]").hide();
            $(".title1").slideDown(500);
            $(".text1").slideDown(500);
        });
        $("#okarate").click(function () {
            $("[class^=t]").hide();
            $(".title2").show(500);
            $(".text2").show(500);
        });
        $("#otechnice").click(function () {
            $("[class^=t]").hide();
            $(".title3").show(500);
            $(".text3").show(500);
        });
        $("#oposilovne").click(function () {
            $("[class^=t]").hide();
            $(".title4").show(500);
            $(".text4").show(500);
        });
    });

//CAROUSEL--------------------------------------------------------------
    jQuery(document).ready(function ($) {

        $('#myCarousel').carousel({
            interval: 5000
        });

        //Handles the carousel thumbnails
        $('[id^=carousel-selector-]').click(function () {
            var id_selector = $(this).attr("id");
            try {
                var id = /-(\d+)$/.exec(id_selector)[1];
                console.log(id_selector, id);
                jQuery('#myCarousel').carousel(parseInt(id));
            } catch (e) {
                console.log('Regex failed!', e);
            }
        });
        // When the carousel slides, auto update the text
        $('#myCarousel').on('slid.bs.carousel', function (e) {
            var id = $('.item.active').data('slide-number');
            $('#carousel-text').html($('#slide-content-' + id).html());
        });
    });