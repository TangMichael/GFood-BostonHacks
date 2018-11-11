import React from 'react'
import { Image } from 'semantic-ui-react';

export const Picture = props => {
    return (
      <div>
        <Image src={props.foodPic} className="ui centered image ui huge image" style={{height: 500, width: 500}}></Image>
      </div>
    )
}
