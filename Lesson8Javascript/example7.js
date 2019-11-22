var add = (a,b) => a+b;
var extract = (a,b) => a-b;

function doItSomething(operation,a,b){
    console.log(operation(a,b));
}

doItSomething(add,7,3);
doItSomething(extract,7,3);