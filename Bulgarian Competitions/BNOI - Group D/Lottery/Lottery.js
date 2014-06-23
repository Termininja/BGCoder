function solve(args) {
    var input = args[0];
    var digits = [];
    var last = "No";
    for (var i = 0; i < input.length; i++) {
        var digit = input[i];
        if (digits[digit] == '*') last = digit;
        digits[digit] = '*';
    }

    return last;
}