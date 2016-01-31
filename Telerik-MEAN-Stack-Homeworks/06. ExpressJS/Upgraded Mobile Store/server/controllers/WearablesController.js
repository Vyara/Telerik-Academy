var Wearable = require('mongoose').model('Wearable');

module.exports = {
    getAll: function (req, res, next) {

        Wearable.find({})
            .exec(function (err, wearables) {
                if (err) {
                    console.log('Getting all wearables failed: ' + err);
                    return;
                } else {
                    res.render('../views/wearables/wearables', {
                        wearable: wearables,
                        currentUser: req.user
                    });

                }
            })
    },
    getDetails: function (req, res) {
        if (req.isAuthenticated()) {
            Wearable.find({_id: req.params.id}).exec(function (err, wearable) {
                if (err) {
                    console.log('Get wearable failed: ' + err);
                    return;
                }

                res.render('../views/wearables/wearable-details', {wearable: wearable[0], currentUser: req.user});
            });
        }
        else {
            res.send({reason: 'You do not have permissions!'})
        }
    }
};

