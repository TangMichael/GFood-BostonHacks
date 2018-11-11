import React from 'react'
import { Transition, Segment} from 'semantic-ui-react'
import './../container/picture-container/pictureContainer.css'

export const BusinessDetails = props => {
    
    return (
        <div>
            <Transition.Group animation='fly down' duration='1500'>
             {props.isVisible &&
                <Segment raised className="seg">
                 Restaurant Name: {props.details.name} <br></br>
                 {props.details.address} <br></br>
                 {props.details.city}, {props.details.state} <br></br>
                 {props.details.postal_code} <br></br>
                 Rating: {props.details.stars} / 5 ({props.details.review_count} reviews)
             </Segment>}
            </Transition.Group>
        </div>
    )
}
