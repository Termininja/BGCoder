function solve(args) {
    var str = args[0] + ' ';
    var start = -1;
    var end = 0;
    while (str.indexOf('RRR') >= 0 || str.indexOf('GGG') >= 0 || str.indexOf('BBB') >= 0 || str.indexOf('YYY') >= 0) {
        for (var i = 2; i < str.length; i++) {
            if (str[i] === str[i - 1] && str[i - 1] === str[i - 2]) {
                if (start === -1) start = i - 2;
                end = i + 1;
            }
            else if (start >= 0) {
                str = str.substr(0, start) + str.substr(end);
                i = start + 1;
                start = -1;
                end = 0;
            }
        }
    }

    return (str.trim() == '') ? 'EMPTY' : str.trim();
}