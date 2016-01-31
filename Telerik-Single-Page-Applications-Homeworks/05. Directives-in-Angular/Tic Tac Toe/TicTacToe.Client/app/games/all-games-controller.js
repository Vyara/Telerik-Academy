(function () {
    'use strict';

    function AllGamesController($location, notifier, games, identity) {
        var vm = this;

        vm.isAuthenticated = function checklogin() {
            return identity.isAuthenticated();
        }

        games.listGames().then(function (allActiveGames) {
            vm.games = allActiveGames;
        });

        vm.createGame = function createGame() {
            games.create().then(function (response) {
                notifier.success('Game of TicTacToe was successfully created.');
                vm.gameId = response;
                $location.path('/games/' + vm.gameId);
            }, function (err) {
                notifier.error(err.Message);
            });
        }

        vm.joinGame = function joinGame(gameId) {
            games.join(gameId).then(function (response) {
                notifier.success('You successfully joined the game.');
                vm.gameId = response;
                $location.path('/games/' + vm.gameId);
            }, function (err) {
                notifier.error(err.Message);
            });
        }
    }

    angular.module('game.controllers').controller('AllGamesController', ['$location', 'notifier', 'games', 'identity', AllGamesController]);
}());