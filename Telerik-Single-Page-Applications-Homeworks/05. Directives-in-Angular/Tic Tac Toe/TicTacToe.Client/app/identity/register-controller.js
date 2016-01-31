(function () {
    'use strict';

    function RegisterController($location, notifier, auth) {
        var vm = this;

        vm.register = function (user, registerForm) {
            if (registerForm.$valid) {
                auth.register(user)
                     .then(function () {
                         notifier.success('User ' + user.username + ' registered successfully!');
                         auth.login({ username: user.username, password: user.password })
                                 .then(function () {
                                     $location.path('/');
                                 });
                     }, function () {
                         notifier.error('Registration of user ' + user.username + ' failed.');
                     });
            } else {
                notifier.error('Please fill in all the required fields.');
            }
        }
    }

    angular.module('game.controllers')
        .controller('RegisterController', ['$location', 'notifier', 'auth', RegisterController]);
}());