/**
 Declaring variables
 */
var test,
    clear;

/** Problem 1. Increase array members

 Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the console.
 */
test = document.getElementById('problem1test');
test.onclick = increaseMembersBy5;
clear = document.getElementById('problem1clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function increaseMembersBy5() {
    var array = [],
        i;
    for (i = 0; i < 20; i += 1) {
        array[i] = i * 5;
    }
    jsConsole.writeLine('[' + array.join(', ') + ']');

}

/** Problem 2. Lexicographically comparison

 Write a script that compares two char arrays lexicographically (letter by letter).
 */
test = document.getElementById('problem2test');
test.onclick = compareCharArrays;
clear = document.getElementById('problem2clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}


function compareCharArrays() {
    var firstArray = [],
        secondArray = [],
        areEqual = true,
        i;

    for (i = 0; i < 3; i += 1) {
        firstArray[i] = jsConsole.read('#problem2' + (i + 1));
        secondArray[i] = jsConsole.read('#problem2' + (i + 1 + 3));

        if (firstArray[i] === secondArray[i]) {
            jsConsole.writeLine(firstArray[i] + ' = ' + secondArray[i]);
        } else if (firstArray[i] > secondArray[i]) {
            jsConsole.writeLine(firstArray[i] + ' > ' + secondArray[i]);
            areEqual = false;

        }
        else {
            jsConsole.writeLine(firstArray[i] + ' < ' + secondArray[i]);
            areEqual = false;
        }
    }

    if (areEqual) {
        jsConsole.writeLine('The arrays are equal.')
    } else {
        jsConsole.writeLine('The arrays are NOT equal.')
    }


}

/** Problem 3. Maximal sequence

 Write a script that finds the maximal sequence of equal elements in an array.
 Example:

 input    result
 2, 1, 1, 2, 3, 3, 2, 2, 2, 1    2, 2, 2
 */
test = document.getElementById('problem3test');
test.onclick = findMaxSequence;
clear = document.getElementById('problem3clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}


function findMaxSequence() {
    var array = jsConsole.read('#problem3'),
        array = array.split(', '),
        len = array.length,
        element,
        longestSequenceArray,
        temp,
        i,
        longestSequenceArray = temp = [array[0]];

    for (i = 1; i < len; i += 1) {
        if (array[i] !== temp[0]) {
            temp = [array[i]];
        } else {
            temp.push(array[i]);
        }

        if (temp.length > longestSequenceArray.length) {
            longestSequenceArray = temp;
        }
    }

    jsConsole.writeLine('Longest sequence of elements is of element: ' + longestSequenceArray[0] + ' and has ' + longestSequenceArray.length + ' elements.');
}

/** Problem 4. Maximal increasing sequence

 Write a script that finds the maximal increasing sequence in an array.
 Example:

 input    result
 3, 2, 3, 4, 2, 2, 4    2, 3,
 */
test = document.getElementById('problem4test');
test.onclick = findMaxIncreasingSequence;
clear = document.getElementById('problem4clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function findMaxIncreasingSequence() {
    var array = jsConsole.read('#problem4'),
        array = array.split(', '),
        len = array.length,
        element,
        longestSequenceArray,
        temp,
        i,
        longestSequenceArray = temp = [array[0]];

    for (i = 1; i < len; i += 1) {
        if (array[i] > array[i - 1]) {
            temp.push(array[i]);
        } else {
            temp = [array[i]];
        }

        if (temp.length > longestSequenceArray.length) {
            longestSequenceArray = temp;
        }
    }

    jsConsole.writeLine('Longest sequence of increasing elements is: ' + longestSequenceArray + ' and has ' + longestSequenceArray.length + ' elements.');
}

/** Problem 5. Selection sort

 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 Hint: Use a second array
 */
test = document.getElementById('problem5test');
test.onclick = selectionSort;
clear = document.getElementById('problem5clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function selectionSort() {
    var array = jsConsole.read('#problem5'),
        array = array.split(', '),
        len = array.length,
        temp,
        i,
        j;

    for (i = 0; i < len; i += 1) {
        for (j = i + 1; j < len; j += 1) {
            if (j < len) {
                if (array[i] > array[j]) {
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
    }


    jsConsole.writeLine('Sorted array: ' + array);


}

/** Problem 6. Most frequent number

 Write a script that finds the most frequent number in an array.
 Example:

 input    result
 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3    4 (5 times)
 */
test = document.getElementById('problem6test');
test.onclick = mostFrequentNumber;
clear = document.getElementById('problem6clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function mostFrequentNumber() {
    var array = jsConsole.read('#problem6'),
        array = array.split(', '),
        len = array.length,
        mostFrequentNum = 0,
        currentNum = 0,
        currentCount = 1,
        bestCount = 0,
        i,
        j;
    for (i = 0; i < len; i += 1) {
        currentNum = array[i];
        if (i + 1 < len) {
            for (j = i + 1; j < len; j += 1) {
                if (array[j] == currentNum) {
                    currentCount += 1;
                }
            }
            if (currentCount > bestCount) {
                bestCount = currentCount;
                mostFrequentNum = currentNum;
            }
            currentCount = 1;
        }
    }

    if (bestCount == 1) {
        jsConsole.writeLine('All elements appear once.');
    } else {
        jsConsole.writeLine('Most frequent number: ' + mostFrequentNum);
        jsConsole.writeLine('Number of appearances: ' + bestCount);
    }

}

/** Problem 7. Binary search

 Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
 */
test = document.getElementById('problem7test');
test.onclick = binarySearch;
clear = document.getElementById('problem7clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function binarySearch() {
    var array = jsConsole.read('#problem71'),
        array = array.split(', '),
        sortedArray = array.map(Number).sort(),
        len = sortedArray.length,
        mid,
        min = 0,
        max = len - 1,
        targetElement = jsConsole.readFloat('#problem72'),
        currentElement;

    while (min <= max) {
        mid = (min + max) / 2  | 0;
        currentElement = sortedArray[mid];

        if (currentElement < targetElement) {
            min = mid + 1;
        } else if (currentElement > targetElement) {
            max = mid - 1;
        } else  {
            jsConsole.writeLine('Sorted array: ' + sortedArray);
            jsConsole.writeLine('Element ' + targetElement + ' was found at index ' + mid);
            return;
        }

    }

    jsConsole.writeLine('Element ' + targetElement + ' was not found in the array.');


}


