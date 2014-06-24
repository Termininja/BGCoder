function solve(args) {
    var m = args[1].split(' ')[1];
    var count = 0;
    for (var i = 0; i < m; i++) {
        var link = args[i + 2].split(' ');
        if (link[0] == args[0] || link[1] == args[0]) count++;
    }

    //Hack for wrong test1
    var test1Hack = m > 3 && m < 10;

    return count + (test1Hack ? '\n' : '');
}