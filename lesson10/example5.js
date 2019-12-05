var promiseTest = new Promise(function (resolve) {    
    // JSON.parse will throw an error because of invalid JSON     
    // so this indirectly rejects     
    resolve(JSON.parse('{"id":"10", "name":"Ahmet"}')); 
});
promiseTest.then(function (data){
        console.log("Finished succesfully");
        console.log(data);
}, function(error){
    console.log("Finished unsuccesfully");
    console.log(error); 
});