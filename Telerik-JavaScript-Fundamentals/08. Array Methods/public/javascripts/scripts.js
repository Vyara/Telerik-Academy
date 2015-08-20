/**
 Declaring variables
 */
var test,
    clear;

/* Problem 1. Make person

 Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
 */
test = document.getElementById('problem1test');
test.onclick = makePerson;
clear = document.getElementById('problem1clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function makePerson() {
    var people,
        i,
        gender,
        peopleArray,
        genderValue;


    function Person(firstname, lastname, age, gender) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
        this.gender = gender;
    }

    function generatePeopleArray(numberOfPeople) {
        people = [];
        for (i = 0; i < numberOfPeople; i += 1) {

            gender = document.getElementById("problem1" + (i + 1) + "4");
            genderValue = gender.options[gender.selectedIndex].value;

            people.push(new Person(jsConsole.read('#problem1' + (i + 1) + '1'),
                jsConsole.read('#problem1' + (i + 1) + '2'),
                jsConsole.read('#problem1' + (i + 1) + '3'),
                genderValue));
        }
        return people;
    }

    peopleArray = generatePeopleArray(10);

    peopleArray.forEach(function (person) {
            jsConsole.write(person.firstname + ' ' + person.lastname + ' ' + person.age + ' ');
            if (person.gender == 'true') {
                person.gender = true;
                jsConsole.write('female');
            } else {
                person.gender = false;
                jsConsole.write('male');
            }
            jsConsole.writeLine();
        }
    )
}

/* Problem 2. People of age

 Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 Use only array methods and no regular loops (for, while)
 */
test = document.getElementById('problem2test');
test.onclick = peopleOfAge;
clear = document.getElementById('problem2clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};


function peopleOfAge() {
    /*var people = [
     new Person(jsConsole.read('#problem111'), jsConsole.read('#problem112'), jsConsole.read('#problem113'), jsConsole.read('#problem114')),
     new Person(jsConsole.read('#problem121'), jsConsole.read('#problem122'), jsConsole.read('#problem123'), jsConsole.read('#problem124')),
     new Person(jsConsole.read('#problem131'), jsConsole.read('#problem132'), jsConsole.read('#problem133'), jsConsole.read('#problem134')),
     new Person(jsConsole.read('#problem141'), jsConsole.read('#problem142'), jsConsole.read('#problem143'), jsConsole.read('#problem144')),
     new Person(jsConsole.read('#problem151'), jsConsole.read('#problem152'), jsConsole.read('#problem153'), jsConsole.read('#problem154')),
     new Person(jsConsole.read('#problem161'), jsConsole.read('#problem162'), jsConsole.read('#problem163'), jsConsole.read('#problem164')),
     new Person(jsConsole.read('#problem171'), jsConsole.read('#problem172'), jsConsole.read('#problem173'), jsConsole.read('#problem174')),
     new Person(jsConsole.read('#problem181'), jsConsole.read('#problem182'), jsConsole.read('#problem183'), jsConsole.read('#problem184')),
     new Person(jsConsole.read('#problem191'), jsConsole.read('#problem192'), jsConsole.read('#problem193'), jsConsole.read('#problem194')),
     new Person(jsConsole.read('#problem161'), jsConsole.read('#problem162'), jsConsole.read('#problem163'), jsConsole.read('#problem164'))
     ], */
    var arePeopleOfAge,
        people,
        i,
        gender,
        peopleArray,
        genderValue;


    function Person(firstname, lastname, age, gender) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
        this.gender = gender;
    }

    function generatePeopleArray(numberOfPeople) {
        people = [];
        for (i = 0; i < numberOfPeople; i += 1) {

            gender = document.getElementById("problem1" + (i + 1) + "4");
            genderValue = gender.options[gender.selectedIndex].value;

            people.push(new Person(jsConsole.read('#problem1' + (i + 1) + '1'),
                jsConsole.read('#problem1' + (i + 1) + '2'),
                jsConsole.read('#problem1' + (i + 1) + '3'),
                genderValue));
        }
        return people;
    }

    peopleArray = generatePeopleArray(10);

    peopleArray.forEach(function (person) {
            jsConsole.write(person.firstname + ' ' + person.lastname + ' ' + person.age + ' ');
            if (person.gender == 'true') {
                person.gender = true;
                jsConsole.write('female');
            } else {
                person.gender = false;
                jsConsole.write('male');
            }
            jsConsole.writeLine();
        }
    );

    arePeopleOfAge = peopleArray.every(function (person) {
        return person.age >= 18;
    });

    jsConsole.writeLine();
    jsConsole.writeLine('Are all people 18 years of age or more?');
    jsConsole.writeLine(arePeopleOfAge ? 'Yes' : 'No');


}

