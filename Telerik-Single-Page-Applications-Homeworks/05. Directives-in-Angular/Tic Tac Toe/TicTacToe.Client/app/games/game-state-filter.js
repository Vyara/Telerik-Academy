(function () {
    'use strict';

    function gameState() {
        return function (input) {

            switch (input) {
                case 0:
                    return 'Awaiting second player';
                case 1:
                    return 'Player One\'s turn';
                case 2:
                    return 'Player Two\'s turn';
                case 3:
                    return 'Game won by Player One';
                case 4:
                    return 'Game Won by Player Two';
                case 5:
                    return 'Draw';

                default:
                    return 'AwaitingSecondPlayer';
            }
        }
    }

    angular.module('game.filters').filter('gameState', [gameState]);
}());