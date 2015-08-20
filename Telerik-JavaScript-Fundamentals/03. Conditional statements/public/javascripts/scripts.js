/**
 Declaring variables
 */
var test,
    clear;

/**
 Problem 1. Exchange if greater

 Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.
 Examples:

 a    b    result
 5    2    2 5
 3    4    3 4
 5.5    4.5    4.5 5.5
 */
test = document.getElementById('problem1test');
test.onclick = exchangeIfGreater;
clear = document.getElementById('problem1clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function exchangeIfGreater() {
    var a = jsConsole.readFloat('#problem11'),
        b = jsConsole.readFloat('#problem12'),
        temp;
    if (a > b) {
        jsConsole.writeLine(a + ' is greater than ' + b);
        temp = b;
        b = a;
        a = temp;
        jsConsole.writeLine('new a = ' + a);
        jsConsole.writeLine('new b = ' + b);
    } else if (a == b) {
        jsConsole.writeLine(a + ' is equal to ' + b);
        jsConsole.writeLine('a remains ' + a);
        jsConsole.writeLine('b remains ' + b);
    } else {
        jsConsole.writeLine(a + ' is less than ' + b);
        jsConsole.writeLine('a remains ' + a);
        jsConsole.writeLine('b remains ' + b);
    }

}

/** Problem 2. Multiplication Sign

 Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.
 Examples:

 a    b    c    result
 5    2    2    +
 -2    -2    1    +
 -2    4    3    -
 0    -2.5    4    0
 -1    -0.5    -5.1    -
 */
