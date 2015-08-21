/* globals $ */

/*

 Create a function that takes an id or DOM element and:

 If an id is provided, select the element
 Finds all elements with class button or content within the provided element
 Change the content of all .button elements with "hide"
 When a .button is clicked:
 Find the topmost .content element, that is before another .button and:
 If the .content is visible:
 Hide the .content
 Change the content of the .button to "show"
 If the .content is hidden:
 Show the .content
 Change the content of the .button to "hide"
 If there isn't a .content element after the clicked .button and before other .button, do nothing
 Throws if:
 The provided DOM element is non-existant
 The id is either not a string or does not select any DOM element
 */

function solve() {
    var CONSTANTS = {
        CLASSES: {
            BUTTON: 'button',
            CONTENT: 'content'
        },

        DISPLAY_OPTION: {
            HIDDEN: 'none',
            VISIBLE: ''
        },

        BUTTON_INNER_HTML: {
            SHOW: 'show',
            HIDE: 'hide'
        }
    };

    var validator = {
        validateIfNullOrEmpty: function (val, name) {
            name = name || 'Value';
            if (val === '' || val === null) {
                throw new Error(name + ' cannot be empty.');
            }
        },

        validateIfUndefined: function (val, name) {
            name = name || 'Value';
            if (val === undefined) {
                throw new Error(name + ' cannot be undefined.');
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
        }
    };

    function getElement(element) {
        validator.validateParameter(element);
        if (typeof  element === 'string') {
            element = document.getElementById(element);
        }
        validator.validateIfNullOrEmpty(element);
        validator.validateIfDOMElement(element);
        return element;
    }

    function getChildrenWithASpecificClass(element, className) {
        var resultElements = [],
            elementChildren = element.children,
            i,
            len = elementChildren.length,
            currentChild;

        for (i = 0; i < len; i += 1) {
            currentChild = elementChildren[i];
            if (currentChild.className === className) {
                resultElements.push(currentChild);
            }
        }

        return resultElements;
    }

    function clickedButtonActions(event) {
        var target = event.target,
            canChangeVisibility,
            contentElement,
            nextSibling = target.nextElementSibling;

        while (nextSibling) {
            if (nextSibling.className = CONSTANTS.CLASSES.CONTENT) {
                contentElement = nextSibling;

                while (nextSibling) {
                    if (nextSibling.className === CONSTANTS.CLASSES.BUTTON) {
                        canChangeVisibility = true;
                        break;
                    }
                    nextSibling = nextSibling.nextElementSibling;
                }
                break;
            } else {
                nextSibling = nextSibling.nextElementSibling;
            }
        }

        if (canChangeVisibility) {
            if (contentElement.style.display === CONSTANTS.DISPLAY_OPTION.HIDDEN) {
                contentElement.style.display = CONSTANTS.DISPLAY_OPTION.VISIBLE;
                target.innerHTML = CONSTANTS.BUTTON_INNER_HTML.HIDE;
            } else {
                contentElement.style.display = CONSTANTS.DISPLAY_OPTION.HIDDEN;
                target.innerHTML = CONSTANTS.BUTTON_INNER_HTML.SHOW;
            }
        }
    }

    return function (selector) {
        var element;
        element = getElement(selector);
        getChildrenWithASpecificClass(element, CONSTANTS.CLASSES.BUTTON).map(function (button) {
            button.innerHTML = CONSTANTS.BUTTON_INNER_HTML.HIDE;
            button.addEventListener('click', clickedButtonActions);
        });
    };
}

module.exports = solve;