var myApp = angular.module('myModule', []);

// register the controller with the module (also create the ctrlr)

myApp.controller("schoolController", schoolController);

// similarly, register the service

myApp.service('Validator', Validator);

schoolController.$inject = ['$scope', 'Validator'];

function schoolController($scope, Validator) {
    //$scope.message = "Announcement fron School";

    // binding event giữa view controller
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber($scope.num);
    }

    $scope.num = 1;
}

function Validator($window) {
    return {
        checkNumber: checkNumber
        // sau dấu : là tên phương thức để thao tác bên ngoài, có thể viết giống nhau như set, get ấy
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'This is even';
        }
        else {
            return 'This is odd';
        }
            
    }
}

// Example for scope, rootScope and nested scope

//myApp.controller("studentController", studentController);
//myApp.controller("teacherController", teacherController);

//// myController.$inject = ['$scope'];

//// declare the controller



//function studentController($scope) {
//    $scope.message = "This is my message from Student Controller";
//}

//function teacherController($scope) {
//    $scope.message = "This is my message from Teacher Controller";
//}