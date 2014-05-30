function solve(args) {
    var input = args[0].split(' ');
    var fences = [];
    for (var f = 0; f < input[0]; f++) {
        var fence = args[1 + f].split(' ');
        fences.push(new Array(fence[0], fence[1], fence[2], fence[3]));
    }

    var count = 0;
    for (var s = 0; s < input[1]; s++) {
        var sheep = args[+input[0] + 1 + s].split(' ');
        var isOut = true;
        for (var f = 0; f < fences.length; f++) {
            if (sheep[0] < Math.max(fences[f][0], fences[f][2]) &&
                sheep[0] > Math.min(fences[f][0], fences[f][2]) &&
                sheep[1] < Math.max(fences[f][1], fences[f][3]) &&
                sheep[1] > Math.min(fences[f][1], fences[f][3])) {
                isOut = false;
                break;
            }
        }

        if (!isOut) count++;
    }

    return count;
}