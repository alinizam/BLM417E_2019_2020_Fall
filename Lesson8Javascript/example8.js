var a=1;
function f(){
    a=2;
    console.log("Inside : " + a);
}
console.log("Before run : " + a);
f();
console.log("After run : " + a);
