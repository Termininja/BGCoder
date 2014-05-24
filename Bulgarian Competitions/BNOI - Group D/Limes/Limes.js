function solve(args) {
    var a = args[0].split(' ');
    return (a[2] - 1) * a[1] + ((a[2] % 2 == 0) ? a[1] - a[3] : +a[3] - 1);
}