import React from 'react';
import NameText from './NameText'
import WelcomeDialog from './WelcomeDialog'
import NameList from './NameList'
import BindExample from './BindExample';
import Counter from './Counter';
import MyList from './MyList';
import MyNameList from './MyNameList';

export default class App extends React.Component {
    render() {
      return (
        <div>
          <MyNameList/>
          <MyList/>
          <Counter/>
          <BindExample/>
          <h1> Hello world </h1>
          <NameText firstName="Ahmet"  lastName="AK"/> 
          <WelcomeDialog/>
          <NameList>
              <h2> My child prop1 </h2>
              <h2> My child prop2 </h2>
              <h2> My child prop3 </h2>
         </NameList>  
        </div>
      );
    }
}