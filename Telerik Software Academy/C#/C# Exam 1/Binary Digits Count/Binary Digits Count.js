function solve(args) {
    var B = parseInt(args[0]);
    var N = parseInt(args[1]);
    var result = '';
    for (var n = 0; n < N; n++) {
        var number = parseInt(args[2 + n]);
        var count = 0;
        while (number != 0) {
            if ((number & 1) === B) count++;
            number >>>= 1;
        }
        result += count + '\n';
    }

    return result;
}
