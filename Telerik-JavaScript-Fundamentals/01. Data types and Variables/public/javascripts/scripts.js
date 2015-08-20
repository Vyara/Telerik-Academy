/**
 Problem 1. JavaScript literals

 Assign all the possible JavaScript literals to different variables.

 Problem 3. Typeof variables

 Try typeof on all variables you created.

 Problem 4. Typeof null

 Create null, undefined variables and try typeof on them.

 */

var integer = 3,
    floatingPoint = 3.14,
    string = 'I am a sentence!',
    array = [4, 'a', 2.15],
    bool = true,
    nullVal = null,
    notANumber = NaN,
    undef = undefined,
    object = {name: 'John', age: 26},
    variables = [integer, floatingPoint, string, array, bool, nullVal, notANumber, undef, object];

console.log('Problem 1. JavaScript literals: Assign all the possible JavaScript literals to different variables.');
console.log('Problem 3. Typeof variables: Try typeof on all variables you created.');
console.log('Problem 4. Typeof null:  Create null, undefined variables and try typeof on them.');

for(var variable in variables){
    console.log(variables[variable] + ' is a ' + typeof variables[variable]);
}


/**
 Problem 2. Quoted text

 Create a string variable with quoted text in it.
 For example: `'How you doin'?', Joey said'.
 */

console.log('Problem 2. Quoted text: Create a string variable with quoted text in it.');
string = ' \'How you doin\'?\', Joey said';
console.log(string);