function solve(args) {
    var first = args[0];
    var second = args[1];
    var L = parseInt(args[2]);
    var result = '';

    for (var i = 1; i < 2 * L; i++) {
        var firstNum = (first.charCodeAt() - 64) % 26;
        var secondNum = (second.charCodeAt() - 64) % 26;

        if (firstNum == 0) firstNum = 26;
        if (secondNum == 0) secondNum = 26;

        first = String.fromCharCode(firstNum + 64);
        second = String.fromCharCode(secondNum + 64);

        if (i === 1) result += first + '\n';
        if (i % 2 === 0) {
            result += first;
            if (i > 1) result += new Array(i / 2).join(' ');
            if (i > 0) result += second;
            result += '\n';
        }

        first = second;
        second = String.fromCharCode(firstNum + secondNum + 64)
    }

    return result;
}