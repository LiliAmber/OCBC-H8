import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

/**
 * Local state:
 * - read state
 * - update state
 */

class App extends Component {
  constructor () {
    super() // instantiate parent component di sini

    this.state = {
      title: "Session 19 - React JS",
      name: "Muhadjir",
      scope: {
        project: "fasterAPI",
        founded: 2022
      }
    }
  }

  getScope() {
    return this.state.scope
  }

  changeTitle = (event) => {
    console.log(event)
    this.setState({
      title: "Final Project - React JS"
    })
  }

  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h2>
            {this.state.title} by {this.state.name}
          </h2>
          <h3>
            {/* {JSON.stringify(this.getScope())} */}
            Project Name: {this.getScope().project} | Founded: {this.getScope().founded} | 
            Founded By: {this.state.name} | 
            Score: {this.props.score} {/**cara nagkep data dari parent */}
          </h3>
          <p>
            Edit <code>src/App.js</code> and save to reload.
          </p>
          <button
            className="App-link"
            onClick={this.changeTitle}
          >
            Change Title
          </button>
        </header>
      </div>
    );
  }
}

export default App;

// import logo from './logo.svg';
// import './App.css';
// function App() {
//   return (
//     <div className="App">
//       <header className="App-header">
//         <img src={logo} className="App-logo" alt="logo" />
//         <p>
//           Edit <code>src/App.js</code> and save to reload.
//         </p>
//         <a
//           className="App-link"
//           href="https://reactjs.org"
//           target="_blank"
//           rel="noopener noreferrer"
//         >
//           Learn React
//         </a>
//       </header>
//     </div>
//   );
// }

// export default App;
