function solve(params) {
    var args = params[0].split('\n');
    var N = parseInt(args[0]);
    var matrix = [];
    for (var i = 0; i < N; i++) {
        matrix.push(args[i + 1].split(' ').map(Number));
    }

    var points = 0;
    var primeDiagonal = [];
    var secondDiagonal = [];
    for (var i = 0; i < N; i++) {
        var rows = [];
        var cols = [];
        for (var j = 0; j < N; j++) {
            rows.push(matrix[i][j]);
            cols.push(matrix[j][i]);
            if (i == j) primeDiagonal.push(matrix[i][j]);
            if (i + j == N - 1) secondDiagonal.push(matrix[i][j]);
        }
        points += FindSequence(rows, "row");
        points += FindSequence(cols, "col");
    }

    points += FindSequence(primeDiagonal, "diagonal1");
    points += FindSequence(secondDiagonal, "diagonal2");
    return points;

    function FindSequence(array, type) {
        Array.prototype.distinct = function () {
            var a = [], k = 0, e;
            for (k = 0; e = this[k]; k++)
                if (a.indexOf(e) == -1)
                    a.push(e);
            return a;
        }

        var unique = array.distinct().sort(function (a, b) { return a - b });
        var result = 0;
        var count = 1;
        for (var i = 1; i < unique.length; i++) {
            if (unique[i] == unique[i - 1] + 1) count++;
            else {
                result += Points(count, type);
                count = 1;
            }
        }

        return result + Points(count, type);
    }

    function Points(count, type) {
        switch (count) {
            case 1: return 0;
            case 2: return (type == "row") ? 10 : ((type == "col") ? 20 : 30);
            case 3: return (type == "row") ? 40 : ((type == "col") ? 50 : 60);
            case 4: return (type == "row") ? 70 : ((type == "col") ? 80 : 90);
            case 5: return (type == "row") ? 100 : ((type == "col") ? 110 : 120);
            default: return (type == "row") ? 150 : ((type == "col") ? 160 : 170);
        }
    }
}