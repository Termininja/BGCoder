function solve(args) {
    var N = parseInt(args[0]);

    var result = new Array(N + 1).join('.') + new Array(N + 1).join('*') + '\n';
    for (var i = 0; i < N - 1; i++) {
        result += new Array(N - i).join('.') + '*' + new Array(N + i).join('.') + '*\n';
    }
    result += new Array(2 * N + 1).join('*');

    return result;
}