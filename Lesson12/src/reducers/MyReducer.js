const initialState={result:0,prevValues:[]}; 
const reducer = (state = initialState ,action)=>{
    switch(action.type){
       case "ADD":
          state={
            ...state,
            result:state.result+action.payload,
            prevValues:[...state.prevValues, state.result]
          } 

         /* state={
            result:state.result+action.payload,
            prevValues:state.prevValues.concat([state.result])
          } */
         break;
       case "SUBSTRACT":
            state={
               ...state,
               result:state.result-action.payload,
               prevValues:[...state.prevValues, state.result]
               } 
       break;
         
    }
    return state;
}
export default reducer;