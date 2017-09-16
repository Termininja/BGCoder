function solve(args) {

    var N = parseInt(args[0]);
    var sum = 0;
    for (var l = 1; l <= N; l++) {
        var letter = args[l];
        sum += Math.pow(26, N - l) * (letter.charCodeAt() - 64);
    }

    return sum;
}
