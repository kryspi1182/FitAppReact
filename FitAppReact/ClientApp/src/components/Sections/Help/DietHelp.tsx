import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { Container, Col, Row } from 'reactstrap';

import { makeStyles, Theme, createStyles } from '@material-ui/core/styles';
import { TextField, Select, MenuItem, FormControl, FormHelperText, InputLabel, Typography } from '@material-ui/core';
import Button from '@material-ui/core/Button';
import { selectAllWeightTargets } from '../../../store/weightTargetSlice';
import { selectAllDifficulties } from '../../../store/difficultiesSlice';
import { selectAllTrainingConditionSeverities } from '../../../store/trainingConditionSeveritiesSlice';

const useStyles = makeStyles({

});

const DietHelp: React.FC = () => {

    return(<Container>
        <Row>
            <Col>
                <Typography>Your data:</Typography>
                <p>We will calculate your daily macros based on the data you provided in your profile.</p>
            </Col>
        </Row>
        <Row>
            <Col>
                <Typography>Macros of your choice:</Typography>
                <p>You decide how much of each macro you want to consume daily.</p>
            </Col>
        </Row>
        <Row>
            <Col>
                <Typography>Save diet:</Typography>
                <p>Save the generated diet with a name of your choice. That diet will show up in the "Saved diets" tab.</p>
            </Col>
        </Row>
    </Container>);
};

export default DietHelp;