import React from 'react'
import { Button } from 'semantic-ui-react';
import Icon from "semantic-ui-react/dist/commonjs/elements/Icon/Icon";

export const RejectButton = props => {
    return (
      <div>
          <Button onClick={props.onReject} as='div' labelPosition='right'>
              <Button color='green'>
                  <Icon name='thumbs down outline' />
                  Next
              </Button>
          </Button>
      </div>
    )
}
