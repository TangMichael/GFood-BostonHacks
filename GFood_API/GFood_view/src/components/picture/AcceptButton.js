import React, { Component } from 'react'
import { Button } from 'semantic-ui-react';

export const AcceptButton = props => {
    return (
      <div>
        <Button onClick={props.onAccept}>Accept</Button>
      </div>
    )
}
