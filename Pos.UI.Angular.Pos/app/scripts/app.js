var pos = angular.module('pos', ['ngRoute']);

pos.config(function ($routeProvider) {
    $routeProvider.when('/', {
        templateUrl: 'app/views/home.html',
        controller: '#'
    })
    .when('/homeproduct', {
        templateUrl: 'app/views/homeproduct.html',
        controller: "homeproductCtrl"
    })
    .when('/products', {
        templateUrl: 'app/views/products.html',
        controller: 'productCtrl'
    })
    .when('/employees', {
        templateUrl: 'app/views/employees.html',
        controller: 'employeeCtrl'
    })
    .otherwise({
        redirectTo: '/'
    })
});
