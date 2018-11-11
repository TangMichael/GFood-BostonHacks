import React, { Component } from 'react'
import { Picture } from './../../components/picture/Picture'
import { AcceptButton } from './../../components/picture/AcceptButton'
import { RejectButton } from './../../components/picture/RejectButton'

export const PictureContainer = props => {
    return (
      <div>
        <Picture foodPic={props.foodImg}></Picture>
        <AcceptButton onAccept={props.onAccept}></AcceptButton>
        <RejectButton onReject={props.onReject}></RejectButton>
      </div>
    )
}
