var mongoose = require('mongoose');

var tabletSchema = mongoose.Schema({
    name: String,
    price: Number,
    img: String
});


var Tablet = mongoose.model('Tablet', tabletSchema);

module.exports.seedInitialTablets = function() {
    Tablet.find({}).exec(function(err, collection) {
        if (err) {
            console.log('Cannot find tablets: ' + err);
            return;
        }

        if (collection.length === 0) {

            Tablet.create({name: 'iPad Air 2', price: 530, img: 'http://store.storeimages.cdn-apple.com/4936/as-images.apple.com/is/image/AppleInc/aos/published/images/a/ir/air/scene0/air-scene0-right_GEO_US?wid=739&hei=578&fmt=png-alpha&qlt=95&.v=1413463593663'});
            Tablet.create({name: 'Samsung Galaxy Tab 10.1', price: 450, img: 'http://www.samsung.com/uk/consumer-images/product/tablets/2014/GT-P5210ZWABTU/GT-P5210ZWABTU-425072-0.jpg'});
            Tablet.create({name: 'Google Pixel C', price: 740, img: 'https://assets.entrepreneur.com/content/16x9/822/20150929205849-google-tablet-pixel-c.jpeg'});
            Tablet.create({name: 'Microsoft Surface Pro 4', price: 1300, img: 'http://betanews.com/wp-content/uploads/2015/10/Surface-Pro-4.jpg'});
            console.log('Tablets added to database...');
        }
    });
};

