function solve(args) {
    var N = args[0];
    var x1 = 0;
    var y1 = 0;
    for (var n = 0; n < N; n++) {
        var input = args[n + 1].split(' ');
        var F = input[2];
        x1 += F * input[0];
        y1 += F * input[1];
    }

    return -x1 + " " + -y1;
}