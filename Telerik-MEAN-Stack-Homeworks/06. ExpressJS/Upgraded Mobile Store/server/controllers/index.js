var UsersController = require('./UsersController'),
    FilesController = require('./FilesController'),
    PhonesController = require('./PhonesController'),
    TabletsController = require('./TabletsController'),
    WearablesController = require('./WearablesController');

module.exports = {
    users: UsersController,
    files: FilesController,
    phones: PhonesController,
    tablets: TabletsController,
    wearables: WearablesController
};