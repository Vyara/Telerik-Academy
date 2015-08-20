/**
 Declaring variables
 */
var test,
    clear;

/** Problem 1. English digit

 Write a function that returns the last digit of given integer as an English word.
 Examples:

 input    output
 512    two
 1024    four
 12309    nine
 */
test = document.getElementById('problem1test');
test.onclick = englishDigit;
clear = document.getElementById('problem1clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function englishDigit() {
    var number = jsConsole.readInteger('#problem1'),
        lastDigit,
        lastDigitWord,
        result;

    function lastDigitAsWord(num) {
        lastDigit = (Math.abs(num) | 0) % 10;
        lastDigitWord = '';

        switch (lastDigit) {
            case 0:
                lastDigitWord = 'zero';
                break;
            case 1:
                lastDigitWord = 'one';
                break;
            case 2:
                lastDigitWord = 'two';
                break;
            case 3:
                lastDigitWord = 'three';
                break;
            case 4:
                lastDigitWord = 'four';
                break;
            case 5:
                lastDigitWord = 'five';
                break;
            case 6:
                lastDigitWord = 'six';
                break;
            case 7:
                lastDigitWord = 'seven';
                break;
            case 8:
                lastDigitWord = 'eight';
                break;
            case 9:
                lastDigitWord = 'nine';
                break;
        }

        return lastDigitWord;
    }

    result = lastDigitAsWord(number);
    jsConsole.writeLine('Number: ' + number);
    jsConsole.writeLine('Last digit as word: ' + result);
}

/** Problem 2. Reverse number

 Write a function that reverses the digits of given decimal number.
 Example:

 input    output
 256    652
 123.45    54.321
 */
test = document.getElementById('problem2test');
test.onclick = reverseNumber;
clear = document.getElementById('problem2clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}


function reverseNumber() {
    var number = jsConsole.readFloat('#problem2'),
        numberToString,
        reversed,
        len,
        result,
        i;

    function reverseGivenNumber(num) {
        numberToString = num.toString();
        reversed = '';
        len = numberToString.length;
        for (i = 0; i < len; i += 1) {
            reversed += numberToString[len - 1 - i];
        }

        return reversed;

    }

    result = reverseGivenNumber(number);
    jsConsole.writeLine('Number: ' + number);
    jsConsole.writeLine('Reversed: ' + result);

}

/** Problem 3. Occurrences of word

 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.
 */
test = document.getElementById('problem3test');
test.onclick = occurrencesOfWord;
clear = document.getElementById('problem3clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}


function occurrencesOfWord() {
    var inputText = jsConsole.read('#problem31'),
        inputWord = jsConsole.read('#problem32'),
        regexWord,
        regex,
        caseSensitive,
        caseInsensitive;

    function countOccurrences(text, word, caseSensitive) {
        caseSensitive = caseSensitive || 'gi';
        regexWord = '\\b' + word + '\\b';
        regex = new RegExp(regexWord, caseSensitive);
        return text.match(regex).length;

    }

    caseSensitive = countOccurrences(inputText, inputWord, 'g');
    caseInsensitive = countOccurrences(inputText, inputWord);
    jsConsole.writeLine('Word: ' + inputWord);
    jsConsole.writeLine('Occurrences(case-sensitive): ' + caseSensitive);
    jsConsole.writeLine('Occurrences(case-insensitive): ' + caseInsensitive);

}

/** Problem 4. Number of elements

 Write a function to count the number of div elements on the web page
 */
test = document.getElementById('problem4test');
test.onclick = numberOfDivs;
clear = document.getElementById('problem4clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}
function numberOfDivs() {
    var url = jsConsole.read('#problem4'),
        result,
        count;

    function numberOfElements(element) {
        count = document.getElementsByTagName(element).innerHTML = url.length;
        return count;
    }

    result = numberOfElements('div');
    jsConsole.writeLine('Number of divs on the web page: ' + result)

}

/** Problem 5. Appearance count

 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.
 */
test = document.getElementById('problem5test');
test.onclick = appearanceCountTest;
clear = document.getElementById('problem5clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function appearanceCountTest() {
    var inputArray = jsConsole.read('#problem51'),
        inputArray = inputArray.split(', '),
        len = inputArray.length,
        inputNumber = jsConsole.readFloat('#problem52'),
        count = 0,
        result,
        numberCount = 0;

    function appearanceCount(array, number) {
        var length = array.length;
        while (count < length) {
            if (array[count] == number) {
                numberCount += 1;
            }

            count += 1;

        }

        return numberCount;
    }

    result = appearanceCount(inputArray, inputNumber);
    jsConsole.writeLine('Array: ' + inputArray);
    jsConsole.writeLine('Number: ' + inputNumber);
    jsConsole.writeLine('Number of appearances: ' + result);
}

/** Problem 6. Larger than neighbours

 Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).
 */
test = document.getElementById('problem6test');
test.onclick = largerThanNeighbours;
clear = document.getElementById('problem6clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function largerThanNeighbours() {
    var inputArray = jsConsole.read('#problem61'),
        inputArray = inputArray.split(', '),
        inputPosition = jsConsole.readInteger('#problem62'),
        result,


        result = isNumberLarger(inputArray, inputPosition);
    jsConsole.writeLine('Is element at position: ' + inputPosition + ' with value: ' + inputArray[inputPosition] + ' larger than its neighbours? ');
    jsConsole.write(result ? 'YES' : 'NO');
    jsConsole.writeLine();

}

function isNumberLarger(array, position) {
    var length = array.length,
        isBigger = false,
        isBiggerThanPrevious = false,
        isBiggerThanNext = false;

    if (position - 1 >= 0) {
        if (position == length - 1) {
            isBigger = array[position] > array[position - 1];
        } else {
            isBiggerThanPrevious = array[position] > array[position - 1];
        }
    }

    if (position + 1 < length) {
        if (position == 0) {
            isBigger = array[position] > array[position + 1];
        } else {
            isBiggerThanNext = array[position] > array[position + 1];
        }
    }

    if (isBiggerThanNext && isBiggerThanPrevious) {
        isBigger = true;
    }

    return isBigger;
}

/** Problem 7. First larger than neighbours

 Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.
 */
test = document.getElementById('problem7test');
test.onclick = firstLargerThanNeighbours;
clear = document.getElementById('problem7clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function firstLargerThanNeighbours() {
    var inputArray = jsConsole.read('#problem7'),
        inputArray = inputArray.split(', '),
        result,
        count = 0;


    function fistLarger(array) {
        var length = array.length;
        while (count < length) {
            if (isNumberLarger(array, count)) {
                return count;

            }
            count += 1;
        }

        return -1;

    }

    result = fistLarger(inputArray);
    if (result !== -1) {
        jsConsole.writeLine('Element at position: ' + result + ' with value: ' + inputArray[result] + ' is the first element, that is larger than its neighbours.');
    } else {
        jsConsole.writeLine('There is no element, that is larger than its neighbours.');
    }


}


