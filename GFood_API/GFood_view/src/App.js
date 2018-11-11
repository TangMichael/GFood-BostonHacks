import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import { Search }  from './components/search';
import PictureContainer  from './container/picture-container/PictureContainer';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      id: [],
      imageURL: [],
      currentImage: 0,
      search: ""
    }

    this.handleAccept = this.handleAccept.bind(this);
    this.handleReject = this.handleReject.bind(this);
    this.handleSearch = this.handleSearch.bind(this);
  }

  handleChange = (e) => {
    this.setState({search: e.target.value})
}

  handleSearch() {
    console.log(this.state.search);
  }

  handleReject() {

  }

  handleAccept() {

  }


  render() {
    return (
      <div className="App">
        <Search search={this.handleSearch} handleChange={this.handleChange}></Search>
        <PictureContainer></PictureContainer>
      </div>
    );
  }
}

export default App;
