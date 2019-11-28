var myModule=(function(){
    function privateF(){
        console.log("I am a private function");
    }
    function publicF(){
        console.log("I am a public function");
    }
    return {publicFunction:publicF};
})();
myModule.publicFunction();
//it will create an error.
//myModule.privateF();