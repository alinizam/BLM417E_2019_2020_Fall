import React from 'react'

function Dialog(props) {
    return (
      <div>
        <h1 className="Dialog-title">
          {props.title}
        </h1>
        <p className="Dialog-message">
          {props.message}
        </p>
      </div>
    );
  }

  export default Dialog;