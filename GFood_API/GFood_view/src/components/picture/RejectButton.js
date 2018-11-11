import React from 'react'
import { Button } from 'semantic-ui-react';

export const RejectButton = props => {
    return (
      <div>
        <Button onClick={props.onReject}>Reject</Button>
      </div>
    )
}
