var pos = angular.module('pos');

pos.controller('productcategoriesCtrl', function ($scope, $http) {
    var url = "http://localhost:3677/api/productcategories";
    $scope.selectedEntity = {};
    //$scope.params = $routeParams;

    $scope.selectEntity = function (entity) {
        $scope.selectedEntity = entity;
        url = "http://localhost:3677/api/productcategories/" + entity.code;
        alert(url);
    }

    $scope.refresh = function () {
        var prom = $http.get(url);
        prom.success(function (data) {
            $scope.entities = data;

        });
    }

    $scope.refresh();
    //alert(JSON.stringify($scope.params));
});