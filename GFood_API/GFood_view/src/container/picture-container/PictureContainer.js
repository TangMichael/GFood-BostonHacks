import React from 'react'
import { Picture } from './../../components/picture/Picture'
import { AcceptButton } from './../../components/picture/AcceptButton'
import { RejectButton } from './../../components/picture/RejectButton'
import './pictureContainer.css';
import BusinessDetails from '../../components/BusinessDetails';

export const PictureContainer = props => {
    return (
      
      <div className="container">
        <Picture foodPic={props.foodImg}></Picture>
        <div className="bottom">
        <AcceptButton onAccept={props.onAccept}></AcceptButton>
        <BusinessDetails onMore={props.onMore}></BusinessDetails>
        <RejectButton onReject={props.onReject}></RejectButton>
        </div>
      </div>
    )
}
