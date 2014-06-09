function solve(args) {
    var n = parseInt(args[0]);
    var result = '';
    for (var j = 0; j < n; j++) {
        var p = parseInt(args[1 + j]);
        var inverted = p;
        for (var k = 0; k < inverted.toString(2).length; k++) {
            inverted ^= (1 << k);
        }

        var reversed = 0;
        var temp = p;
        while (temp > 0) {
            reversed = (reversed << 1) | (temp & 1);
            temp >>= 1;
        }

        result += ((p ^ inverted) & reversed) + '\n';
    }

    return result;
}