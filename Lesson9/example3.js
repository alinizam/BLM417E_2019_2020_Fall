var obj = {
    doSomething: function () {
        console.log(this);
    }
}
obj.doSomething();

"use strict";
function myFunction() {
    return this;
}
console.log(myFunction());



