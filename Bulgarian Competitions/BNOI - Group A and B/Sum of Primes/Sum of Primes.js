function solve(args) {
    var sum = parseInt(args[0]);
    var primes = [];
    for (var i = 2; i < sum; i++) {
        var isPrime = true;
        for (var j = 2; j < i; j++) {
            if (i % j == 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime) primes.push(i);
    }

    var count = 0;
    for (var i = 0; i < primes.length; i++) {
        for (var j = 0; j < primes.length; j++) {
            if (primes[i] + primes[j] == sum) count++;
        }
    }

    return Math.floor(count / 2) + (count % 2 == 0 ? 0 : 1);
}