let p=new Promise(function(resolve,reject){
    console.log("started"); 
   // resolve("success") ;
    reject("reject") ;
});

p.then(function(data){
    console.log(data); 
}).catch(function(data){
    console.log(data); 
});
 