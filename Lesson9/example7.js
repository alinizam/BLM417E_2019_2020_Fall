function outerF(){
    var outerName='outer';
    function innerF(){
        console.log(outerName);
    }
    return innerF();
}
var callOuter=outerF;
callOuter();