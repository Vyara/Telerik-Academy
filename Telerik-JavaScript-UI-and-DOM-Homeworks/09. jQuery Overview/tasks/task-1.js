/* globals $ */

/*

 Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:
 * The UL must have a class `items-list`
 * Each of the LIs must:
 * have a class `list-item`
 * content "List item #INDEX"
 * The indices are zero-based
 * If the provided selector does not selects anything, do nothing
 * Throws if
 * COUNT is a `Number`, but is less than 1
 * COUNT is **missing**, or **not convertible** to `Number`
 * _Example:_
 * Valid COUNT values:
 * 1, 2, 3, '1', '4', '1123'
 * Invalid COUNT values:
 * '123px' 'John', {}, []
 */

function solve() {
    var CONSTANTS = {
        UL: {
            CLASS: 'items-list'
        },
        LI: {
            CLASS: 'list-item',
            CONTENT: 'List item #'
        }
    };

    var validator = {

        validateIfString: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'string') {
                throw new Error(name + ' must be a string.');
            }
        },

        validateIfNumber: function (val, name) {
            name = name || 'Value';
            if (typeof  val !== 'number') {
                throw new Error(name + ' must be a number.');
            }
        },
        checkIfNumberIsLessThanOne: function (val, name) {
            name = name || 'Value';
            validator.validateIfNumber(val, name);
            if (val < 1) {
                throw new Error(name + ' must be larger than 1.')
            }
        },

        checkIfValueIsConvertibleToNumber: function (val, name) {
            name = name || 'Value';
            if (typeof +val !== 'number') {
                throw new Error(name + ' cannot be converted to number.')
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
                throw new Error(name + ' cannot be undefined.');
            }
        },

        validateSelector: function (selector) {
            validator.validateIfUndefined(selector, 'Selector');
            validator.validateIfNullOrEmpty(selector, 'Selector');
            validator.validateIfString(selector, 'Selector');
        },

        validateCount: function (count) {
            validator.checkIfNumberIsLessThanOne(count, 'Count');
            validator.checkIfValueIsConvertibleToNumber(count, 'Count');
        }
    };

    function getULElement(count) {
        var i,
            $li,
            $ul = $('<ul />').addClass(CONSTANTS.UL.CLASS);
        //liList = $('<li />').addClass(CONSTANTS.LI.CLASS).text(CONSTANTS.LI.CONTENT).appendTo($ul).repeat(count);
        for (i = 0; i < count; i += 1) {
            $li = $('<li />').addClass(CONSTANTS.LI.CLASS).text(CONSTANTS.LI.CONTENT + i).appendTo($ul);
        }
        return $ul;
    }

    return function (selector, count) {
        validator.validateSelector(selector);
        validator.validateCount(count);
        getULElement(count).appendTo(selector);
    };
}

module.exports = solve;