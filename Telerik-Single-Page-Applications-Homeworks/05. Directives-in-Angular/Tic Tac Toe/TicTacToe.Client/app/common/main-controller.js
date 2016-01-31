(function () {
    'use strict';

    function MainController($location, auth, identity) {
        var vm = this;

        waitForLogin();

        vm.logout = function () {
            vm.globallySetCurrentUser = undefined;
            auth.logout();
            waitForLogin(); 
            $location.path('/');
        };

        vm.isAuthenticated = function checklogin() {
            return identity.isAuthenticated();
        }

        function waitForLogin() {
            identity.getUser()
                .then(function (user) {
                    vm.globallySetCurrentUser = user;
                });
        }
    }

    angular.module('game')
        .controller('MainController', ['$location', 'auth', 'identity', MainController]);
}());