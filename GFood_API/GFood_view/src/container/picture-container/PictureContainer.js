import React from 'react'
import { Picture } from './../../components/picture/Picture'
import { AcceptButton } from './../../components/picture/AcceptButton'
import { RejectButton } from './../../components/picture/RejectButton'
import { DetailButton } from './../../components/picture/DetailButton'


export const PictureContainer = props => {
    return (
      <div>
        <Picture foodPic={props.foodImg}></Picture>
        <AcceptButton onAccept={props.onAccept}></AcceptButton>
        <DetailButton onMoreDetail={props.onMore}></DetailButton>
        <RejectButton onReject={props.onReject}></RejectButton>
      </div>
    )
}
