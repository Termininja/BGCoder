function solve(args) {
    var n = parseInt(args[0]);
    var words = [];
    for (var i = 0; i < n; i++) {
        words.push(args[1 + i]);
    }

    for (var i = 0; i < n; i++) {
        var tempWord = words[i];
        words[i] = null;
        words.splice(tempWord.Length % (n + 1), 0, tempWord);
        words.splice(words.indexOf(null), 1);
    }

    var result = '';
    var loop = true;
    var letter = 0;

    while (loop) {
        loop = false;
        for (var i = 0; i < n; i++) {
            if (words[i].length > letter) {
                result += words[i][letter];
                loop = true;
            }
        }
        letter++;
    }

    return result;
}