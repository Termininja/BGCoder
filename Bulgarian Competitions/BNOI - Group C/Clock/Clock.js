function solve(args) {
    var input = args[0].split(':');
    var alpha = 30 * Math.abs(11 * input[1] / 60 - parseInt(input[0]));

    return ((alpha <= 180) ? alpha : 360 - alpha).toFixed(3);
}