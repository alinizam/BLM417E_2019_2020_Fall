
//import ReactDOM from 'react-dom';
//import './index.css';

//import * as serviceWorker from './serviceWorker';

//ReactDOM.render(<App />, document.getElementById('root'));

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
//serviceWorker.unregister();

import React from 'react';
import {Provider} from "react-redux";
import {createStore, applyMiddleware} from "redux";
import {render} from "react-dom";
import App from './App';
import {composeWithDevTools} from "redux-devtools-extension";

const initialState={
    result:1,
    prevValues:[]
}

const reducer=(state=initialState,action)=>{
    switch(action.type){
        case "ADD":
            state={
                ...state,
                result:state.result+action.payload,
                prevValues:[...state.prevValues,action.payload]
            };
            
            break;

    }
    return state;
}

const store =createStore(reducer,composeWithDevTools());

render(<Provider store={store}><App /> </Provider>, document.getElementById('root'));

