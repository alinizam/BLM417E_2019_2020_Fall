function bike() {
  var name = "Ninja";
  this.maker = "Kawasaki";
  console.log(this.name + " " + maker);   
}

var name = "Ninja";
var maker = "Other";

bike();
obj=new bike();
console.log(obj.maker);