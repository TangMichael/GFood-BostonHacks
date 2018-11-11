import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import { Search }  from './components/search';
import { PictureContainer }  from './container/picture-container/PictureContainer';

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
    this.handleChange = this.handleChange.bind(this);
  }

  handleChange(e) {
    this.setState({search: e.target.value})
}

  handleSearch() {
    console.log(this.state.search);
    this.setState({
      imageURL: ['https://s3-media2.fl.yelpcdn.com/bphoto/b2svNDHSUotsLa5Dt5rLGA/o.jpg', 'https://www.concordia.ca/etc/designs/concordia/resources/file.jpg?did=2748&w=303&s=PROD']
    })
  }

  handleReject() {
    console.log('Rejected.');
    let nextImagePosition = this.state.currentImage + 1;
    this.setState({
      currentImage: nextImagePosition
    });
  }

  handleAccept() {
    console.log('Accepted.');
  }


  render() {
    return (
      <div className="App">
        <Search search={this.handleSearch} handleChange={this.handleChange}></Search>
        <PictureContainer onAccept={this.handleAccept} onReject={this.handleReject} foodImg={this.state.imageURL[this.state.currentImage]}></PictureContainer>
      </div>
    );
  }
}

export default App;
