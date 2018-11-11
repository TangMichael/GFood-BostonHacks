import React, { Component } from 'react'
import { Form, Grid, Image, Transition, Button } from 'semantic-ui-react'

const transitions = [
  'fly down'
]
const options = transitions.map(name => ({ key: name, text: name, value: name }))

export default class TransitionExampleSingleExplorer extends Component {
    
  state = { animation: transitions[0], duration: 1500, visible: true }

  handleChange = (e, { name, value }) => this.setState({ [name]: value })

  handleVisibility = () => this.setState({ visible: !this.state.visible })
    
  render() {
    const { animation, duration, visible } = this.state
    const a = this.props.details;
    console.log(a);
    return (
        <div>
            <Button onClick={this.handleVisibility}>Details</Button>
            <Transition.Group animation={animation} duration={duration}>
             {visible && <p>
                 Address: {this.props.details[0].name}
             </p>}
            </Transition.Group>
        </div>
    )
  }
}
