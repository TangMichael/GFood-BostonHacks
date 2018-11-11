import React, { Component } from 'react'
import { Form, Grid, Image, Transition, Button , Segment} from 'semantic-ui-react'
import './../container/picture-container/pictureContainer.css'
const transitions = [
  'fly down'
]
//const options = transitions.map(name => ({ key: name, text: name, value: name }))

export default class BusinessDetails extends Component {
    
  state = { animation: transitions[0], duration: 1500, visible: false}

  handleChange = (e, { name, value }) => this.setState({ [name]: value })

  handleVisibility = () => this.setState({ visible: !this.state.visible })
    
  render() {
    const { animation, duration, visible } = this.state
    return (
        <div>
            <div>
                <Button onClick={this.handleVisibility}>Details</Button><br></br>
            </div>
            <Transition.Group animation={animation} duration={duration}>
             {visible &&
                <Segment raised className="seg">
                 Restaurant Name: {this.props.details.name} <br></br>
                 {this.props.details.address} <br></br>
                 {this.props.details.city}, {this.props.details.state} <br></br>
                 {this.props.details.postal_code} <br></br>
                 Rating: {this.props.details.stars} / 5 ({this.props.details.review_count} reviews)
             </Segment>}
            </Transition.Group>
        </div>
    )
  }
}
