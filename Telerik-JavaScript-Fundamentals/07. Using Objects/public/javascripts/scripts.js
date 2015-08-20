/**
 Declaring variables
 */
var test,
    clear;

/** Problem 1. Planar coordinates

 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.
 */
test = document.getElementById('problem1test');
test.onclick = planarCoordinates;
clear = document.getElementById('problem1clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function planarCoordinates() {
    debugger;
    var point1 = new Point(jsConsole.readFloat('#problem11'), jsConsole.readFloat('#problem12')),
        point2 = new Point(jsConsole.readFloat('#problem13'), jsConsole.readFloat('#problem14')),
        point3 = new Point(jsConsole.readFloat('#problem15'), jsConsole.readFloat('#problem16')),
        point4 = new Point(jsConsole.readFloat('#problem17'), jsConsole.readFloat('#problem18')),
        point5 = new Point(jsConsole.readFloat('#problem19'), jsConsole.readFloat('#problem110')),
        point6 = new Point(jsConsole.readFloat('#problem111'), jsConsole.readFloat('#problem112')),
        line1 = new Line(point1, point2),
        line2 = new Line(point3, point4),
        line3 = new Line(point5, point6);

    function Point(x, y) {
        this.x = x;
        this.y = y;
        this.visualisePoint = function () {
            return 'P(' + this.x + ', ' + this.y + ')';
        };
    }

    function Line(p1, p2) {
        this.start = p1;
        this.end = p2;
        this.lineLenght = calculateDistanceBetweenPoints(this.start, this.end);
        this.visualiseLine = function () {
            return 'L(' + this.start.visualisePoint() + ', ' + this.end.visualisePoint() + ')';
        };
    }

    function calculateDistanceBetweenPoints(p1, p2) {
        var dx = p2.x - p1.x,
            dy = p2.y - p1.y;

        return Math.sqrt((dx * dx) + (dy * dy)).toFixed(5);

    }

    function isTriangle(a, b, c) {
        return ((a.lineLenght + b.lineLenght) > c.lineLenght) ||
            ((a.lineLenght + c.lineLenght) > b.lineLenght) ||
            ((b.lineLenght + c.lineLenght) > a.lineLenght);
    }

    jsConsole.writeLine('Point1: ' + point1.visualisePoint());
    jsConsole.writeLine('Point2: ' + point2.visualisePoint());
    jsConsole.writeLine('Point3: ' + point3.visualisePoint());
    jsConsole.writeLine('Point4: ' + point4.visualisePoint());
    jsConsole.writeLine('Point5: ' + point5.visualisePoint());
    jsConsole.writeLine('Point6: ' + point6.visualisePoint());
    jsConsole.writeLine();
    jsConsole.writeLine('Line1: ' + line1.visualiseLine());
    jsConsole.writeLine('Line2: ' + line2.visualiseLine());
    jsConsole.writeLine('Line3: ' + line3.visualiseLine());
    jsConsole.writeLine();
    jsConsole.writeLine('Distance between Point1 and Point2: ' + line1.lineLenght);
    jsConsole.writeLine('Distance between Point3 and Point4: ' + line2.lineLenght);
    jsConsole.writeLine('Distance between Point5 and Point6: ' + line3.lineLenght);
    jsConsole.writeLine();
    jsConsole.writeLine('Can Line1, Line2 and Line3 form a triangle? ');
    jsConsole.writeLine(isTriangle(line1, line2, line3) ? 'YES' : 'NO');

}

/** Problem 2. Remove elements

 Write a function that removes all elements with a given value.
 Attach it to the array type.
 Read about prototype and how to attach methods.

 var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
 arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];
 */