/* Problem 3. Underage people

 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
 */
test = document.getElementById('problem3test');
test.onclick = underAgePeople;
clear = document.getElementById('problem3clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};


function underAgePeople() {

    var people,
        i,
        gender,
        peopleArray,
        genderValue;


    function Person(firstname, lastname, age, gender) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
        this.gender = gender;
    }

    function generatePeopleArray(numberOfPeople) {
        people = [];
        for (i = 0; i < numberOfPeople; i += 1) {

            gender = document.getElementById("problem1" + (i + 1) + "4");
            genderValue = gender.options[gender.selectedIndex].value;

            people.push(new Person(jsConsole.read('#problem1' + (i + 1) + '1'),
                jsConsole.read('#problem1' + (i + 1) + '2'),
                jsConsole.read('#problem1' + (i + 1) + '3'),
                genderValue));
        }
        return people;
    }

    peopleArray = generatePeopleArray(10);

    peopleArray.forEach(function (person) {
            jsConsole.write(person.firstname + ' ' + person.lastname + ' ' + person.age + ' ');
            if (person.gender == 'true') {
                person.gender = true;
                jsConsole.write('female');
            } else {
                person.gender = false;
                jsConsole.write('male');
            }
            jsConsole.writeLine();
        }
    );

    jsConsole.writeLine();
    jsConsole.writeLine('Underage people: ');

    peopleArray.filter(function (person) {
        return person.age < 18;
    })
        .forEach(function (person) {
            jsConsole.write(person.firstname + ' ' + person.lastname + ' ' + person.age + ' ');
            if (person.gender == true) {
                jsConsole.write('female');
            } else {

                jsConsole.write('male');
            }
            jsConsole.writeLine();
        });

}

/* Problem 4. Average age of females

 Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)
 */
test = document.getElementById('problem4test');
test.onclick = FemaleAverageAge;
clear = document.getElementById('problem4clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};
function FemaleAverageAge() {

    var people,
        i,
        gender,
        peopleArray,
        genderValue,
        females,
        sum,
        average;


    function Person(firstname, lastname, age, gender) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
        this.gender = gender;
    }

    function generatePeopleArray(numberOfPeople) {
        people = [];
        for (i = 0; i < numberOfPeople; i += 1) {

            gender = document.getElementById("problem1" + (i + 1) + "4");
            genderValue = gender.options[gender.selectedIndex].value;

            people.push(new Person(jsConsole.read('#problem1' + (i + 1) + '1'),
                jsConsole.read('#problem1' + (i + 1) + '2'),
                jsConsole.read('#problem1' + (i + 1) + '3'),
                genderValue));
        }
        return people;
    }

    peopleArray = generatePeopleArray(10);

    peopleArray.forEach(function (person) {
            jsConsole.write(person.firstname + ' ' + person.lastname + ' ' + person.age + ' ');
            if (person.gender == 'true') {
                person.gender = true;
                jsConsole.write('female');
            } else {
                person.gender = false;
                jsConsole.write('male');
            }
            jsConsole.writeLine();
        }
    );


    females = peopleArray.filter(function (person) {
        return person.gender
    });
    sum = females.reduce(function (sum, person) {
        return sum + +person.age;
    }, 0);
    average = sum / females.length;

    jsConsole.writeLine();
    jsConsole.writeLine('Females: ');

    females.forEach(function (person) {
        jsConsole.write(person.firstname + ' ' + person.lastname + ' ' + person.age + ' ');
        if (person.gender == true) {
            jsConsole.write('female');
        } else {

            jsConsole.write('male');
        }
        jsConsole.writeLine();
    });
    jsConsole.writeLine('Average age of females: ' + average);

}


