function add(a, b) {
    return a + b;
}
console.log(add(2, 5));

var addVar = function (a, b) {
    return a + b;
}

/*  similar syntax
    var addVar=function add1(a,b){
    return a+b;
}*/

console.log(addVar(2, 5));

console.log(
    (function (a, b) {
        return a + b;
    })(2, 3));