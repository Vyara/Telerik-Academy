(function () {
    'use strict';

    var express = require('express'),
        phones = require('./server/models/phone'),
        tablets = require('./server/models/tablet'),
        wearables = require('./server/models/wearable'),
        links = require('./server/models/links'),
        app = express(),
        port = 3030;


    app.set('view engine', 'jade');
    app.set('views', './server/views');

    app.get('/', function (req, res) {
        res.render('home', links);
    });

    app.get('/phones', function (req, res) {
        res.render(req.url.replace('/', ''), phones);
    });

    app.get('/tablets', function (req, res) {
        res.render(req.url.replace('/', ''), tablets);
    });

    app.get('/wearables', function (req, res) {
        res.render(req.url.replace('/', ''), wearables);
    });
    app.listen(port);
    console.log('Server now running on port: ' + port);
} ());
