// You can live edit this code below the import statements
import React from 'react';
import Fade from 'react-reveal/Fade';

class FadeText extends React.Component {
    render() {
        return (
            <h1>
                <Fade cascade>
                    {this.props.text}
                </Fade>
            </h1>
        );
    }
}

export default FadeText;