(function (app) {
    app.filter('statusFilter', statusFilter);

    function statusFilter() {
        return function (input) {
            return input ? 'Kích hoạt' : 'Khóa';
        }
    };
})(angular.module('tedushop.common'));