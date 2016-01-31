var path = require('path');
var rootPath = path.normalize(__dirname + '/../../');

module.exports = {
    rootPath: rootPath,
    port: 3030,
    db: 'mongodb://localhost/mobile-store'
};