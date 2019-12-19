import store from "./MyStore";

store.subscribe(()=>{console.log("Initiated : " ,store.getState())});
store.dispatch({
    type:"ADD",
    payload:5
});

store.subscribe(()=>{console.log("Run : " ,store.getState())});
store.dispatch({
    type:"ADD",
    payload:5
});

store.subscribe(()=>{console.log("Run : " ,store.getState())});
store.dispatch({
    type:"SUBSTRACT",
    payload:2
});

