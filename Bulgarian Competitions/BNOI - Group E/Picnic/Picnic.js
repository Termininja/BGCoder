function solve(args) {
    var input = args[0].split(' ');
    var n = (parseInt(input[0]) * 0.4) / parseFloat(input[1] + '.' + input[2]);

    return (n % 1 > 0) ? parseInt(n) + 1 : parseInt(n);
}
