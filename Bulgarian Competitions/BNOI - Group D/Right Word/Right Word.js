function solve(args) {
    var words = args[0].replace(/[^\w\*]/g, '').replace(/\*{2,}/g, '*').split('*');
    var maxLength = 0;
    var maxPosition = 0;
    for (var i = 0; i < words.length; i++) {
        var word = words[i].toLowerCase();
        var length = word.length;
        if (length % 2 != 0) {
            var isRightWord = true;
            for (var w = 1; w < length; w++) {
                if (word[w - 1] > word[w]) {
                    isRightWord = false;
                    break;
                }
            }

            if (isRightWord && length > maxLength) {
                maxLength = length;
                maxPosition = i + 1;
            }
        }
    }

    return maxPosition + ' ' + maxLength;
}