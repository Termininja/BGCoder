function solve(args) {
    var S = "";
    var K = parseInt(args[0]);
    var N = parseInt(args[1]);
    for (var n = 0; n < N; n++) {
        S += parseInt(args[2 + n]).toString(2);
    }
    var result = 0;
    var count0 = 0;
    var count1 = 0;
    for (var i = 0; i < S.length; i++) {
        if (K == 0) result = 0;
        else {
            if (S[i] == '0') {
                count1 = 0;
                count0++;
            }
            if (S[i] == '1') {
                count0 = 0;
                count1++;
            }
            if ((i == S.length - 1 && (count0 == K || count1 == K)) ||
                ((count0 == K || count1 == K) && S[i + 1] != S[i])) result++;
        }
    }

    return result;
}