function solve(args) {
    var N = parseInt(args[0]);
    var result = '';
    for (var i = 0; i < N - 1; i++) {
        result += new Array(N - 1 - i).join('.') + new Array(2 * i + 2).join('*') + new Array(N - 1 - i).join('.') + '\n';
    }

    return result += new Array(N - 1).join('.') + '*' + new Array(N - 1).join('.');
}
