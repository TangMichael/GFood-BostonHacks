import React from 'react'
import { Dimmer, Loader } from 'semantic-ui-react'

export const Spinwheel = (props) => (
  <div>
      <Dimmer active={props.active}>
        <Loader indeterminate>Cooking Food</Loader>
      </Dimmer>
  </div>
)
