function factoryF(conf){
    return function createF(doSomething){
        console.log(conf+" "+doSomething);
    }

}

varfactoryF=factoryF("FSMVÜ");
console.log(varfactoryF);

varfactoryF("Comp Eng");
varfactoryF("Civil Eng");

varfactoryF1=factoryF("Gov");
varfactoryF1("Comp Eng");
varfactoryF1("Civil Eng");
