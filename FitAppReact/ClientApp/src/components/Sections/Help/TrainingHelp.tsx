import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { Container, Col, Row } from 'reactstrap';

import { makeStyles, Theme, createStyles } from '@material-ui/core/styles';
import { TextField, Select, MenuItem, FormControl, FormHelperText, InputLabel, Typography } from '@material-ui/core';
import Button from '@material-ui/core/Button';
import { selectAllWeightTargets } from '../../../store/weightTargetSlice';
import { selectAllDifficulties } from '../../../store/difficultiesSlice';
import { selectAllTrainingConditionSeverities } from '../../../store/trainingConditionSeveritiesSlice';
import { selectAllTrainingCategories } from '../../../store/trainingCategoriesSlice';

const useStyles = makeStyles({

});

const TrainingHelp: React.FC = () => {
    const classes = useStyles();
    const trainingCategories = useSelector(selectAllTrainingCategories);

    return(<Container>
        <Row>
            <Col>
                <Typography>Your data:</Typography>
                <p>We will show you a list of trainings suiting you based on the data you provided in your profile.</p>
            </Col>
        </Row>
        <Row>
            <Col>
                <Typography>Parameters of your choice:</Typography>
                <p>You decide what type of training you are looking for.</p>
            </Col>
        </Row>
        <Row>
            <Col>
                <Typography>Save training:</Typography>
                <p>Save a training to your list for easier and quicker access.</p>
            </Col>
        </Row>
        <Row>
            <Col>
                <Typography>Training categories:</Typography>
                <p>Trainings are grouped into these categories:</p>
                {trainingCategories.map((category) => <p>{category.name}: {category.description}</p>)}
            </Col>
        </Row>
    </Container>);
};

export default TrainingHelp;