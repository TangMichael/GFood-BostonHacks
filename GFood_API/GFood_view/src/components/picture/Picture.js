import React, { Component } from 'react'
import { Image } from 'semantic-ui-react';

export const Picture = props => {
    return (
      <div>
        <Image src={props.foodPic}></Image>
      </div>
    )
}
