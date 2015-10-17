function checkIfMozilla(event, parameters) {
    'use strict';
    var currentWindow = window,
        browserName = currentWindow.navigator.appCodeName,
        isBroswerMozilla = (browserName === 'Mozilla');
    if (isBroswerMozilla) {
        alert('Yes');
    } else {
        alert('No');
    }
}