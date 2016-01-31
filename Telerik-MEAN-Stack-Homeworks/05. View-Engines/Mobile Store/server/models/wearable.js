(function (){
    'use strict';

    var wearables = [
        {
            name: 'Apple Watch',
            img: 'http://store.storeimages.cdn-apple.com/4936/as-images.apple.com/is/image/AppleInc/aos/published/images/w/42/w42sb/sbbk/w42sb-sbbk-sel-201509_GEO_US?wid=332&hei=392&fmt=jpeg&qlt=95&op_sharpen=0&resMode=bicub&op_usm=0.5,0.5,0,0&iccEmbed=0&layer=comp&.v=1441818612622',
            price: '300 USD'
        },
        {
            name: 'Samsung Gear S2',
            img: 'http://www.samsung.com/us/explore/gear-s2/assets/images/wireless-charging/poster-image.jpg',
            price: '300 USD'
        },
        {
            name: 'Huawei Watch',
            img: 'http://cdn.bgr.com/2015/03/huawei-watch-images-leak-7.jpg',
            price: '450 USD'
        },
        {
            name: 'Moto 360',
            img: 'https://lh6.googleusercontent.com/-XH7KYYXa2dw/U6BlBQ2YKzI/AAAAAAAAuAU/KG2oSLDcGKw/w2048-h1536/Moto360%2BConcept.gif',
            price: '300 USD'
        }
    ];

    module.exports = {
        wearables: wearables
    }
}());


        var deferred = $q.defer();

        $http.put('/api/games/:id', rating).success(function (response) {
            if (response.success) {
                notifier.success('Game rated successfully!');
                deferred.resolve(true);
            }
            else {
                notifier.error('Failed to rate the game!');
                deferred.resolve(false);
            }
        });

        return deferred.promise;