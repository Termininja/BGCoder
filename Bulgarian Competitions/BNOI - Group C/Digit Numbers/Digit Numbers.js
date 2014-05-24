function solve(args) {
    var number = parseInt(args[0]);
    var count = 0;
    for (var i = 10000; i < 100000; i++) {
        var n1 = Math.floor(i / 10000);
        var n2 = Math.floor(i / 1000) % 10;
        var n3 = Math.floor(i / 100) % 10;
        var n4 = Math.floor(i / 10) % 10;
        var n5 = i % 10;
        if (n1 + n3 == n2 && n3 + n5 == n4) {
            count++;
            if (i == number) return count;
        }
    }

    return 0;
}