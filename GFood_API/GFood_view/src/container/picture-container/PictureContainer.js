import React from 'react'
import { AcceptButton } from './../../components/picture/AcceptButton'
import { RejectButton } from './../../components/picture/RejectButton'
import './pictureContainer.css';
import { BusinessDetails } from '../../components/BusinessDetails';
import CardContainer from "./CardContainer";
import { DetailButton } from '../../components/picture/DetailButton';

export const PictureContainer = props => {
    return (

        <div className="container">
            {/* <Picture foodPic={props.foodImg}></Picture> */}
                <CardContainer color='red' details={props.onMore} foodPic={props.foodImg}> </CardContainer>
            <div className="middle">
                <AcceptButton onAccept={props.onAccept}></AcceptButton>
                <DetailButton handleVisibility={props.onDetail}></DetailButton>
                <RejectButton onReject={props.onReject}></RejectButton><br></br>
            </div>
            <div className="bottom">
                <BusinessDetails isVisible={props.visible} details={props.onMore}></BusinessDetails>
            </div>
        </div>
    )
}
