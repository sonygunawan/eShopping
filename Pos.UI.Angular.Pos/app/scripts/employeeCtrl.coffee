angular.module('pos').controller 'employeeCtrl', ($scope)  ->
    url = "http://localhost:3677/api/product"
    $scope.selectedEntity = {}

    $scope.selectEntity = (entity) -> $scope.selectedEntity = entity

    $scope.create = ->
        $http.get(url + "/0").success(data) ->
            $scope.selectedEntity = data
        
    $scope.save = () ->
            $http.post(url, $scope.selectedEntity).success ->
                alert("Save succeeded.")
                $scope.refresh()
            
    $scope.refresh = ->
        prom = $http.get(url)
        prom.success (data) ->
            $scope.entities = data
        
    $scope.refresh()