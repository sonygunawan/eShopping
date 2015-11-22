var pos = angular.module('pos');

pos.controller('homeproductCtrl', function ($scope, $routeParams, $location, $http) {
    var url = "http://localhost:3677/api/product";
    $scope.selectedEntity = {};
    //$scope.idParam = $routeParams.categoriesId;
    $scope.idParam = "TestidParam";
    $scope.categoriesIdParam = $routeParams.categoriesId;
    
    //$location.path('/tasks/' + idParam + '/edit/');
    $scope.selectEntity = function (entity) {
        $scope.selectedEntity = entity;
    }

    $scope.refresh = function () {

    //alert($http.current.params);
        var prom = $http.get(url);
        prom.success(function (data) {
            $scope.entities = data;
        });

    }
    alert('text');
    $scope.refresh();
    
});