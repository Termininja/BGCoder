function solve(args) {
    var input = args[0].split('');
    input.sort();
    input.push('*');
    var count = 1;
    var result = [];
    for (var i = 1; i < input.length; i++) {
        if (input[i] == input[i - 1]) count++;
        else {
            if (count > 1) result.push(input[i - 1] + ' ' + count);
            count = 1;
        }
    }

    return result.join('\n');
}