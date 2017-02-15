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
