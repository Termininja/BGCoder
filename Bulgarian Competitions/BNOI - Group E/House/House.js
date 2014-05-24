function solve(args) {
    var input = args[0].split(' ');
    var h = parseInt(input[0]);
    var b = parseInt(input[1]);
    var result = '';

    for (var i = 1; i <= h + b; i++) {
        result += ((i <= h) ? new Array(h - i + 1).join(' ') +
            new Array(i + 1).join('/') + new Array(i + 1).join('\\') :
            new Array(h - b + 1).join(' ') + new Array(2 * b + 1).join('=')) + '\n';
    }

    return result;
}