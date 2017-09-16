function solve(args) {
    var N = parseInt(args[0]);
    var result = '';
    for (var i = 10; i >= 0; i--) {
        if ((N & 1) == 0) result += 'A' + i + '\n';
        N >>= 1;
    }

    return result.trim();
}