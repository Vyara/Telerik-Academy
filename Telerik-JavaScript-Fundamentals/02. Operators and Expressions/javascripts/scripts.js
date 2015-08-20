(function () {
    function createJsConsole(selector) {
        var self = this;
        //var consoleElement = document.querySelector(selector);
        var consoleElement = document.getElementById(selector);

        if (consoleElement.className) {
            consoleElement.className = consoleElement.className + " js-console";
        } else {
            consoleElement.className = "js-console";
        }

        var textArea = document.createElement("p");
        consoleElement.appendChild(textArea);

        self.write = function jsConsoleWrite(text) {
            var textLine = document.createElement("span");
            if (text !== "" && text !== undefined) {
                var toWrite = text.toString();
                textLine.innerHTML = toWrite;
                textArea.appendChild(textLine);
                consoleElement.scrollTop = consoleElement.scrollHeight;
            }
        };

        self.writeLine = function jsConsoleWriteLine(text) {
            self.write(text);
            textArea.appendChild(document.createElement("br"));
        };

        self.read = function readText(inputSelector) {
            var element = document.querySelector(inputSelector);
            if (element.innerHTML) {
                return element.innerHTML;
            } else {
                return element.value;
            }
        };

        self.readInteger = function readInteger(inputSelector) {
            var text = self.read(inputSelector);
            return parseInt(text, 10);
        };

        self.readFloat = function readFloat(inputSelector) {
            var text = self.read(inputSelector);
            return parseFloat(text);
        };

        self.clearConsole = function clearConsole() {
            textArea.innerHTML = "";
        };

        return self;
    }
    jsConsole = new createJsConsole("js-console");
}).call(this);

/**previous , next problem visualization
 */

var previousButton = document.getElementById('previous');
    nextButton = document.getElementById('next');
nextButton.onclick = next;
previousButton.onclick = previous;

count = 1;
function next(){
    if(count < 9){
        document.getElementById('article' + count).style.display = "none";
        count++;
       document.getElementById('article' + count).style.display = "block";
        jsConsole.clearConsole();
    }

}
function previous() {
    if (count > 1) {
        document.getElementById('article' + count).style.display = "none";
        count--;
        document.getElementById('article' + count).style.display = "block";
        jsConsole.clearConsole();
    }
}

/**Problem 1. Odd or Even
 *

Write an expression that checks if given integer is odd or even.
    Examples:

n	Odd?
 3	true
2	false
-2	false
-1	true
0	false
*/
var test = document.getElementById('problem1test');
test.onclick = checkIfOddOrEven;
var clear = document.getElementById('problem1clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function checkIfOddOrEven(){
    var number = jsConsole.readInteger('#problem1');
    if(number % 2 == 0){
        jsConsole.writeLine('The number ' + number + ' is even.');
    }
    else{
        jsConsole.writeLine('The number ' + number + ' is odd.')
    }


}

/**Problem 2. Divisible by 7 and 5

 Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
 Examples:

 n	Divided by 7 and 5?
 3	false
 0	true
 5	false
 7	false
 35	true
 140	true
 */

test = document.getElementById('problem2test');
test.onclick = divideBySevenAndFive;
clear = document.getElementById('problem2clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function divideBySevenAndFive(){
    var number = jsConsole.readInteger('#problem2');
    if(number % 7 == 0 && number % 5 == 0){
        jsConsole.writeLine('The number ' + number + ' is divisible by seven and by five.');
    }
    else if(number % 7 == 0 && !(number % 5 == 0)){
        jsConsole.writeLine('The number ' + number + ' is divisible by seven, but NOT by five.');
    }

    else if(number % 5 == 0 && !(number % 7 == 0)){
        jsConsole.writeLine('The number ' + number + ' is divisible by five, but NOT by seven.');
    }

    else{
        jsConsole.writeLine('The number ' + number + ' is NOT divisible by seven and by five.');
    }
}

/**Problem 3. Rectangle area

 Write an expression that calculates rectangle’s area by given width and height.
 Examples:

 width	height	area
 3	4	12
 2.5	3	7.5
 5	5	25
 */
test = document.getElementById('problem3test');
test.onclick = rectangleArea;
clear = document.getElementById('problem3clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function rectangleArea () {
    var width = jsConsole.readFloat('#problem31');
        height = jsConsole.readFloat('#problem32');
        area = width * height;
    jsConsole.writeLine('The area of a rectangle with width ' + width + ' and height ' + height + ' is ' + area + '.');

}

/** Problem 4. Third digit

 Write an expression that checks for given integer if its third digit (right-to-left) is 7.
 Examples:

 n	Third digit 7?
 5	false
 701	true
 1732	true
 9703	true
 877	false
 777877	false
 9999799	true
 */
test = document.getElementById('problem4test');
test.onclick = thirdDigitSeven;
clear = document.getElementById('problem4clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function thirdDigitSeven (){
    var number = jsConsole.readInteger('#problem4');
        isThird = ((number / 100 |0) % 10) == 7;
    if(isThird){
        jsConsole.writeLine('The third digit of the number ' + number + ' is seven.')
    }

    else{
        jsConsole.writeLine('The third digit of the number ' + number + ' is NOT seven.')
    }
}

