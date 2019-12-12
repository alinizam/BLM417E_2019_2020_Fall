import React from 'react';
export default class Panel extends React.Component {
    render() {
      return (
        <div className="panel">
          <div className="panel-header">{this.props.title}</div>
          <div className="panel-body">{this.props.children}</div>
        </div>
      );
    }
  }