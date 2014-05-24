function solve(args) {
    var points = args[0].split(' ');
    var N = parseInt(points[0]);
    var routes = [];
    for (var i = 0; i < N; i++) {
        var stop = args[i + 1].split(' ');
        routes[i] = new Array(parseInt(stop[0]), parseInt(stop[1]), parseInt(stop[2]));
    }
    routes.sort(function (a, b) { return a[0] - b[0] });

    return getPrice(routes, parseInt(points[1]), parseInt(points[2]));

    function getPrice(routes, A, B) {
        var price = 0;
        var isRoute = false;
        for (var r in routes) {
            if (A >= routes[r][0] && A < routes[r][1]) {
                isRoute = true;
                if (B >= routes[r][0] && B < routes[r][1]) return B - A;
                else price += ticketOrCard(routes[r], A, false);
            }
            else if (B >= routes[r][0] && B < routes[r][1]) return price + ticketOrCard(routes[r], B, true);
            else if (isRoute) price += routes[r][2];
        }

        return price;
    }

    function ticketOrCard(r, point, last) {
        var ticket = (last) ? point - r[0] : r[1] - point;
        return ticket < r[2] ? ticket : r[2];
    }
}