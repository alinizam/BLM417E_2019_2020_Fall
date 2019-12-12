import React from 'react'

class NameList extends React.Component{
    constructor(props){
        super(props);
    }
    render(){
        return (
            <> 
                {this.props.children}
                {React.Children.count(this.props.children)}
            </>
        );    
    }
}

export default NameList;