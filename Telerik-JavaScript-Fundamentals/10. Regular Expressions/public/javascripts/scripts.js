/**
 Declaring variables
 */
var test,
    clear;

/* Problem 1. Format with placeholders

 Write a function that formats a string. The function should have placeholders, as shown in the example
 Add the function to the String.prototype
 Example:

 input	output
 var options = {name: 'John'};
 'Hello, there! Are you #{name}?'.format(options);	'Hello, there! Are you John'
 var options = {name: 'John', age: 13};
 'My name is #{name} and I am #{age}-years-old').format(options);	'My name is John and I am 13-years-old'
 */
test = document.getElementById('problem1test');
test.onclick = Problem1;
clear = document.getElementById('problem1clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function Problem1() {
    var firstOption = {name: jsConsole.read('#problem11')},
        secondOption = {name: jsConsole.read('#problem121'), age: jsConsole.readInteger('#problem122')},
        firstString,
        secondString;

    String.prototype.format = function (options) {
        return this.replace(/(?:#{(\w+)})/g, function ($0, $1) {
            return options[$1];
        });
    };

    firstString = 'Hello, there! Are you #{name}?';
    secondString = 'My name is #{name} and I am #{age}-years-old';

    jsConsole.writeLine(firstString.format(firstOption));
    jsConsole.writeLine(secondString.format(secondOption));
}

/* Problem 2. HTML binding

 Write a function that puts the value of an object into the content/attributes of HTML tags.
 Add the function to the String.prototype
 Example 1:

 input

 var str = '<div data-bind-content="name"></div>';
 str.bind(str, {name: 'Steven'});
 output

 <div data-bind-content="name">Steven</div>
 Example 2:

 input

 var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></?>'
 str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'});
 output

 <a data-bind-content="name" data-bind-href="link" data-bind-class="name" href="http://telerikacademy.com" class="Elena">Elena</?>
 */
test = document.getElementById('problem2test');
test.onclick = Problem2;
clear = document.getElementById('problem2clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};


function Problem2() {
    var firstInput = {name: jsConsole.read('#problem21')},
        secondInput = {name: jsConsole.read('#problem221'), link: jsConsole.read('#problem222')},
        str,
        str1,
        input,
        pattern,
        match,
        matches,
        index,
        secondIndex,
        bindingString;

    String.prototype.insertAt = function (index, string) {
        return [this.slice(0, index), string, this.slice(index)].join('');
    };

    String.prototype.bind = function (attribute) {
        input = this;
        matches = {};
        pattern = /(?:data\-bind\-(\w+)="(\w+)")/g;

        while (match = pattern.exec(input)) {
            matches[match[1]] = match[2];
        }

        for (var key in matches) {
            if (matches.hasOwnProperty(key)) {
                if (key === 'content') {
                    index = input.indexOf('>');
                    input = input.insertAt(index + 1, attribute[matches[key]]);
                } else {
                    secondIndex = input.lastIndexOf('\"');
                    input = input.insertAt(secondIndex + 1, ' ' + key + '\"=' + attribute[matches[key]] + '\"');
                }
            }
        }

        return input;
    };

    str1 = '<div data-bind-content="name"></div>';
    bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></?>';

    jsConsole.writeLine(str1.bind(firstInput));
    jsConsole.writeLine(bindingString.bind(secondInput));
    jsConsole.writeLine('Check the browser console for the HTML code');
    console.log(str1.bind(firstInput));
    console.log(bindingString.bind(secondInput));

}



