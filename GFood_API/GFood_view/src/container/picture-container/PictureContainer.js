import React from 'react'
import { Picture } from './../../components/picture/Picture'
import { AcceptButton } from './../../components/picture/AcceptButton'
import { RejectButton } from './../../components/picture/RejectButton'
import { DetailButton } from './../../components/picture/DetailButton'
import './pictureContainer.css';

export const PictureContainer = props => {
    return (
      
      <div className="container">
        <Picture foodPic={props.foodImg}></Picture>
        <div className="bottom">
        <AcceptButton onAccept={props.onAccept}></AcceptButton>
        <DetailButton onMoreDetail={props.onMore}></DetailButton>
        <RejectButton onReject={props.onReject}></RejectButton>
        </div>
      </div>
    )
}
