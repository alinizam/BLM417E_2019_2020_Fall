ObjMaker = function() {this.a = 'first';}; 
ObjMaker.prototype.b = 'second';
//obj1 = new ObjMaker();
obj1 = Object.create(ObjMaker);


SubObjMaker = function () {};


SubObjMaker.prototype.c = 'third';  
obj2 = new SubObjMaker();

console.log(obj2.c);     // returns 'third', from SubObjMaker.prototype
console.log(obj2.b);     // returns 'second', from ObjMaker.prototype
console.log(obj2.a);    // returns 'first', from SubObjMaker.prototype, because SubObjMaker.prototype  was created with the ObjMaker function, which assigned a for us
