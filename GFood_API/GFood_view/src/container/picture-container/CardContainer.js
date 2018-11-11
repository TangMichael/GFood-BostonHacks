import React from 'react'
import { Card, Icon, Image } from 'semantic-ui-react'

const CardContainer = (props) => (
    <Card>
        <Image src={props.foodPic} />
        <Card.Content>
            <Card.Header> Restaurant Name: {props.details.name}</Card.Header>
            <Card.Meta>Joined in 2016</Card.Meta>
            <Card.Description>{props.details.categories}</Card.Description>
        </Card.Content>
        <Card.Content extra>
        </Card.Content>
    </Card>
);

export default CardContainer