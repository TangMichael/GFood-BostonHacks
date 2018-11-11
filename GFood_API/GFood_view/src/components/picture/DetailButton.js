import React from 'react'
import { Button } from 'semantic-ui-react';

export const DetailButton = props => {
    return (
      <div>
          <Button onClick={props.handleVisibility}>Detail</Button>
      </div>
    )
}
