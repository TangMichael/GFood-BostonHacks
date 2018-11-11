import React, { Component } from 'react';
import './App.css';
import { Search } from './components/Search';
import { PictureContainer } from './container/picture-container/PictureContainer';
import TransitionExampleSingleExplorer from './components/BusinessDetails';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      id: [],
      businessDetails: [],
      currentImage: 0,
      search: ""
    }

    this.handleAccept = this.handleAccept.bind(this);
    this.handleReject = this.handleReject.bind(this);
    this.handleSearch = this.handleSearch.bind(this);
    this.handleChange = this.handleChange.bind(this);
    this.handleMoreDetail = this.handleMoreDetail.bind(this);
  }

  handleChange(e) {
    this.setState({ search: e.target.value })
  }

  handleSearch() {

    fetch("https://localhost:5001/api/clarifai", {
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
      },
      method: "POST",
      body: JSON.stringify(this.state.search)
      }).then(res => res.json())
        .then(body => {
          this.setState({
            businessDetails: body,
            currentImage: 0
          });
        })
  }

  handleAccept() {
    console.log('Accepted.');
  }

  handleReject() {
    console.log('Rejected.');
    let nextImagePosition = this.state.currentImage + 1;
    this.setState({
      currentImage: nextImagePosition
    });
  }

  handleMoreDetail() {
    console.log('Display more detail.')
  }

  render() {
    const x = (this.state.businessDetails === undefined|| this.state.businessDetails[this.state.currentImage] === undefined ) ? <h1>Please search something</h1> : 
    <div><PictureContainer onAccept={this.handleAccept} onReject={this.handleReject} onMore={this.handleMoreDetail} foodImg={this.state.businessDetails[this.state.currentImage].url}></PictureContainer>        <TransitionExampleSingleExplorer details={this.state.businessDetails[this.state.currentImage]}></TransitionExampleSingleExplorer></div> 

    return (
      <div className="App">
        <Search search={this.handleSearch} handleChange={this.handleChange}></Search>
        {x}
      </div>
    );
  }
}

export default App;
