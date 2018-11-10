import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import Search from './components/search';
import { PictureContainer } from './container/picture-container/PictureContainer';

class App extends Component {
  constructor() {
    this.state = {
      id: [],
      imageURL: [],
      currentImage: 0
    }

    this.handleAccept = this.handleAccept.bind(this);
    this.handleReject = this.handleReject.bind(this);
    this.handleSearch = this.handleSearch.bind(this);
  }

  handleSearch() {

  }

  handleReject() {

  }

  handleAccept() {

  }


  render() {
    return (
      <div className="App">
        <Search></Search>
        <PictureContainer></PictureContainer>
      </div>
    );
  }
}

export default App;
