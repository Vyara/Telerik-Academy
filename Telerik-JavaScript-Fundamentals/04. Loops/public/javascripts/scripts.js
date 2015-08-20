/**
 Declaring variables
 */
var test,
    clear;

/**
 Problem 1. Numbers

 Write a script that prints all the numbers from 1 to N.
 */
test = document.getElementById('problem1test');
test.onclick = printOneToN;
clear = document.getElementById('problem1clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function printOneToN() {
    var n = jsConsole.readInteger('#problem1'),
        i;

    for (i = 1; i <= n; i += 1) {
        jsConsole.write(i + ' ');
    }

    jsConsole.writeLine();


}

/** Problem 2. Numbers not divisible

 Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
 */
test = document.getElementById('problem2test');
test.onclick = notDivisibleBy3And7;
clear = document.getElementById('problem2clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function notDivisibleBy3And7() {
    var n = jsConsole.readInteger('#problem2'),
        i;
    for (i = 1; i <= n; i += 1) {
        if (!(i % 3) && !(i % 7)) {
            continue;

        }
        jsConsole.write(i + ' ');

    }
    jsConsole.writeLine();
}

/** Problem 3. Min/Max of sequence

 Write a script that finds the max and min number from a sequence of numbers.
 */
test = document.getElementById('problem3test');
test.onclick = minAndMaxFromSequence;
clear = document.getElementById('problem3clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}


function minAndMaxFromSequence() {
    var sequence = jsConsole.read('#problem3'),
        i,
        numbers = sequence.split(' '),
        min,
        max,
        len = numbers.length,
        number;

    for (i = 0; i < len; i += 1) {
        number = +numbers[i];
        if (i == 0) {
            min = max = number;
        }

        if (number >= max) {
            max = number;
        } else if (number <= min) {
            min = number;
        }

    }
    jsConsole.writeLine('min = ' + min);
    jsConsole.writeLine('max = ' + max);


}

/** Problem 4. Lexicographically smallest

 Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
 */
test = document.getElementById('problem4test');
test.onclick = lexicographicallySmallestProperty;
clear = document.getElementById('problem4clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function lexicographicallySmallestProperty() {
    var min = 'zz',
        max = '',
        prop;
    for (prop in document) {
        if (prop < min) {
            min = prop;
        }
        if (prop > max) {
            max = prop;

        }
    }

    jsConsole.writeLine('Document: ');
    jsConsole.writeLine('Smallest property: ' + min);
    jsConsole.writeLine('Largest property: ' + max);
    jsConsole.writeLine();

    min = 'zz',
        max = '';

    for (prop in window) {
        if (prop < min) {
            min = prop;
        }
        if (prop > max) {
            max = prop;

        }
    }

    jsConsole.writeLine('Window: ');
    jsConsole.writeLine('Smallest property: ' + min);
    jsConsole.writeLine('Largest property: ' + max);
    jsConsole.writeLine();

    min = 'zz',
        max = '';

    for (prop in navigator) {
        if (prop < min) {
            min = prop;
        }
        if (prop > max) {
            max = prop;

        }
    }

    jsConsole.writeLine('Navigator: ');
    jsConsole.writeLine('Smallest property: ' + min);
    jsConsole.writeLine('Largest property: ' + max);
    jsConsole.writeLine();

}

