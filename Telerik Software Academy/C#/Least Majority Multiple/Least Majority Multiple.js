function solve(args) {
    var a = parseInt(args[0]);
    var b = parseInt(args[1]);
    var c = parseInt(args[2]);
    var d = parseInt(args[3]);
    var e = parseInt(args[4]);

    for (var i = 1; i < 10000000; i++) {
        var count = 0;
        if (i % a === 0) count++;
        if (i % b === 0) count++;
        if (i % c === 0) count++;
        if (i % d === 0) count++;
        if (i % e === 0) count++;
        if (count >= 3) return i;
    }
}