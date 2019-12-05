class ObjMaker {
    constructor() { this.a = 'first';  }
}
obj1=new ObjMaker();
console.log(obj1.a);

obj1.b="secondB";

obj2=new ObjMaker();

console.log(Object.getPrototypeOf(obj1)===Object.getPrototypeOf(obj2));
console.log(obj2.b);