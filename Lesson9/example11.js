var call_back_array = []
for (var i = 0; i <= 2; i++) {
    function innerF(value) { return value * 2 };
    call_back_array[i] = (innerF(i));
}
console.log(call_back_array[0]);
console.log(call_back_array[1]);
console.log(call_back_array[2]);