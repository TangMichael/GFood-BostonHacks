import React from 'react'
import { Button } from 'semantic-ui-react';
import Icon from "semantic-ui-react/dist/commonjs/elements/Icon/Icon";

export const AcceptButton = props => {
    return (
      <div>
          <Button onClick={props.onAccept} as='div' labelPosition='right'>
              <Button color='red'>
                  <Icon name='heart' />
                  Like
              </Button>
          </Button>
      </div>
    )
}
