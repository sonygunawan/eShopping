(function() {
  angular.module('pos').controller('employeeCtrl', function($scope) {
    var url;
    url = "http://localhost:3677/api/product";
    $scope.selectedEntity = {};
    $scope.selectEntity = function(entity) {
      return $scope.selectedEntity = entity;
    };
    $scope.create = function() {
      return $http.get(url + "/0").success(data)(function() {
        return $scope.selectedEntity = data;
      });
    };
    $scope.save = function() {
      return $http.post(url, $scope.selectedEntity).success(function() {
        alert("Save succeeded.");
        return $scope.refresh();
      });
    };
    $scope.refresh = function() {
      var prom;
      prom = $http.get(url);
      return prom.success(function(data) {
        return $scope.entities = data;
      });
    };
    return $scope.refresh();
  });

}).call(this);

//# sourceMappingURL=employeeCtrl.js.map
