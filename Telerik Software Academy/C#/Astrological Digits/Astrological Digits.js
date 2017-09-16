function solve(args) {
    var N = args[0];
    var Sum = 0;
    while (true) {
        Sum = 0;
        for (var i = 0; i < N.length; i++) {
            if (N[i] != '.' && N[i] != '-') Sum += parseInt(N[i].toString());
        }
        if (Sum < 10) break;
        N = Sum.toString();
    }

    return Sum;
}