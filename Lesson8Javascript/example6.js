var add = (a, b) => a + b;
console.log(add(2, 3));

var multiplyByTwo = a => 2 * a;
console.log(multiplyByTwo(3));

var multiplyByTwoC = a => { return 2 * a };
console.log(multiplyByTwoC(3));


console.log([1, 2, 2, 6, 5].filter(e => e % 2 == 0));