import React from 'react';
import ReactDOM from 'react-dom';

class Football extends React.Component {
  constructor(props) {
    super(props)
    this.shoot = this.shoot.bind(this)
    this.state={dizi:[1,3,5,7]};
  }
  shoot() {
    alert(this);
    /*
    Thanks to the binding in the constructor function,
    the 'this' keyword now refers to the component object
    */
  }

  render() {
    return (
      <ol>
        {this.state.dizi.map((i)=>
          <li><button onClick={this.shoot}>i</button></li>
        )}
      </ol>
    );
  }
}
export default Football;