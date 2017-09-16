function solve(args) {
    var N = parseInt(args[0]);
    var result = '';

    for (var i = 0; i < N / 2; i++) {
        result += new Array(N / 2 - i).join('.') + '#'
            + new Array(2 * i + 1).join('.') + '#' +
            new Array(N / 2 - i).join('.') + '\n';
    }

    for (var i = 0; i < (N / 2 + 1) / 2; i++) {
        result += new Array(i + 1).join('.') + '#' +
            new Array(N - 2 * i - 1).join('.') + '#' +
            new Array(i + 1).join('.') + '\n';
    }

    result += new Array(N).join('-') + '\n';
    for (var i = 0; i < N / 2; i++) {
        result += new Array(i + 1).join('.') +
            new Array(N / 2 - i + 1).join('\\') +
            new Array(N / 2 - i + 1).join('/') +
            new Array(i + 1).join('.') + '\n';
    }

    return result;
}