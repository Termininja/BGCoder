function solve(args) {
    var N = parseInt(args[0]);
    var result = '';
    for (var i = 0; i < N; i++) {
        result += new Array(i + 1).join('.') + "*" + new Array(N - i).join('.') + '\n';
    }
    for (var i = 1; i < N; i++) {
        result += new Array(N - i).join('.') + "*" + new Array(i + 1).join('.') + '\n';
    }

    return result;
}