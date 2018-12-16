var myApp = angular.module('myModule', []);

// create the controller and register the controller with the module

myApp.controller("schoolController", schoolController);
myApp.controller("studentController", studentController);
myApp.controller("teacherController", teacherController);

// myController.$inject = ['$scope'];

// declare the controller

function schoolController($scope) {
    $scope.message = "Announcement fron School";
}

function studentController($scope) {
    $scope.message = "This is my message from Student Controller";
}

function teacherController($scope) {
    $scope.message = "This is my message from Teacher Controller";
}