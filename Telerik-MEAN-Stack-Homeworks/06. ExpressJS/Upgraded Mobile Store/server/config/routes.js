var auth = require('./auth'),
    path = require('path'),
    controllers = require('../controllers');

module.exports = function (app) {

    app.get('/home', function(req, res) {
        res.render('../views/home/home');
    });

    app.get('/phones', controllers.phones.getAll);
    app.get('/phones/:id', auth.isAuthenticated, controllers.phones.getDetails);

    app.get('/tablets', controllers.tablets.getAll);
    app.get('/tablets/:id', auth.isAuthenticated, controllers.tablets.getDetails);

    app.get('/wearables', controllers.wearables.getAll);
    app.get('/wearables/:id', auth.isAuthenticated, controllers.wearables.getDetails);

    app.get('/login', controllers.users.getLogin);
    app.post('/login', auth.login);
    app.get('/logout', auth.isAuthenticated, auth.logout);

    app.get('/upload', auth.isAuthenticated, controllers.files.getUpload);
    app.post('/upload', auth.isAuthenticated, controllers.files.postUpload);

    app.get('/upload-results', auth.isAuthenticated, controllers.files.getResults);

    app.get('/files/download/:id', controllers.files.download);

    app.post('/signup', controllers.users.postRegister);
    app.get('/signup', controllers.users.getRegister);

    app.get('*', function(req, res) {
        res.redirect('/home');
    });
};