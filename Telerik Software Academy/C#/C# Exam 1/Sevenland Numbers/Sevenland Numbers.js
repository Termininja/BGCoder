function solve(args) {
    var k = parseInt(args[0]);
    return result = k + ((k % 1000 == 666) ? 334 :
        ((k % 100 == 66) ? 34 : ((k % 10 == 6) ? 4 : 1)));
}