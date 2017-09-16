function solve(args) {
    var N = parseInt(args[0]);
    var result = '';
    for (var row = 0; row < N; row++) {
        for (var col = 0; col < N; col++) {
            result += (row == col && row == parseInt(N / 2)) ?
                "*" : ((col == parseInt(N / 2)) ?
                "|" : ((row == parseInt(N / 2)) ?
                "-" : ((row == col) ?
                "\\" : ((col == N - row - 1) ?
                "/" : "."))));
        }
        result += '\n';
    }

    return result;
}