import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import Search from './components/search';
import { PictureContainer } from './container/picture-container/PictureContainer';

class App extends Component {
  constructor(props) {
    super(props);
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
    console.log('Rejected.');
  }

  handleAccept() {
    console.log('Accepted.');
  }


  render() {
    return (
      <div className="App">
        <Search></Search>
        <PictureContainer onAccept={this.handleAccept} onReject={this.handleReject} foodImg={this.state.imageURL[this.state.currentImage]}></PictureContainer>
      </div>
    );
  }
}

export default App;
