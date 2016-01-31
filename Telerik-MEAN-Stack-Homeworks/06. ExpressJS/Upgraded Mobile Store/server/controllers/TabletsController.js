var Tablet = require('mongoose').model('Tablet');

module.exports = {
    getAll: function (req, res, next) {

        Phone.find({})
            .exec(function (err, tablets) {
                if (err) {
                    console.log('Getting all tablets failed: ' + err);
                    return;
                } else {
                    res.render('../views/tablets/tablets', {
                        tablet: tablets,
                        currentUser: req.user
                    });

                }
            })
    },
    getDetails: function (req, res) {
        if (req.isAuthenticated()) {
            Tablet.find({_id: req.params.id}).exec(function (err, tablet) {
                if (err) {
                    console.log('Get tablet failed: ' + err);
                    return;
                }

                res.render('../views/tablets/tablet-details', {tablet: tablet[0], currentUser: req.user});
            });
        }
        else {
            res.send({reason: 'You do not have permissions!'})
        }
    }
};
