import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { Container, Col, Row } from 'reactstrap';

import { makeStyles, Theme, createStyles } from '@material-ui/core/styles';

type Props = {
    content: React.ReactNode
};

const useStyles = makeStyles({
    modal: {
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center',
      },
      paper: {
        border: '2px solid #000',
        backgroundColor: '#fff',
        padding: '10px',
        overflowY: "auto",
        maxHeight: "80vh"
      },
});

const HelpModal: React.FC<Props> = (props) => {
    const classes = useStyles();

    return (<Container>
        <Row>
            <Col xs="12">
                {props.content}
            </Col>
        </Row>
    </Container>);
};

export default HelpModal;
