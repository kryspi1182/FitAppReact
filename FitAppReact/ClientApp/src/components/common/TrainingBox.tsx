import * as React from 'react';
import { EntityId } from '@reduxjs/toolkit';
import { useSelector, useDispatch } from 'react-redux';

import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import Divider from '@material-ui/core/Divider';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';
import { Col, Container, Row } from 'reactstrap';
import { Training } from '../../models/Training';
import { selectAllExercises } from '../../store/exercisesSlice';
import ExerciseBox from './ExerciseBox';
import { Accordion, AccordionDetails, AccordionSummary, ListItem, Typography } from '@material-ui/core';
import { Exercise } from '../../models/Exercise';
import { addUserSavedTraining } from '../../store/userSavedTrainingsSlice';
import { UserSavedTrainingParams } from '../../models/UserSavedTrainingParams';
import { selectUser } from '../../store/userSlice';
import { TrainingCondition } from '../../models/TrainingCondition';
import { TrainingConditionSeverityEnum } from '../../models/enums/TrainingConditionSeverityEnum';

type Props = {
    training: Training,
    saveEnabled: boolean,
    trainingConditions: TrainingCondition[]
};

type ExerciseWithReps = {
    exercise: Exercise,
    series: number,
    repsPerSeries: number
};

const useStyles = makeStyles({
    item: {
        width: '100%',
    },
    description: {
        display: 'block'
    },
    row: {
        display: 'flex',
        flexWrap: 'wrap',
        margin: "10px"
    },
    trainingCol: {
        width: '85%',
        //display: 'block'
    },
    buttonCol: {
        maxWidth: '15%'
    }
});

const TrainingBox: React.FC<Props> = (props) => {
    //TODO: get user/custom conditions as props, pass severity to box to indicate a potentially dangerous exercise
    const dispatch = useDispatch();
    const exercises = useSelector(selectAllExercises);
    const user = useSelector(selectUser);
    const classes = useStyles();
    const trainingExercises = exercises.filter(exercise => props.training.trainingExercises
        .some(trainingExercise => trainingExercise.exerciseId === exercise.id));
    const exercisesWithReps = props.training.trainingExercises.map(trainingExercise => {
        let ex = {
            exercise: exercises.find(exercise => exercise.id === trainingExercise.exerciseId),
            series: trainingExercise.series,
            repsPerSeries: trainingExercise.repsPerSeries
        } as ExerciseWithReps;
        return ex;
    });
    const handleSave = () => {
        let params = {
            userId: user.id,
            trainingId: props.training.id
        } as UserSavedTrainingParams;
        dispatch(addUserSavedTraining(params));
    }
    return (<Row className={classes.row}>
            <Col className={classes.trainingCol}>
                <Accordion>
                    <AccordionSummary
                        expandIcon={<ExpandMoreIcon />}
                        aria-controls="panel1a-content"
                        id="panel1a-header"
                    >
                        <Typography>{props.training.name}</Typography>
                    </AccordionSummary>
                    <AccordionDetails>
                        <Container>
                            <Row>
                                <Col>
                                    <Typography className={classes.description}>{props.training.description}</Typography>
                                </Col>
                            </Row>
                            <Row>
                                <Col>
                                {trainingExercises.length > 0 && exercisesWithReps.map(exercise => {
                                    var severity = props.trainingConditions
                                        .find(trainingCondition => exercise.exercise.exerciseBodyTargets
                                            .some(x => x.bodyTargetId === trainingCondition.bodyTargetId))?.trainingConditionSeverityId;

                                    return (<Row className={classes.item} key={exercise.exercise.id + "" + props.training.id}>
                                        <ExerciseBox exercise={exercise.exercise} series={exercise.series} repsPerSeries={exercise.repsPerSeries} severity={severity}  />
                                    </Row>)
                                })}
                                </Col>
                            </Row>
                        </Container>

                        
                    </AccordionDetails>
                </Accordion>
            </Col>
            {(props.saveEnabled && <Col className={classes.buttonCol}>
                <Button onClick={handleSave}>Save</Button>
            </Col>)}
    </Row>);
};

export default TrainingBox;