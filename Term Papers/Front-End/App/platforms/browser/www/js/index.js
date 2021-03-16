/*
var app = {
    // Application Constructor
    initialize: function() {
        this.bindEvents();
    },
    // Bind Event Listeners
    //
    // Bind any events that are required on startup. Common events are:
    // 'load', 'deviceready', 'offline', and 'online'.
    bindEvents: function() {
        document.addEventListener('deviceready', this.onDeviceReady, false);
    },
    // deviceready Event Handler
    //
    // The scope of 'this' is the event. In order to call the 'receivedEvent'
    // function, we must explicitly call 'app.receivedEvent(...);'
    onDeviceReady: function() {
        app.receivedEvent('deviceready');
    },
    // Update DOM on a Received Event
    receivedEvent: function(id) {
        var parentElement = document.getElementById(id);
        var listeningElement = parentElement.querySelector('.listening');
        var receivedElement = parentElement.querySelector('.received');

        listeningElement.setAttribute('style', 'display:none;');
        receivedElement.setAttribute('style', 'display:block;');

        console.log('Received Event: ' + id);
    }


};
  */
angular.module('visitaRio', []);
angular.module("visitaRio").controller('appController' , function($scope)
{
    
    //banheiro
    $scope.IsBanheiro = false;
    $scope.ShowBanheiro = function () {
        $scope.IsBanheiro = $scope.IsBanheiro ? false : true;
    }

    //delegacia
    $scope.IsDele = false;
    $scope.ShowDele = function () {
        $scope.IsDele = $scope.IsDele ? false : true;
    }  

    //evento
    $scope.IsEvento = false;
    $scope.ShowEvento = function () {
        $scope.IsEvento = $scope.IsEvento ? false : true;
    }      

    //hospital
    $scope.IsHosp = false;
    $scope.ShowHosp = function () {
        $scope.IsHosp = $scope.IsHosp ? false : true;
    } 

    //comida
    $scope.IsComida = false;
    $scope.ShowComida = function () {
        $scope.IsComida = $scope.IsComida ? false : true;
    } 

    //dormir
    $scope.IsDormir = false;
    $scope.ShowDormir = function () {
        $scope.IsDormir = $scope.IsDormir ? false : true;
    }  

    //pontos turisticos
    $scope.IsPontos = false;
    $scope.ShowPontos = function () {
        $scope.IsPontos = $scope.IsPontos ? false : true;
    }  

    //praia
    $scope.IsPraia = false;
    $scope.ShowPraia = function () {
        $scope.IsPraia = $scope.IsPraia ? false : true;
    }

    //resultado
    $scope.IsResult = false;
    $scope.ShowResult = function () {
        $scope.IsResult = $scope.IsResult ? false : true;
    }          
});
