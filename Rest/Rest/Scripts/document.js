/// <reference path="angular.js" />
var app = angular.module('myApp', []);

app.controller('myController', function ($scope) {
    $scope.name = "Ester Palacká";
    $scope.address = "Náměstí 18";
    $scope.city = "Štramberk";
    $scope.postCode = "742 66";
    $scope.company = "Vázaná živnost pohostinství";
    $scope.phone = "+420 732 566 348";
    $scope.email = "estafilipova@seznam.cz";
    $scope.ico = "73753971";
    
    $scope.headTitle = "Restaurace Štramberk";
    $scope.title = " na staré škole";
    $scope.text = "Naše útulná restaurace se nachází v krásném historickém centru města, kde podáváme tradiční českou kuchyni. Spolu s příjemnou obsluhou a rodinnou atmosférou si odnesete od nás jedinečný zážitek. Součástí restaurace je venkovní posezení, u kterého nechybí dětské hřiště. V areálu se též nachází sál s kapacitou 50 osob, ve kterém vám rádi připravíme nezapomenutelný zážitek.";

});
