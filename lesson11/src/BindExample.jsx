import React from 'react';

class BindExample extends React.Component {
  constructor(props) {
    super(props)
  //  this.shoot = this.shoot.bind(this)
  }
  shoot=()=> {
    alert(this);
  }
  render() {
    return (
      <button onClick={this.shoot}>Take the shot!</button>
    );
  }
}

export default BindExample;

