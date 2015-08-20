function solve(params) {
    var s = +params[0];
    var count = 0;
    // Your solution here
    var cars = 4;
    var trucks = 10;
    var trikes = 3;
    var all;
    for (var i = 0; i <= (s / cars) + 1; i += 1) {
        for (var j = 0; j <= (s / trucks) + 1; j += 1) {
            for (var k = 0; k <= (s / trikes) + 1; k += 1) {
                all = (i * cars) + (j * trucks) + (k * trikes);
                if (all === s) {
                    count += 1;
                }
            }
        }
    }
    return count;
}

console.log(solve('7'));