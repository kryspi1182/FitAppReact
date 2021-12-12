import * as React from 'react';
import { Col, Container, Row } from 'reactstrap';

import { makeStyles } from '@material-ui/core/styles';

const useStyles = makeStyles({
    button: {
        marginRight: '10px',
        marginTop: '10px',
        marginBottom: '10px'
    },
    row: {
        marginBottom: '10px',
        paddingBottom: '10px'
    },
    container: {
        textAlign: 'center'
    }
});

const Disclaimer: React.FC = () => {
    const classes = useStyles();
    const logo = require('./pb_logo.png');
    return (<Container className={classes.container}>
        <Row className={classes.row}>
            <Col>
                <img alt='logo' src={String(logo)} />
            </Col>
        </Row>
        <Row className={classes.row}>
            <Col>
                <span>Niniejsza strona internetowa powstała na Wydziale Informatyki Politechniki Białostockiej, w ramach pracy inżynierskiej.</span>
            </Col>
        </Row>
        <Row className={classes.row}>
            <Col>
                <span>Autor: Krystian Wysocki</span>
            </Col>
        </Row>
    </Container>)
};

export default Disclaimer;