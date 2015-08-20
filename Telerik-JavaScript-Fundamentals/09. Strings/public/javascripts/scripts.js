/**
 Declaring variables
 */
var test,
    clear;

/* Problem 1. Reverse string

 Write a JavaScript function that reverses a string and returns it.
 Example:

 input	output
 sample
 */
test = document.getElementById('problem1test');
test.onclick = reverseString;
clear = document.getElementById('problem1clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function reverseString() {
    var str = jsConsole.read('#problem1'),
        reversed = '',
        i,
        len = str.length;

    for (i = len - 1; i >= 0; i -= 1) {
        reversed += str[i];
    }


    jsConsole.writeLine('Original: ' + str);
    jsConsole.writeLine('Reversed: ' + reversed);

}

/* Problem 2. Correct brackets

 Write a JavaScript function to check if in a given expression the brackets are put correctly.
 Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */
test = document.getElementById('problem2test');
test.onclick = correctBrackets;
clear = document.getElementById('problem2clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};


function correctBrackets() {

    var firstExpression = jsConsole.read('#problem21'),
        secondExpression = jsConsole.read('#problem22'),
        count = 0,
        openingBracketsCount = 0,
        expressions = [firstExpression, secondExpression],
        closingBracketsCount = 0,
        len,
        exp;

    function areBracketsCorrect(expression) {
        len = expression.length,
            count = 0;
        while (count < len) {
            if (expression[count] === '(') {
                openingBracketsCount += 1;
            } else if (expression[count] === ')') {
                closingBracketsCount += 1;
                if (openingBracketsCount === 0) {
                    return false;
                } else {
                    openingBracketsCount -= 1;
                    closingBracketsCount -= 1;
                }
            }
            count += 1;
        }

        return openingBracketsCount === closingBracketsCount;

    }

    for (exp in expressions) {
        if (areBracketsCorrect(expressions[exp])) {
            jsConsole.writeLine('Expression ' + expressions[exp] + ' is CORRECT.');
        } else {
            jsConsole.writeLine('Expression ' + expressions[exp] + ' is INCORRECT.');
        }
    }


}

/* Problem 3. Sub-string in text

 Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 Example:

 The target sub-string is in

 The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

 The result is: 9
 */
test = document.getElementById('problem3test');
test.onclick = subStringInText;
clear = document.getElementById('problem3clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};


function subStringInText() {
    var text = jsConsole.read('#problem31').toLowerCase(),
        target = jsConsole.read('#problem32').toLocaleLowerCase(),
        result,
        index,
        found,
        count;

    function countRepeatingSubstring(input, searchStr) {
        index = 0;
        count = 0;
        while (true) {
            found = text.indexOf(target, index);
            if (found < 0) {

                break;
            }

            count += 1;
            index = found + 1;
        }

        return count;
    }

    result = countRepeatingSubstring(text, target);

    jsConsole.writeLine('The sub-string "' + target + '" appears ' + result + ' times in the given text.')
}

/* Problem 4. Parse tags

 You are given a text. Write a function that changes the text in all regions:

 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

 The expected result:
 We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

 Note: Regions can be nested.
 */
test = document.getElementById('problem4test');
test.onclick = parseTags;
clear = document.getElementById('problem4clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};
function parseTags() {
    var text = jsConsole.read('#problem4'),
        result,
        i,
        len,
        random,
        min,
        max;


    function mixCase(input) {
        len = input.length;
        result = '';
        symbol = '';
        toLower = false;
        min = 0;
        max = 50;

        for (i = 0; i < len; i += 1) {
            random = Math.floor(Math.random() * (max - min)) + min;

            result += (random >= 25 ? input[i].toUpperCase() : input[i].toLowerCase());
        }

        return result;
    }


    text = text.replace(/&lt;/g, '<');
    text = text.replace(/&gt;/g, '>');

    text = text.replace(/<upcase>(.*?)<\/upcase>/gi, function (tag, match) {
        return match.toUpperCase();
    });

    text = text.replace(/<lowcase>(.*?)<\/lowcase>/gi, function (tag, match) {
        return match.toLowerCase();
    });

    text = text.replace(/<mixcase>(.*?)<\/mixcase>/gi, function (tag, match) {
        return mixCase(match);
    });

    jsConsole.writeLine(text);

}


/* Problem 5. nbsp

 Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */
test = document.getElementById('problem5test');
test.onclick = nbsp;
clear = document.getElementById('problem5clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function nbsp() {
    var text = jsConsole.read('#problem5'),
        target = '&nbsp;',
        result;

    result = text.replace(/ /g, target);

    jsConsole.writeLine(result);
}

/* Problem 6. Extract text from HTML

 Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.
 Example:

 <html>
 <head>
 <title>Sample site</title>
 </head>
 <body>
 <div>text
 <div>more text</div>
 and more...
 </div>
 in body
 </body>
 </html>
 Result: Sample site text more text and more...in body
 */

test = document.getElementById('problem6test');
test.onclick = extractFromHTML;
clear = document.getElementById('problem6clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function extractFromHTML() {

    var text = jsConsole.read('#problem6');

    text = text.replace(/&lt;/g, '<');
    text = text.replace(/&gt;/g, '>');
    text = text.replace(/<(.*?)>/g, '');

    jsConsole.writeLine(text);

}

/* Problem 7. Parse URL

 Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 Return the elements in a JSON object.
 Example:

 URL	result
 http://telerikacademy.com/Courses/Courses/Details/239	{ protocol: http,
 server: telerikacademy.com
 resource: /Courses/Courses/Details/239
 */

test = document.getElementById('problem7test');
test.onclick = Problem7;
clear = document.getElementById('problem7clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function Problem7() {
    var url = jsConsole.read('#problem7'),
        protocol,
        address,
        splittedAddtress,
        server,
        resource = '',
        len,
        i;

    function cleanArray(actual) {
        var newArray = [];
        for (var i = 0; i < actual.length; i++) {
            if (actual[i]) {
                newArray.push(actual[i]);
            }
        }
        return newArray;
    }


    protocol = url.substr(0, 6).replace(/:\/+/g, '');
    address = url.substr(protocol.length).replace(':', '');
    splittedAddtress = address.split('/');
    splittedAddtress = cleanArray(splittedAddtress);
    server = splittedAddtress[0];

    len = splittedAddtress.length;

    for (i = 1; i < len; i += 1) {
        resource += '/' + splittedAddtress[i];

    }

    jsConsole.writeLine('[protocol] = ' + protocol);
    jsConsole.writeLine('[server] = ' + server);
    jsConsole.writeLine('[resource] = ' + resource);

}

/* Problem 8. Replace tags

 Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 Example:

 input	output
 <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */

test = document.getElementById('problem8test');
test.onclick = Problem8;
clear = document.getElementById('problem8clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function Problem8() {
    var text = jsConsole.read('#problem8');
    text = text.replace(/&lt;/g, '<');
    text = text.replace(/&gt;/g, '>');
    text = text.replace(/<a href="(.*?)">(.*?)<\/a>/gi, function (tag, url, words) {
        return "[URL=" + url + ']' + words + '[\/URL]';
    });

    jsConsole.writeLine(text);
}

/* Problem 9. Extract e-mails

 Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @… should be recognized as emails.
 Return the emails as array of strings.
 */

test = document.getElementById('problem9test');
test.onclick = Problem9;
clear = document.getElementById('problem9clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function Problem9() {
    var text = jsConsole.read('#problem9'),
        emails = text.match(/(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))/g),
        email;

    for (email in emails) {
        jsConsole.writeLine(emails[email]);
    }

}

/* Problem 10. Find palindromes

 Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */

test = document.getElementById('problem10test');
test.onclick = Problem10;
clear = document.getElementById('problem10clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function Problem10() {
    var text = jsConsole.read('#problem10'),
        pattern = /\b\w+\b/gi,
        words = text.match(pattern),
        i,
        j,
        wordLength,
        len = words.length;

    for (i = 0; i < len; i += 1) {
        if (isPalindrome(words[i])) {
            jsConsole.writeLine(words[i]);
        }
    }

    function isPalindrome(word) {
        word = word.toLowerCase();
        wordLength = word.length;
        for (j = 0; j < wordLength / 2; j += 1) {
            if (word.charAt(j) != word.charAt(wordLength - j - 1)) {
                return false;
            }
        }

        return true;
    }


}

/* Problem 11. String format

 Write a function that formats a string using placeholders.
 The function should work with up to 30 placeholders and all types.
 Examples:

 var str = stringFormat('Hello {0}!', 'Peter');
 //str = 'Hello Peter!';

 var frmt = '{0}, {1}, {0} text {2}';
 var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
 //str = '1, Pesho, 1 text Gosho'
 */

test = document.getElementById('problem11test');
test.onclick = Problem11;
clear = document.getElementById('problem11clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function Problem11() {
    var firstText,
        frmt,
        currentArgs;

    function stringFormat(expression) {
        currentArgs = arguments;

        return expression.replace(/\{(\d+)}/g, function (match, argument) {
            return currentArgs[(argument | 0) + 1];
        });
    }

    firstText = stringFormat("Hello {0}!", "Peter");


    frmt = "{0}, {1}, {0} text {2}";


    jsConsole.writeLine(stringFormat(firstText));


    jsConsole.writeLine(stringFormat(frmt, 1, 'Pesho', 'Gosho'));

}

/* Problem 12. Generate list

 Write a function that creates a HTML <ul> using a template for every HTML <li>.
 The source of the list should be an array of elements.
 Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
 Example: HTML:

 <div data-type="template" id="list-item">
 <strong>-{name}-</strong> <span>-{age}-</span>
 /div>
 JavaScript:

 var people = [{name: 'Peter', age: 14},…];
 var tmpl = document.getElementById('list-item').innerHtml;
 var peopleList = generateList(people, template);
 //peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'
 */

test = document.getElementById('problem12test');
test.onclick = Problem12;
clear = document.getElementById('problem12clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function Problem12() {
    var html = jsConsole.read('#problem12'),
        people = [
            {name: 'John', age: 23},
            {name: 'Jane', age: 32},
            {name: 'Alana', age: 18},
            {name: 'Brian', age: 46},
            {name: 'Zoe', age: 26},
            {name: 'Yuki', age: 28}
        ],
        temp,
        element,
        person,
        i;

    html = html.replace(/&lt;/g, '<');
    html = html.replace(/&gt;/g, '>');


    var div = document.createElement('div');
    div.innerHTML = html;

    element = div.firstChild;

    document.body.appendChild(div);

    temp = document.getElementById('list-item').innerHTML;


    function generateList(group) {
        var ul = document.createElement('ul');

        for (i in group) {
            var li = document.createElement('li');
            li.innerHTML = formatString(temp, people[i]);
            ul.appendChild(li);
        }
        document.body.appendChild(ul);
    };

    function formatString(string, person) {
        return string.replace(/\-{(\w+)\}-/g, function (match, prop) {
            return person[prop] || '';
        });
    }

    jsConsole.writeLine('People: ');
    for (person in people) {
        jsConsole.writeLine(people[person].name + ' ' + people[person].age);
    }

    jsConsole.writeLine(generateList(people));
    jsConsole.writeLine('HTML created accordingly! Check the html\'s body last element- should be ul!');
    jsConsole.writeLine('List will appear below the console as well');
}

