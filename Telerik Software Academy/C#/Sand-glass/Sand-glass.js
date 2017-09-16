function solve(args) {
    var N = parseInt(args[0]);
    var result = '';
    for (var i = 0; i < parseInt(N / 2) ; i++) {
        result += new Array(i + 1).join('.') + new Array(N - (2 * i) + 1).join('*') + new Array(i + 1).join('.') + '\n';
    }
    for (var j = parseInt(N / 2) ; j >= 0; j--) {
        result += new Array(j + 1).join('.') + new Array(N - (2 * j) + 1).join('*') + new Array(j + 1).join('.') + '\n';
    }

    return result;
}