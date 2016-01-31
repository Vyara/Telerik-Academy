(function () {
    'use strict';

    function LoginController($location, notifier, auth) {
        var vm = this;

        vm.login = function (user, loginForm) {
            if (loginForm.$valid) {
                auth.login(user)
                     .then(function (success) {
                         notifier.success(user.username + ' logged in!');
                         $location.path('/');
                     }, function (err) {
                         notifier.error('Failed login due to incorrect data.');
                     });
            } else {
                notifier.error('Please enter username and password.');
            }
        }
    }

    angular.module('game.controllers')
        .controller('LoginController', ['$location', 'notifier', 'auth', LoginController]);
}());