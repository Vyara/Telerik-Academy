(function () {
    'use strict';

    function collectionSplit() {
        return function (input, startIndex, endIndex) {
            if (input) {

                return input.slice(+startIndex, endIndex + 1);
            }

            return [];
        }
    }

    angular.module('game.filters').filter('collectionSplit', [collectionSplit]);
}());