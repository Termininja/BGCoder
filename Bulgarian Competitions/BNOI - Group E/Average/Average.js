function solve(args) {
    var input = args[0].split(' ');
    var m = parseInt(input[0]);
    var n = parseInt(input[1]);
    return (((m % 2 != 0) ? m + 1 : m) + ((n % 2 != 0) ? n - 1 : n)) / 2;
}