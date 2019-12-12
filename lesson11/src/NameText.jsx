import React from 'react'

class NameText extends React.Component{
    constructor(props){
        super(props);
    }
    render(){
        return (
            <> 
            <h1>{this.props.firstName}</h1> 
            <h1>{this.props.lastName}</h1> 
            </>
        );    
    }
}

export default NameText;