import React from 'react';
import logo from './logo.svg';
import './App.css';
import { connect } from 'react-redux';

class App extends React.Component {
  render()
  {return (
    <div className="App">
    <h1> {this.props.localState.result} </h1> 
    <button onClick={this.props.inc}>Increase</button>
    <button onClick={this.props.dec}>Decrease</button>
    </div>
  );
  }
}

const mapStateToProps= (state)=>{
  return {
      localState:state
  };
};

const mapDispatchtoProps= (dispatch )=>{
  return {
          inc: () => {
            dispatch({type:"ADD", payload:5})},
          dec:() => {
            dispatch({type:"SUBSTRACT", payload:1}) 
          }   
  };
};

export default connect(mapStateToProps,mapDispatchtoProps)(App);
