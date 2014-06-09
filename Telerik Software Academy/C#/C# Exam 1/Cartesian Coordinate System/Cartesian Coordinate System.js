function solve(args) {
    var x = parseFloat(args[0]);
    var y = parseFloat(args[1]);

    return (x == 0 && y == 0) ? 0 : ((x > 0) ? ((y > 0) ? 1 :
        ((y < 0) ? 4 : 6)) : ((x < 0) ? ((y > 0) ? 2 : ((y < 0) ? 3 : 6)) : 5));
}
