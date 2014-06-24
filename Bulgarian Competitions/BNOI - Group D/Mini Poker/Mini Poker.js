function solve(args) {
    var numbers = args[0].split(' ');
    for (var i = 0; i < numbers.length; i++) {
        numbers[i] = parseInt(numbers[i]);
    }

    numbers.sort(function (a, b) { return a - b });
    var isSeq = true;
    for (var i = 1; i < numbers.length; i++) {
        if (numbers[i] != numbers[i - 1] + 1) isSeq = false;
    }

    return (isSeq) ? numbers.join(' ') : Math.max.apply(null, numbers);
}