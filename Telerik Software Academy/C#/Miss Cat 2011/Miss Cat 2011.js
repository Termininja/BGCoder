function solve(args) {
    var CatVotes = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
    var N = parseInt(args[0]);
    for (var i = 0; i < N; i++) {
        var vote = parseInt(args[i + 1]);
        CatVotes[vote - 1]++;
    }
    var max = 0;
    var cat = 0;
    for (var i = 0; i < 10; i++) {
        if (CatVotes[i] > max) {
            max = CatVotes[i];
            cat = 1 + i;
        }
    }

    return cat;
}