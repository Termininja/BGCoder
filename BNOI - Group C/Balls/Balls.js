function solve(args) {
    var input = args[0].split(' ');
    var k = parseInt(input[1]);
    var boxes = [];
    var distinct = [];
    for (var i = 0; i < k; i++) {
        var element = parseInt(args[1 + i]);
        boxes.push(element);
        var found = true;
        for (var j = 0; j < distinct.length; j++) {
            if (distinct[j] === element) {
                found = false;
                break;
            }
        }
        if (found) distinct.push(element);
    }

    return parseInt(input[0]) - distinct.length;
}