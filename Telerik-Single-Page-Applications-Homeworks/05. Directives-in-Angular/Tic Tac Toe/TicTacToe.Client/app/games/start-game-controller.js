(function () {
    'use strict';

    function StartGameController($location, $interval, $routeParams, notifier, games) {
        var vm = this;

        vm.gameId = $routeParams.gameId;

        function status() {
            if (!vm.gameId || $location.path() != '/games/' + vm.gameId) {
                return;
            }

            games.status(vm.gameId).then(function (gameInfo) {
                vm.game = gameInfo;
            }, function (error) {
                notifier.error(error.Message);
            });
        }

        $interval(status, 1000);

        vm.play = function play(row, index) {
            var col = (index % 3) + 1;

            games.play({ GameId: vm.gameId, Row: row, Col: col })
                .then(function (response) {
                    notifier.success('Your turn was successful.');
                }, function (error) {
                    notifier.error(error.Message);
                });
        }
    }

    angular.module('game.controllers').controller('StartGameController', ['$location', '$interval', '$routeParams', 'notifier', 'games', StartGameController]);
}());