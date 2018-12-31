(function (app) {
    app.controller('productEditController', productEditController);

    productEditController.$inject = ['$scope', 'apiService', 'notificationService', '$state', '$stateParams', 'commonService'];

    function productEditController($scope, apiService, notificationService, $state, $stateParams, commonService) {
        $scope.product = {
            UpdatedDate: new Date()
        };

        $scope.ckeditorOptions = {
            language: 'vi',
            height: '200px'
        };

        $scope.GetSeoTitle = GetSeoTitle;

        function GetSeoTitle() {
            $scope.product.Alias = commonService.getSeoTitle($scope.product.Name);
        }

        $scope.productCategories = [];
        $scope.moreImages = [];
        $scope.UpdateProduct = UpdateProduct;

        function UpdateProduct() {
            $scope.product.MoreImages = JSON.stringify($scope.moreImages);
            apiService.put('api/product/update', $scope.product, function (result) {
                notificationService.displaySuccess(result.data.Name + ' đã được cập nhật thành công.');
                $state.go('products');
            }, function (error) {
                notificationService.displayError('Cập nhật không thành công.');
            });
        }

        function loadProductDetail() {
            apiService.get('api/product/getbyid/' + $stateParams.id, null, function (result) {
                $scope.product = result.data;
                $scope.moreImages = JSON.parse($scope.product.MoreImages);
            }, function (error) {
                notificationService.displayError(error.data);
            });
        }


        function loadProductCategory() {
            apiService.get('api/productcategory/getallparents', null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log('Cannot get list parent');
            });
        }

        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.$apply(function () {
                    $scope.product.Image = fileUrl;
                })
            }
            finder.popup();
        }

        $scope.ChooseMoreImages = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.$apply(function () {
                    $scope.moreImages.push(fileUrl);
                })
            }
            finder.popup();
        }

        loadProductCategory();
        loadProductDetail();
    }
})(angular.module('tedushop.products'));