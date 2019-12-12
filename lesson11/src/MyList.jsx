import React from 'react'

class MyList extends React.Component {
    
    
    render(){
        const numbers = ['Ahmet', 'Mehmet','Ayşe'];
        return(
            <ol>
                {
                    numbers.map((number) =>
                    <li>{number}</li>)
                }
            </ol>    
        )
    }
    
}
export default MyList;