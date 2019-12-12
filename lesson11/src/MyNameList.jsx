import React from 'react'

class MyNameList extends React.Component {
    constructor(props) {
        super(props)
        this.state = { name:'',
             names: ['Ahmet', 'Mehmet', 'Ayşe']
        };
    }
    add = () => {
        this.setState({names:this.state.names.concat([this.state.name])});
    }

    myChangeHandler = (event) => {
        let nam = event.target.value;
        this.setState({name: nam});
    }

    render() {
        
        return (
            <div>
            <input type='text' name='username' onChange={this.myChangeHandler}/>
            <button onClick={this.add}> Add </button>
            <ol>
                {
                    this.state.names.map((name) =>
                        <li key={name}>{name}</li>)
                }
            </ol>
            </div>
        )
    }

}
export default MyNameList;