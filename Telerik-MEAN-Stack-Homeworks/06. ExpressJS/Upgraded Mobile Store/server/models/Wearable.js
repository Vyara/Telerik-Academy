var mongoose = require('mongoose');

var wearableSchema = mongoose.Schema({
    name: String,
    price: Number,
    img: String
});


var Wearable = mongoose.model('Wearable', wearableSchema);

module.exports.seedInitialWearables = function() {
    Wearable.find({}).exec(function(err, collection) {
        console.log('Cannot find wearables: ' + err);
        if (err) {
            return;
        }

        if (collection.length === 0) {

            Wearable.create({name: 'Apple Watch', price: 300, img: 'http://store.storeimages.cdn-apple.com/4936/as-images.apple.com/is/image/AppleInc/aos/published/images/w/42/w42sb/sbbk/w42sb-sbbk-sel-201509_GEO_US?wid=332&hei=392&fmt=jpeg&qlt=95&op_sharpen=0&resMode=bicub&op_usm=0.5,0.5,0,0&iccEmbed=0&layer=comp&.v=1441818612622'});
            Wearable.create({name: 'Samsung Gear S2', price: 300, img: 'http://www.samsung.com/us/explore/gear-s2/assets/images/wireless-charging/poster-image.jpg'});
            Wearable.create({name: 'Huawei Watch', price: 450, img: 'http://cdn.bgr.com/2015/03/huawei-watch-images-leak-7.jpg'});
            Wearable.create({name: 'Moto 360', price: 300, img: 'https://lh6.googleusercontent.com/-XH7KYYXa2dw/U6BlBQ2YKzI/AAAAAAAAuAU/KG2oSLDcGKw/w2048-h1536/Moto360%2BConcept.gif'});
            console.log('Wearables added to database...');
        }
    });
};
