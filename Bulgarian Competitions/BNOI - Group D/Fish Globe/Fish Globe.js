function solve(args) {
    var input = args[0].split(' ');
    return input[0] * Math.pow(2, Math.floor(input[1] / 2));
}