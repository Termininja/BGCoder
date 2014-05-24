function solve(args) {
    var input = args[0].split(':');
    var min = parseInt(input[1]);
    var alpha = 360 * Math.abs(min / 60 - (parseInt(input[0]) / 12 + min / (60 * 12)));

    return ((alpha <= 180) ? alpha : 360 - alpha).toFixed(3);
}