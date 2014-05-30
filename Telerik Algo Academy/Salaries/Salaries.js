function solve(args) {
    var N = args[0];
    var sum = 0;
    var personnel = [];
    for (var i = 0; i < N; i++) {
        personnel[i] = { str: args[1 + i], selary: 0 };
        if (personnel[i].str.indexOf('Y') == -1) {
            personnel[i].selary = 1;
            sum += personnel[i].selary;
        }
    }

    var cont = false;
    for (var i = 0; i < N; i++) {
        if (personnel[i].selary == 0) {
            var selary = 0;
            for (var j = 0; j < N; j++) {
                if (personnel[i].str[j] == 'Y') {
                    if (personnel[j].selary == 0) {
                        selary = 0;
                        break;
                    }
                    selary += personnel[j].selary;
                }
            }

            personnel[i].selary = selary;
            sum += personnel[i].selary;
            cont = true;
        }
        if (cont && i == N - 1) {
            cont = false;
            i = -1;
        }
    }

    return sum;
}