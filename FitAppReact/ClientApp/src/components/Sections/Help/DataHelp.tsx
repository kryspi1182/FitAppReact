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

const DataHelp: React.FC = () => {
    const classes = useStyles();
    const difficulties = useSelector(selectAllDifficulties);
    const trainingConditionSeverities = useSelector(selectAllTrainingConditionSeverities);

    return(<Container>
        <Row>
            <Col>
                <Typography>Activity levels:</Typography>
                <p>None: No physical exercise in your free time, sitting job.</p>
                <p>Light: Sporadic and light physical exercise (walking, lesiure cycling etc.) in your free time, sitting job.</p>
                <p>Moderate: Regular and more demanding physical exercise (sports, gym etc.) in your free time or physical job.</p>
                <p>High: Regular and more demanding physical exercise (sports, gym etc.) in your free time and physical job.</p>
            </Col>
        </Row>
        <Row>
            <Col>
                <Typography>Medical conditions:</Typography>
                <p>Medical conditions affecting your everyday diet. We will choose meals accordingly.</p>
            </Col>
        </Row>
        <Row>
            <Col>
                <Typography>Unwanted products:</Typography>
                <p>Products you wish to not consume. We will choose meals accordingly.</p>
            </Col>
        </Row>
        <Row>
            <Col>
                <Typography>Noteworthy conditions:</Typography>
                <p>Conditions which might affect your performance or health during exercise.</p>
                {trainingConditionSeverities.map((severity) => <p>{severity.name}: {severity.description}</p>)}
            </Col>
        </Row>
        <Row>
            <Col>
                <Typography>Difficulties:</Typography>
                <p>The level of difficulty which you feel you are comfortable with and most importantly, able to safely conform to (exercises can do harm to your body if executed incorrectly).</p>
                {difficulties.map((difficulty) => <p>{difficulty.name}: {difficulty.description}</p>)}
            </Col>
        </Row>
    </Container>)
};

export default DataHelp;