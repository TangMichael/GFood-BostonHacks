import React, { Component } from 'react';
import './App.css';
import { Search } from './components/Search';
import { Spinwheel } from './components/Spinwheel';
import { PictureContainer } from './container/picture-container/PictureContainer';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      id: [],
      businessDetails: [],
      currentImage: 0,
      search: "",
      isActive: false,
      bool: false,
      visible: false
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

  handleVisibility = () => this.setState({ visible: !this.state.visible })
 
  handleSearch() {
    this.setState({
      isActive: true
    })
    fetch("https://localhost:5001/api/clarifai", {
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
      },
      method: "POST",
      body: JSON.stringify(this.state.search.toLowerCase())
      }).then(res => res.json())
        .then(body => {
          console.log(body[0])
          this.setState({
            businessDetails: body,
            currentImage: 0,
            isActive: false
          });
        })
  }

  handleAccept() {
    console.log(this.state.businessDetails[this.state.currentImage].toString())
    let x = "Here is the address of "+ this.state.businessDetails[this.state.currentImage].name.toString() + ": \n" + this.state.businessDetails[this.state.currentImage].address.toString() + "\n" 
    + this.state.businessDetails[this.state.currentImage].city.toString() + ", " + this.state.businessDetails[this.state.currentImage].state.toString() + " " + this.state.businessDetails[this.state.currentImage].postal_code 
    + "\n Thank you for using GFood!"; 

   fetch("https://localhost:5001/api/twilio", {
     headers: {
      'Accept': 'application/json',
      'Content-Type': 'application/json'
     },
     method:"POST",
     body: JSON.stringify(x)
   })
  }

  handleReject() {
    console.log('Rejected.');
    let nextImagePosition = this.state.currentImage + 1;
    this.setState({
      currentImage: nextImagePosition,
      bool: false
    });
  }

  handleMoreDetail() {
    console.log('Display more detail.')
  }

  render() {
    const picture = (this.state.businessDetails === undefined|| this.state.businessDetails[this.state.currentImage] === undefined ) ? <h1>What would you like to eat today?</h1> : 
    <PictureContainer visible={this.state.visible} onDetail={this.handleVisibility} onAccept={this.handleAccept} onReject={this.handleReject} onMore={this.state.businessDetails[this.state.currentImage]} foodImg={this.state.businessDetails[this.state.currentImage].url}></PictureContainer>

    return (
      <div className="App">
        <Search search={this.handleSearch} handleChange={this.handleChange}></Search>
        {picture}
        <Spinwheel active={this.state.isActive}></Spinwheel>
      </div>
    );
  }
}

export default App;
