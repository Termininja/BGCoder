function solve(args) {
    var count = 0;
    var S = parseInt(args[0]);
    var N = parseInt(args[1]);
    var myList = new Array(N);
    for (var n = 0; n < N; n++) {
        myList[n] = parseInt(args[2 + n]);
    }
    for (var i = 1; i < Math.pow(2, N) ; i++) {
        var sum = 0;
        for (var j = 0; j < N; j++) {
            if ((i & (1 << j)) >> j == 1) {
                sum += myList[j];
            }
        }
        if (sum == S) count++;
    }

    return count;
}