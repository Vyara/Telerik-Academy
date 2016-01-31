var mongoose = require('mongoose');

var phoneSchema = mongoose.Schema({
    name: String,
    price: Number,
    img: String
});


var Phone = mongoose.model('Phone', phoneSchema);

module.exports.seedInitialPhones = function() {
    Phone.find({}).exec(function(err, collection) {
        if (err) {
            console.log('Cannot find phones: ' + err);
            return;
        }

        if (collection.length === 0) {

            Phone.create({name: 'iPhone 6', price: 550, img: 'http://store.storeimages.cdn-apple.com/4936/as-images.apple.com/is/image/AppleInc/aos/published/images/i/ph/iphone6/box/iphone6-box-silver-2014_GEO_US?wid=478&hei=595&fmt=jpeg&qlt=95&op_sharpen=0&resMode=bicub&op_usm=0.5,0.5,0,0&iccEmbed=0&layer=comp&.v=1441802224133'});
            Phone.create({name: 'Samsung Galaxy Note 5', price: 630, img: 'http://cdn2.knowyourmobile.com/sites/knowyourmobilecom/files/styles/gallery_wide/public/Array/whitenote5_600x600_grp.jpg?itok=p5dbjLV9'});
            Phone.create({name: 'Google Nexus 6', price: 650, img: 'http://www.extremetech.com/wp-content/uploads/2014/10/nexus-6-product-photo.jpg'});
            Phone.create({name: 'Nokia Lumia 1020', price: 260, img: 'http://cdn2.gsmarena.com/vv/pics/nokia/nokia-lumia-1020.jpg'});
            console.log('Phones added to database...');
        }
    });
};
