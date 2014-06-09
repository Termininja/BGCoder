function solve(args) {
    var prices = [0.5, 0.4, 0.25, 0.6, 0.3, 0.4];
    var totalCost = 0;
    var beansArea = 250;

    for (var i = 0; i < 6; i++) {
        totalCost += prices[i] * parseInt(args[2 * i]);
        if (i < 5) beansArea -= parseInt(args[2 * i + 1]);
    }

    return 'Total costs: ' + totalCost.toFixed(2) + '\n' +
        ((beansArea < 0) ? 'Insufficient area' : ((beansArea == 0) ?
        'No area for beans' : ('Beans area: ' + beansArea)));
}