test = document.getElementById('problem2test');
test.onclick = removeElements;
clear = document.getElementById('problem2clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};


function removeElements() {
    var array = jsConsole.read('#problem21'),
        array = array.split(','),
        elementToRemove = jsConsole.read('#problem22'),
        result;

    Array.prototype.remove = function (value) {
        var len = this.length,
            i;
        for (i = 0; i < len; i += 1) {
            if (this[i] === value) {
                this.splice(i, 1);
                i -= 1;
                len -= 1;
            }
        }

        return this;
    }

    jsConsole.writeLine('Array: ' + array);
    array = array.remove(elementToRemove);
    result = array;

    jsConsole.writeLine('Array with removed element: ' + elementToRemove + ': ' + result);
}

/** Problem 3. Deep copy

 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
 */
test = document.getElementById('problem3test');
test.onclick = deepCopy;
clear = document.getElementById('problem3clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};


function deepCopy() {
    debugger;
    var valueType = jsConsole.read('#problem31'),
        referenceType = jsConsole.read('#problem32'),
        referenceType = referenceType.split(','),
        valueResult,
        referenceResult;

    function copy(obj) {
        var copiedItem,
            prop;

        if (typeof obj !== 'object' || obj === null) {
            return obj;
        }

        copiedItem = obj.constructor();
        for (prop in obj) {
            copiedItem[prop] = copy(obj[prop]);
        }

        return copiedItem;

    }

    jsConsole.writeLine('Value type: ' + valueType);
    valueResult = copy(valueType);
    jsConsole.writeLine('Copied: ' + valueResult);
    valueResult += 5;
    jsConsole.writeLine('Copied + 5: ' + valueResult);
    jsConsole.writeLine('Original: ' + valueType);
    jsConsole.writeLine('Reference type: ' + referenceType);
    referenceResult = copy(referenceType);
    jsConsole.writeLine('Copied: ' + referenceResult);
    referenceResult[0] = 'foo';
    jsConsole.writeLine('Copied array with first element modified: ' + referenceResult);
    jsConsole.writeLine('Original: ' + referenceType);


}

/** Problem 4. Has property

 Write a function that checks if a given object contains a given property.

 var obj  = …;
 var hasProp = hasProperty(obj, 'length');
 */
test = document.getElementById('problem4test');
test.onclick = hasProperty;
clear = document.getElementById('problem4clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};
function hasProperty() {
    var property,
        name = jsConsole.read('#problem41'),
        age = jsConsole.read('#problem42'),
        status = jsConsole.read('#problem43'),
        propToCheck = jsConsole.read('#problem44'),
        object = {
            name: name,
            age: age,
            status: status
        };


    function hasProperty(obj, prop) {
        for (property in obj) {
            if (property === prop) {
                return true;
            }
        }

        return false;
    }

    jsConsole.writeLine('object.name: ' + name);
    jsConsole.writeLine('object.age: ' + age);
    jsConsole.writeLine('object.status: ' + status);
    jsConsole.writeLine('Does object have property: ' + propToCheck + ' ?');
    jsConsole.writeLine(hasProperty(object, propToCheck) ? 'YES' : 'NO');
}

/** Problem 5. Youngest person

 Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstname, lastname and age.

 Example:

 var people = [
 { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
 { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
 */
test = document.getElementById('problem5test');
test.onclick = youngestPerson;
clear = document.getElementById('problem5clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function youngestPerson() {
    var fn1 = jsConsole.read('#problem51'),
        ln1 = jsConsole.read('#problem52'),
        age1 = jsConsole.read('#problem53'),
        fn2 = jsConsole.read('#problem54'),
        ln2 = jsConsole.read('#problem55'),
        age2 = jsConsole.read('#problem56'),
        fn3 = jsConsole.read('#problem57'),
        ln3 = jsConsole.read('#problem58'),
        age3 = jsConsole.read('#problem59'),
        people = [
            {firstname: fn1, lastname: ln1, age: age1},
            {firstname: fn2, lastname: ln2, age: age2},
            {firstname: fn3, lastname: ln3, age: age3}
        ],
        i,
        youngest,
        len,
        result = findYoungest(people),
        minIndex = 0;


    function findYoungest(array) {
        len = array.length;
        youngest = array[0];


        for (i = 0; i < len; i += 1) {
            if (array[i].age < youngest.age) {

                youngest = array[i].age;
                minIndex = i;
            }
        }

        return array[minIndex].firstname + ' ' + array[minIndex].lastname;
    }

    jsConsole.writeLine('Youngest person is: ' + result);
}

/** Problem 6.

 Write a function that groups an array of people by age, first or last name.
 The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
 Use function overloading (i.e. just one function)

 Example:

 var people = {…};
 var groupedByFname = group(people, 'firstname');
 var groupedByAge= group(people, 'age');
 */
test = document.getElementById('problem6test');
test.onclick = groupPeople;
clear = document.getElementById('problem6clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function groupPeople() {
    var fn1 = jsConsole.read('#problem61'),
        ln1 = jsConsole.read('#problem62'),
        age1 = jsConsole.read('#problem63'),
        fn2 = jsConsole.read('#problem64'),
        ln2 = jsConsole.read('#problem65'),
        age2 = jsConsole.read('#problem66'),
        fn3 = jsConsole.read('#problem67'),
        ln3 = jsConsole.read('#problem68'),
        age3 = jsConsole.read('#problem69'),
        people = [
            {firstname: fn1, lastname: ln1, age: age1},
            {firstname: fn2, lastname: ln2, age: age2},
            {firstname: fn3, lastname: ln3, age: age3}
        ],
        i,
        grouped,
        keys,
        akey,
        group,
        groups,
        len;


    debugger;
    var byFirstName = groupBy(people, 'firstname'),
        byLastName = groupBy(people, 'lastname'),
        byAge = groupBy(people, 'age');


    function groupBy(array, key) {

        len = array.length
        grouped = {};

        for (i = 0; i < len; i += 1) {
            grouped[array[i][key]] = grouped[array[i][key]] || [array[i]];

            grouped[array[i][key]].push(array[i]);
        }


        return grouped;

    }

    jsConsole.writeLine('By firstname: ');
    for (group in byFirstName) {
        jsConsole.writeLine(group + ': ');
        jsConsole.writeLine('\t' + byFirstName[group].join('\r\n\t'));
    }

    jsConsole.writeLine('By lastname: ');
    for (group in byLastName) {
        jsConsole.writeLine(group + ': ');
        jsConsole.writeLine('\t' + byLastName[group].join('\r\n\t'));
    }

    jsConsole.writeLine('By age: ');
    for (group in byAge) {
        jsConsole.writeLine(group + ': ');
        jsConsole.writeLine('\t' + byAge[group].join('\r\n\t'));
    }

}



