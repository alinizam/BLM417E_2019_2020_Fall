import {createStore} from "redux";
const reducer=(state,action)=>{
    switch(action.type){
        case "ADD":
            state=state+action.payload;
            break;
    }
    return state;
}
const store =createStore(reducer,1);

store.subscribe(()=>{console.log(store.getState())})
store.dispatch(
    {
        type:"ADD",
        payload:10
    }
)