test = document.getElementById('problem2test');
test.onclick = findMultiplicationSign;
clear = document.getElementById('problem2clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}
function sign(number) {
    return number ? number < 0 ? -1 : 1 : 0;
}

function findMultiplicationSign() {
    var a = jsConsole.readFloat('#problem21'),
        b = jsConsole.readFloat('#problem22'),
        c = jsConsole.readFloat('#problem23');
    if (a == 0 || b == 0 || c == 0) {
        jsConsole.writeLine('0');
    } else if (sign(a) == sign(b) && sign(a) == sign(c) && sign(b) == sign(c)) {
        jsConsole.writeLine(sign(a) === 1 ? '+' : '-');
    } else if ((a > 0 && b > 0) || (a > 0 && c > 0) || (b > 0 && c > 0)) {
        jsConsole.writeLine('-');
    } else {
        jsConsole.writeLine('+');
    }
}

/** Problem 3. The biggest of Three

 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 Examples:

 a    b    c    biggest
 5    2    2    5
 -2    -2    1    1
 -2    4    3    4
 0    -2.5    5    5
 -0.1    -0.5    -1.1    -0.1
 */
test = document.getElementById('problem3test');
test.onclick = findBiggestOfThree;
clear = document.getElementById('problem3clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}


function findBiggestOfThree() {
    var a = jsConsole.readFloat('#problem31'),
        b = jsConsole.readFloat('#problem32'),
        c = jsConsole.readFloat('#problem33'),
        biggest;

    if (a > b) {
        if (a > c) {
            biggest = a;
        } else {
            biggest = c;
        }

    } else if (c > b) {
        biggest = c;

    } else {
        biggest = b;
    }

    jsConsole.writeLine('The biggest number of ' + a + ', ' + b + ' and ' + c + ' is: ' + biggest);
}

/**
 Problem 4. Sort 3 numbers

 Sort 3 real values in descending order.
 Use nested if statements.
 Note: Don’t use arrays and the built-in sorting functionality.
 */
test = document.getElementById('problem4test');
test.onclick = sortThreeNumbers;
clear = document.getElementById('problem4clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function sortThreeNumbers() {
    var a = jsConsole.readFloat('#problem41'),
        b = jsConsole.readFloat('#problem42'),
        c = jsConsole.readFloat('#problem43');
    if (a > b) {
        if (a >= c) {
            if (b >= c) {
                jsConsole.writeLine(a + ', ' + b + ', ' + c);
            } else {
                jsConsole.writeLine(a + ', ' + c + ', ' + b);
            }
        } else {
            jsConsole.writeLine(c + ', ' + a + ', ' + b);
        }
    }

    if (a < b) {
        if (b >= c) {
            if (a >= c) {
                jsConsole.writeLine(b + ', ' + a + ', ' + c);
            }
            else {
                jsConsole.writeLine(b + ', ' + c + ', ' + a);
            }
        } else {
            jsConsole.writeLine(c + ', ' + b + ', ' + a);
        }

    }

    if (a == b) {
        if (a == c) {
            if (a >= c) {
                jsConsole.writeLine(a + ', ' + b + ', ' + c);
            }
        } else {
            jsConsole.writeLine(c + ', ' + a + ', ' + b);
        }

    }
}

/**
 Problem 5. Digit as word

 Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 Print “not a digit” in case of invalid input.
 Use a switch statement.
 */
test = document.getElementById('problem5test');
test.onclick = digitAsWord;
clear = document.getElementById('problem5clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function digitAsWord() {
    var d = jsConsole.read('#problem5');
    d = +d;
    switch (d) {
        case 0:
            jsConsole.writeLine('zero');
            break;
        case 1:
            jsConsole.writeLine('one');
            break;
        case 2:
            jsConsole.writeLine('two');
            break;
        case 3:
            jsConsole.writeLine('three');
            break;
        case 4:
            jsConsole.writeLine('four');
            break;
        case 5:
            jsConsole.writeLine('five');
            break;
        case 6:
            jsConsole.writeLine('six');
            break;
        case 7:
            jsConsole.writeLine('seven');
            break;
        case 8:
            jsConsole.writeLine('eight');
            break;
        case 9:
            jsConsole.writeLine('nine');
            break;

        default:
            jsConsole.writeLine('not a digit');
            break;
    }
}

/** Problem 6. Quadratic equation

 Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 Note: Quadratic equations may have 0, 1 or 2 real roots.
 Examples:

 a    b    c    roots
 2    5    -3    x1=-3; x2=0.5
 -1    3    0    x1=3; x2=0
 -0.5    4    -8    x1=x2=4
 5    2    8    no real roots
 */
test = document.getElementById('problem6test');
test.onclick = calculateQuadraticEquation;
clear = document.getElementById('problem6clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function calculateQuadraticEquation() {
    var a = jsConsole.readFloat('#problem61'),
        b = jsConsole.readFloat('#problem62'),
        c = jsConsole.readFloat('#problem63'),
        firstRoot,
        secondRoot,
        discriminant = (b * b) - (4 * a * c);

    if (discriminant >= 0) {
        firstRoot = (-b - Math.sqrt(discriminant)) / (2 * a);
        secondRoot = (-b + Math.sqrt(discriminant)) / (2 * a);
        if (firstRoot == secondRoot) {
            jsConsole.writeLine('The equation ' + a + 'x^2 + ' + b + 'x + ' + c + ' = 0 has one root: x = ' + firstRoot + '.');
        }
        else {
            jsConsole.writeLine('The equation ' + a + 'x^2 + ' + b + 'x + ' + c + ' = 0 has two roots: x1 = ' + firstRoot + ' and x2 = ' + secondRoot + '.');
        }
    }

    else {
        jsConsole.writeLine('The equation ' + a + 'x^2 + ' + b + 'x + ' + c + ' = 0 has no real roots.');
    }

}

/** Problem 7. The biggest of five numbers

 Write a script that finds the greatest of given 5 variables.
 Use nested if statements.
 Examples:

 a    b    c    d    e    biggest
 5    2    2    4    1    5
 -2    -22    1    0    0    1
 -2    4    3    2    0    4
 0    -2.5    0    5    5    5
 -3    -0.5    -1.1    -2    -0.1    -0.1
 */
test = document.getElementById('problem7test');
test.onclick = findBiggestOfFive;
clear = document.getElementById('problem7clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function findBiggestOfFive() {
    var a = jsConsole.readFloat('#problem71'),
        b = jsConsole.readFloat('#problem72'),
        c = jsConsole.readFloat('#problem73'),
        d = jsConsole.readFloat('#problem74'),
        e = jsConsole.readFloat('#problem75'),
        biggest = null;

    /** solving using nested ifs as stated in the problem */
    if (a >= b) {
        if (a >= c) {
            if (a >= d) {
                if (a >= e) {
                    biggest = a;
                }
            }
        }
    }

    if (b >= a) {
        if (b >= c) {
            if (b >= d) {
                if (b >= e) {
                    biggest = b;
                }
            }

        }
    }

    if (c >= a) {
        if (c >= b) {
            if (c >= d) {
                if (c >= e) {
                    biggest = c;
                }
            }

        }
    }

    if (d >= a) {
        if (d >= b) {
            if (d >= c) {
                if (d >= e) {
                    biggest = d;
                }
            }

        }
    }

    if (e >= a) {
        if (e >= b) {
            if (e >= c) {
                if (e >= d) {
                    biggest = e;
                }
            }

        }
    }
    jsConsole.writeLine('The biggest number is: ' + biggest);
}

/**Problem 8. Number as words

 Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
 Examples:

 numbers    number as words
 0    Zero
 9    Nine
 10    Ten
 12    Twelve
 19    Nineteen
 25    Twenty five
 98    Ninety eight
 98    Ninety eight
 273    Two hundred and seventy three
 400    Four hundred
 501    Five hundred and one
 617    Six hundred and seventeen
 711    Seven hundred and eleven
 999    Nine hundred and ninety nine
 */
test = document.getElementById('problem8test');
test.onclick = numberAsWord;
clear = document.getElementById('problem8clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function numberAsWord() {
    var number = jsConsole.readInteger('#problem8'),
        number = +number,
        firstDigit = Math.floor(number / 100) % 10,
        secondDigit = Math.floor(number / 10) % 10,
        thirdDigit = number % 10;

    switch (firstDigit) {
        case 1:
            jsConsole.write('One ');
            break;
        case 2:
            jsConsole.write('Two ');
            break;
        case 3:
            jsConsole.write('Three ');
            break;
        case 4:
            jsConsole.write('Four ');
            break;
        case 5:
            jsConsole.write('Five ');
            break;
        case 6:
            jsConsole.write('Six ');
            break;
        case 7:
            jsConsole.write('Seven ');
            break;
        case 8:
            jsConsole.write('Eight ');
            break;
        case 9:
            jsConsole.write('Nine ');
            break;
    }

    if (firstDigit != 0) {
        jsConsole.write('hundred ');
        if (secondDigit != 0 || thirdDigit != 0) {
            jsConsole.write('and ');
        }
    }

    if (secondDigit == 1) {
        switch (thirdDigit) {
            case 0:
                if (number == 10) jsConsole.write('Ten');
                else
                    jsConsole.write('ten');
                break;
            case 1:

                if (number == 11) jsConsole.write('Eleven');
                else
                    jsConsole.write('eleven');
                break;
            case 2:
                if (number == 12) jsConsole.write('Twelve');
                else
                    jsConsole.write('twelve');
                break;
            case 3:
                if (number == 13) jsConsole.write('Thirteen');
                else
                    jsConsole.write('thirteen');
                break;
            case 4:
                if (number == 14) jsConsole.write('Fourteen');
                else
                    jsConsole.write('fourteen');
                break;
            case 5:
                if (number == 15) jsConsole.write('Fifteen');
                else
                    jsConsole.write('fifteen');
                break;
            case 6:
                if (number == 16) jsConsole.write('Sixteen');
                else
                    jsConsole.write('sixteen');
                break;
            case 7:
                if (number == 17) jsConsole.write('Seventeen');
                else
                    jsConsole.write('seventeen');
                break;
            case 8:
                if (number == 18) jsConsole.write('Eighteen');
                else
                    jsConsole.write('eighteen');
                break;
            case 9:
                if (number == 19) jsConsole.write('Nineteen');
                else
                    jsConsole.write('nineteen');
                break;
        }
    }

    else {
        switch (secondDigit) {
            case 2:
                if (number >= 20 && number < 30) jsConsole.write('Twenty ');
                else
                    jsConsole.write('twenty ');
                break;
            case 3:
                if (number >= 30 && number < 40) jsConsole.write('Thirty ');
                else
                    jsConsole.write('thirty ');
                break;
            case 4:
                if (number >= 40 && number < 50) jsConsole.write('Forty ');
                else
                    jsConsole.write('forty ');
                break;
            case 5:
                if (number >= 50 && number < 60) jsConsole.write('Fifty ');
                else
                    jsConsole.write('fifty ');
                break;
            case 6:
                if (number >= 60 && number < 70) jsConsole.write('Sixty ');
                else
                    jsConsole.write('sixty ');
                break;
            case 7:
                if (number >= 70 && number < 80) jsConsole.write('Seventy ');
                else
                    jsConsole.write('seventy ');
                break;
            case 8:
                if (number >= 80 && number < 90) jsConsole.write('Eighty ');
                else
                    jsConsole.write('eighty ');
                break;
            case 9:
                if (number >= 90 && number < 100) jsConsole.write('Ninety ');
                else
                    jsConsole.write('ninety ');
                break;
        }

    }

    if (secondDigit != 1) {
        switch (thirdDigit) {
            case 0:
                if (firstDigit == 0 && secondDigit == 0) jsConsole.write('Zero');
                break;
            case 1:
                if (firstDigit == 0 && secondDigit == 0) jsConsole.write('One');
                else
                    jsConsole.write('one');
                break;
            case 2:
                if (firstDigit == 0 && secondDigit == 0) jsConsole.write('Two');
                else
                    jsConsole.write('two');
                break;
            case 3:
                if (firstDigit == 0 && secondDigit == 0) jsConsole.write('Three');
                else
                    jsConsole.write('three');
                break;
            case 4:
                if (firstDigit == 0 && secondDigit == 0) jsConsole.write('Four');
                else
                    jsConsole.write('four');
                break;
            case 5:
                if (firstDigit == 0 && secondDigit == 0) jsConsole.write('Five');
                else
                    jsConsole.write('five');
                break;
            case 6:
                if (firstDigit == 0 && secondDigit == 0) jsConsole.write('Six');
                else
                    jsConsole.write('six');
                break;
            case 7:
                if (firstDigit == 0 && secondDigit == 0) jsConsole.write('Seven');
                else
                    jsConsole.write('seven');
                break;
            case 8:
                if (firstDigit == 0 && secondDigit == 0) jsConsole.write('Eight');
                else
                    jsConsole.write('eight');
                break;
            case 9:
                if (firstDigit == 0 && secondDigit == 0) jsConsole.write('Nine');
                else
                    jsConsole.write('nine');
                break;
        }
    }

    jsConsole.writeLine();
}
