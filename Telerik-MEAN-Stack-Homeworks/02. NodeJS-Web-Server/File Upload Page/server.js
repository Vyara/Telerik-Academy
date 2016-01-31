(function () {
    'use strict';
    var http = require('http'),
        fse = require('fs-extra'),
        jade = require('jade'),
        uuid = require('uuid'),
        formidable = require('formidable'),
        port = 3030,
        uploadedPath = '/upload',
        uploadedFilesPath = './uploaded/',
        allFilesPath = '/files',
        allFilesForm = './views/display-all-files.jade',
        homeForm = './views/home.html',
        successfulUploadForm = './views/successful-upload.html';

    http.createServer(function (request, response) {
        if (request.url === '/') {
            fse.readFile(homeForm, function (error, form) {
                if (error) {
                    console.log(error);
                } else {
                    response.writeHead(200, {'content-type': 'text/html'});
                    response.end(form);
                }
            });
        }

        if (request.url == uploadedPath && request.method.toLowerCase() === 'post') {
            var form = new formidable.IncomingForm();

            form.parse(request, function (error, fields, files) {
                fse.readFile(successfulUploadForm, function (error, form) {
                    if (error) {
                        console.log(error);
                    } else {
                        response.writeHead(200, {'content-type': 'text/html'});
                        response.end(form);
                    }
                });
            });

            form.on('end', function (fields, files) {
                    var filePath = this.openedFiles[0].path,
                        fileRawName = this.openedFiles[0].name,
                        fileGuidName = uuid.v1() + fileRawName.substring(fileRawName.lastIndexOf('.'));

                    fse.copy(filePath, uploadedFilesPath + '/' + fileGuidName, function (error) {
                        if (error) {
                            console.log(error)
                        } else {
                            console.log('Successfully uploaded file!');
                        }
                    });
                }
            );
        }
        if (request.url === allFilesPath) {
            fse.readFile(allFilesForm, function (err, form) {
                if (err) {
                    response.end(err);
                    return;
                }

                fse.readdir(uploadedFilesPath, function (error, files) {
                    if (error) {
                        response.end(error);
                        return;
                    }

                    var splittedFiles = files.map(function (f) {
                        return f.split('.')[0]
                    });
                    var outputForm = jade.compile(form)({
                        files: splittedFiles
                    });
                    response.end(outputForm);
                })
            });
        }

        var splittedUrl = request.url.split('/');

        if ((splittedUrl[1] === 'files') && (splittedUrl.length === 3)) {
            var guid = splittedUrl[2];

            fse.readdir(uploadedFilesPath, function (error, files) {
                for (var i = 0, len = files.length; i < len; i += 1) {
                    var splittedName = files[i].split('.');
                    if (guid === splittedName[0]) {
                        response.writeHead(200, {
                            'Content-Disposition': 'attachment; filename=' + files[i] + ';'
                        });

                        var rs = fse.createReadStream(uploadedFilesPath + files[i]);
                        rs.pipe(response);
                        return;
                    }
                }

                response.end('<p> Not found!</p>');
            });
        }

    }).listen(port);

    console.log('Server now running on port: ' + port);
}());