/* Problem 5. Youngest person

 Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */
test = document.getElementById('problem5test');
test.onclick = youngestMalePerson;
clear = document.getElementById('problem5clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function youngestMalePerson() {
    var people,
        i,
        gender,
        peopleArray,
        genderValue,
        youngest;


    function Person(firstname, lastname, age, gender) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
        this.gender = gender;
    }

    function generatePeopleArray(numberOfPeople) {
        people = [];
        for (i = 0; i < numberOfPeople; i += 1) {

            gender = document.getElementById("problem1" + (i + 1) + "4");
            genderValue = gender.options[gender.selectedIndex].value;

            people.push(new Person(jsConsole.read('#problem1' + (i + 1) + '1'),
                jsConsole.read('#problem1' + (i + 1) + '2'),
                jsConsole.read('#problem1' + (i + 1) + '3'),
                genderValue));
        }
        return people;
    }

    peopleArray = generatePeopleArray(10);

    peopleArray.forEach(function (person) {
            jsConsole.write(person.firstname + ' ' + person.lastname + ' ' + person.age + ' ');
            if (person.gender == 'true') {
                person.gender = true;
                jsConsole.write('female');
            } else {
                person.gender = false;
                jsConsole.write('male');
            }
            jsConsole.writeLine();
        }
    );


    if (!Array.prototype.find) {
        Array.prototype.find = function (callback) {
            var i, len = this.length;
            for (i = 0; i < len; i += 1) {
                if (callback(this[i], i, this)) {
                    return this[i];
                }
            }
        }
    }

    youngest = peopleArray.sort(function (a, b) {
        return a.age - b.age;
    })
        .find(function (person) {
            return !person.gender;
        });

    jsConsole.writeLine();
    jsConsole.write('Youngest male: ');
    jsConsole.write(youngest.firstname + ' ' + youngest.lastname);

}

/* Problem 6. Group people

 Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)
 Example:
 */

test = document.getElementById('problem6test');
test.onclick = groupPeople;
clear = document.getElementById('problem6clear');

clear.onclick = function () {
    jsConsole.clearConsole();
};

function groupPeople() {
    var people,
        i,
        gender,
        peopleArray,
        genderValue,
        groupsOfPeople,
        result;


    function Person(firstname, lastname, age, gender) {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
        this.gender = gender;
    }

    function generatePeopleArray(numberOfPeople) {
        people = [];
        for (i = 0; i < numberOfPeople; i += 1) {

            gender = document.getElementById("problem1" + (i + 1) + "4");
            genderValue = gender.options[gender.selectedIndex].value;

            people.push(new Person(jsConsole.read('#problem1' + (i + 1) + '1'),
                jsConsole.read('#problem1' + (i + 1) + '2'),
                jsConsole.read('#problem1' + (i + 1) + '3'),
                genderValue));
        }
        return people;
    }

    peopleArray = generatePeopleArray(10);

    peopleArray.forEach(function (person) {
            jsConsole.write(person.firstname + ' ' + person.lastname + ' ' + person.age + ' ');
            if (person.gender == 'true') {
                person.gender = true;
                jsConsole.write('female');
            } else {
                person.gender = false;
                jsConsole.write('male');
            }
            jsConsole.writeLine();
        }
    );
    groupsOfPeople = peopleArray.reduce(function (group, person) {
        var letter = person.firstname[0];

        if (group[letter]) {
            group[letter].push(person);
        } else {
            group[letter] = [person];
        }

        return group;
    }, {});
    jsConsole.writeLine('Grouped by name\'s first letter: ');

    result = JSON.stringify(groupsOfPeople);
    jsConsole.writeLine(result);

}


