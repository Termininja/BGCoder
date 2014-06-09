function solve(args) {
    var H = parseInt(args[0]);
    var result = '';

    for (var h = 1, l = 1, d = 1; h <= H; h++) {
        result += new Array(H - h + 1).join('.') + "/" +
            new Array(2 * h - 1).join((h == l + d) ? '-' : '.') +
            "\\" + new Array(H - h + 1).join('.') + '\n';
        if (h == l + d) {
            l = h;
            d++;
        }
    }

    return result;
}