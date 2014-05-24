function solve(args) {
    var S = [];
    var maxCount = 0;
    var input = args[0];
    while (input.indexOf('  ') > 0) input = input.replace('  ', ' ');
    var str = input.split(' ').map(Number);
    var n = str[0];
    for (var i = 0; i < n; i++) {
        S[i] = [[str[4 * i + 1], str[4 * i + 2]], [str[4 * i + 3], str[4 * i + 4]]];
    }

    for (var i = 0; i < n - 1; i++) {
        for (var j = i + 1; j < n; j++) {
            SegmentIntersections(S[i][0][0], S[i][0][1], S[j][0][0], S[j][0][1]);
            SegmentIntersections(S[i][0][0], S[i][0][1], S[j][1][0], S[j][1][1]);
            SegmentIntersections(S[i][1][0], S[i][1][1], S[j][0][0], S[j][0][1]);
            SegmentIntersections(S[i][1][0], S[i][1][1], S[j][1][0], S[j][1][1]);
        }
    }

    function SegmentIntersections(x1, y1, x2, y2) {
        y1 -= (1000 + x1) * (y2 - y1) / (x2 - x1);
        x1 = -1000;
        y2 -= ((1000 - x2) * (y1 - y2) / (x2 - x1));
        x2 = 1000;

        var count = 0;
        for (var s = 0; s < n; s++) {
            var a = (S[s][0][0] - x1) * (y2 - y1) + (S[s][0][1] - y1) * (x1 - x2);
            var b = a / ((x2 - x1) * (S[s][1][1] - S[s][0][1]) + (y1 - y2) * (S[s][1][0] - S[s][0][0]));
            if ((a == 0) ? ((S[s][0][0] - x1 < 0) != (S[s][0][0] - x2 < 0)) : b >= 0 && b <= 1) count++;
        }

        if (count >= maxCount) maxCount = count;
    }

    return maxCount;
}