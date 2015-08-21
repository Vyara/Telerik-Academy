/* globals $ */

/* 

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

function solve() {
    var validator = {
        validateIfStringOrNumber: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'string' && typeof val !== 'number') {
                throw new Error(name + ' must be a string or a number.');
            }
        },

        validateIfNullOrEmpty: function (val, name) {
            name = name || 'Value';
            if (val === '' || val === null) {
                throw new Error(name + ' cannot be empty.');
            }
        },

        validateIfUndefined: function (val, name) {
            name = name || 'Value';
            if (val === undefined) {
                throw new Error(name + ' cannot be undefinded.');
            }
        },

        validateIfDOMElement: function (val, name) {
            name = name || 'Value';
            if (!(val instanceof HTMLElement)) {
                throw new Error(name + ' must be a valid HTML element.');
            }
        },

        validateParameter: function (parameter, name) {
            name = name || 'Value';
            validator.validateIfUndefined(parameter, name);
            validator.validateIfNullOrEmpty(parameter, name);
        },

        validateIfArray: function (val, name) {
            name = name || 'Value';
            if (!(Array.isArray(val))) {
                throw new Error(name + ' must be an array.');
            }
        },
        validateContent: function (contents) {
            var i,
                len = contents.length;
            validator.validateIfArray(contents, 'Content');
            for (i = 0; i < len; i += 1) {
                validator.validateIfStringOrNumber(contents[i], 'Content');
            }
        }
    };

    function getElement(element) {
        validator.validateParameter(element);
        if (typeof  element === 'string') {
            element = document.getElementById(element);
        }
        validator.validateIfDOMElement(element);
        return element;
    }

    function addDivsToElement(element, contents) {
        var div,
            documentFragment,
            i,
            len = contents.length,
            appendedDiv;

        documentFragment = document.createDocumentFragment();
        div = document.createElement('div');
        element.innerHTML = '';
        for (i = 0; i < len; i += 1) {
            appendedDiv = div.cloneNode(true);
            appendedDiv.innerHTML = contents[i];
            documentFragment.appendChild(appendedDiv);
        }
        element.appendChild(documentFragment);
    }

    return function (element, contents) {
        element = getElement(element);
        validator.validateParameter(contents);
        validator.validateContent(contents);
        addDivsToElement(element, contents);

    };
}

module.exports = solve;