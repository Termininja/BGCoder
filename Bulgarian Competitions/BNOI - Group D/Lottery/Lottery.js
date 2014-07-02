function solve(str) {
    var args = str[0].split('\n');
    var k = args[0].split(' ')[1];
    var arr = args[1].split(' ');
    var minMax = args[2].split(' ');
    var min = minMax[0];
    var len = minMax[1] - min + 1;
    var result = [];
    for (var a = 0; a < arr.length; a++) {
        var start = ((min % arr[a] == 0) ? 0 : arr[a] - min % arr[a]);
        for (var i = start; i < len; i += +arr[a]) {
            result[i] = (result[i]) ? result[i] + 1 : 1;
        }
    }

    return result.filter(function (m) {
        return m == k;
    }).length;
}