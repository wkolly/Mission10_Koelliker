import React from 'react';
import './App.css';
import BowlerList from './Bowlers/BowlerList';

function Welcome() {
 return( <header>Welcome to my siteee</header>)
}


function App() {
  return (
    <div className="App">
     <Welcome />
     <BowlerList />
    </div>
  );
}

export default App;
