function Solve(params) {
    var N = parseInt(params[0]),
        answer = 0,
        numbers = [],
        currentMax =  -2000000000,
        i,
        j,
        k;
    for (var i = 1; i <= N; i++) {
        numbers[i] = parseInt(params[i]);
    }

    for (i = 1; i <= N; i += 1) {
        for (j = i; j <= N; j += 1) {
            answer = 0;
            for (k = i; k <= j; k += 1) {
                answer += numbers[k];
            }
            if (answer > currentMax) {
                currentMax = answer;
            }
        }

    }

    // Your code here...
    return currentMax;
}

console.log(Solve(['8', '1', '6', '-9', '4', '4', '-2', '10', '-1']));
console.log(Solve(['6', '1', '3', '-5', '8', '7', '-6']));
console.log(Solve(['9', '-9', '-8','-8', '-7', '-6', '-5', '-1', '-7','-6']));