/**Problem 5. Third bit

 Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
 The bits are counted from right to left, starting from bit #0.
 The result of the expression should be either 1 or 0.
 Examples:

 n	binary representation	bit #3
 5	00000000 00000101	0
 8	00000000 00001000	1
 0	00000000 00000000	0
 15	00000000 00001111	1
 5343	00010100 11011111	1
 62241	11110011 00100001	0
 */
test = document.getElementById('problem5test');
test.onclick = thirdBit;
clear = document.getElementById('problem5clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function thirdBit (){
    var number = jsConsole.readInteger('#problem5');
        binaryNumber = number.toString(2);
        p = 3;
        mask = 1 << p;
        numberAndMask = number & mask;
        bit = numberAndMask >> p;
        jsConsole.writeLine('Number: ' + number);
        jsConsole.writeLine('Binary representation: ' + binaryNumber);
        jsConsole.writeLine('Bit #3: ' + bit);
}


/**Problem 6. Point in Circle

 Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
 Examples:

 x	y	inside
 0	1	true
 -5	0	true
 -4	5	false
 1.5	-3	true
 -4	-3.5	false
 100	-30	false
 0	0	true
 0.2	-0.8	true
 0.9	-4.93	false
 2	2.655	true
 */
test = document.getElementById('problem6test');
test.onclick = pointInCircle;
clear = document.getElementById('problem6clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function pointInCircle (){
    var x = jsConsole.readFloat('#problem61');
        y = jsConsole.readFloat('#problem62');
        isInside = (Math.pow(x, 2)) + (Math.pow(y, 2)) <= (Math.pow(5, 2));
        if(isInside){
            jsConsole.writeLine('The point(' + x + ', ' + y  + ') is inside the circle K({0,0}, 5)' );
        }
    else{
            jsConsole.writeLine('The point(' + x + ', ' + y  + ') is NOT inside the circle K({0,0}, 5)' );
        }


}

/**
 Problem 7. Is prime

 Write an expression that checks if given positive integer number n (n ? 100) is prime.
 Examples:

 n	Prime?
 1	false
 2	true
 3	true
 4	false
 9	false
 37	true
 97	true
 51	false
 -3	false
 0	false
 */
test = document.getElementById('problem7test');
test.onclick = checkIfPrime;
clear = document.getElementById('problem7clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function checkIfPrime(){
    var number = jsConsole.readInteger('#problem7');
        isPrime = true;
    if(number > 100){
        jsConsole.writeLine('The number should be <= 100.')
    }

    else{

        for(var i = 2; i <= Math.sqrt(number); i++){
            if(number % i == 0){
               isPrime = false;
            }
        }

        if(number == 1 || number <= 0){
            isPrime = false;
        }

        if(isPrime){

            jsConsole.writeLine('The number ' + number + ' is prime.')
        }

        else{
            jsConsole.writeLine('The number '  + number + ' is NOT prime.')
        }
    }
}

/**
 Problem 8. Trapezoid area

 Write an expression that calculates trapezoid's area by given sides a and b and height h.
 Examples:

 a	b	h	area
 5	7	12	72
 2	1	33	49.5
 8.5	4.3	2.7	17.28
 100	200	300	45000
 0.222	0.333	0.555	0.1540125
 */
test = document.getElementById('problem8test');
test.onclick = trapezoidArea;
clear = document.getElementById('problem8clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function trapezoidArea(){
    var a  = jsConsole.readFloat('#problem81');
        b  = jsConsole.readFloat('#problem82');
        h  = jsConsole.readFloat('#problem83');
        area = ((a + b)/ 2) * h;
    jsConsole.writeLine('The area of a trapezoid with sides ' + a + ', ' + b + ' and height ' + h + ' is ' + area + '.');

}

/**
 Problem 9. Point in Circle and outside Rectangle

 Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 Examples:

 x	y	inside K & outside of R
 1	4	yes
 3	2	yes
 0	1	no
 4	1	no
 2	0	no
 4	0	no
 2.5	1.5	yes
 3.5	1.5	yes
 -100	-100	no
 */
test = document.getElementById('problem9test');
test.onclick = InCircleOutRectangle;
clear = document.getElementById('problem9clear')

clear.onclick = function () {
    jsConsole.clearConsole();
}

function InCircleOutRectangle(){
    var x = jsConsole.readFloat('#problem91');
        y = jsConsole.readFloat('#problem92');
        isInCircle  = (Math.pow((x - 1), 2)) + (Math.pow((y - 1), 2)) <= (Math.pow(3, 2));
        isOutRec = (y > 1 || y < -1 || x < -1 || x > 5);
        inAndout = isInCircle && isOutRec;
    if(inAndout){
        jsConsole.writeLine('The point(' + x + ', ' + y  + ') is inside the circle K({1,1}, 3) and out of the rectangle R(top=1, left=-1, width=6, height=2). ' )

    }

    else if(isInCircle){
        jsConsole.writeLine('The point(' + x + ', ' + y  + ') is inside the circle K({1,1}, 3), BUT NOT out of the rectangle R(top=1, left=-1, width=6, height=2). ' )
    }

    else if(isOutRec){
        jsConsole.writeLine('The point(' + x + ', ' + y  + ') is  out of the rectangle R(top=1, left=-1, width=6, height=2), BUT NOT inside the circle K({1,1}, 3). ' )
    }

    else{
        jsConsole.writeLine('The point(' + x + ', ' + y  + ') is NOT inside the circle K({1,1}, 3) and NOT out of the rectangle R(top=1, left=-1, width=6, height=2). ' )
    }
}