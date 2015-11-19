var pos = angular.module('pos');

pos.controller('productCtrl', function ($scope, $http) {
    var url = "http://localhost:3677/api/product";
    $scope.selectedEntity = {};

    $scope.selectEntity = function (entity) {
        $scope.selectedEntity = entity;
        //alert(JSON.stringify(entity));
    }

    $scope.create = function () {
        $http.get(url + "/0").success(function (data) {
            $scope.selectedEntity = data;
        });
    }

    $scope.save = function () {
            $http.post(url, $scope.selectedEntity).success(function ()
            {
                alert("Save succeeded.");
                $scope.refresh();
            });
    }

    $scope.refresh = function () {
        var prom = $http.get(url);
        prom.success(function (data) {
            $scope.entities = data;
        });
    }

    $scope.refresh();
});