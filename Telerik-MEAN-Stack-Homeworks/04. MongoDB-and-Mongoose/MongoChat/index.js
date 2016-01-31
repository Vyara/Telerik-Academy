var db = require('./server/config/db');

db.init();

db.registerUser({ username: 'AlbertEinsten', password: '356667e' });
db.registerUser({ username: 'IsaacNewton', password: '356667e' });

db.sendMessage({
    from: 'AlbertEinsten',
    to: 'IsaacNewton',
    text: 'Sup, Isi!'
});

db.sendMessage({
    from: 'IsaacNewton',
    to: 'AlbertEinsten',
    text: 'Nothing much, working on gravitational theorem and chilling!'
});

db.sendMessage({
    from: 'AlbertEinsten',
    to: 'IsaacNewton',
    text: 'Cool, looking forward to outsmart you!'
});

db.sendMessage({
    from: 'IsaacNewton',
    to: 'AlbertEinsten',
    text: 'Good luck with that!'
});

setTimeout(function () {
    db.getMessages({
        with: 'AlbertEinsten',
        and: 'IsaacNewton'
    });
}, 2000);
