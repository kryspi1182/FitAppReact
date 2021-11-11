import * as React from 'react';
import { EntityId } from '@reduxjs/toolkit';
import { useSelector } from 'react-redux';

import { makeStyles } from '@material-ui/core/styles';
import Divider from '@material-ui/core/Divider';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';
import { Container } from 'reactstrap';
import { Training } from '../../models/Training';
import { selectAllExercises } from '../../store/exercisesSlice';
import ExerciseBox from './ExerciseBox';
import { Accordion, AccordionDetails, AccordionSummary, ListItem, Typography } from '@material-ui/core';
import { Exercise } from '../../models/Exercise';

type Props = {
    training: Training
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
    container: {
        flexWrap: 'wrap'
    }
});

const TrainingBox: React.FC<Props> = (props) => {
    const exercises = useSelector(selectAllExercises);
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
    return (<Accordion>
        <AccordionSummary
            expandIcon={<ExpandMoreIcon />}
            aria-controls="panel1a-content"
            id="panel1a-header"
        >
            <Typography>{props.training.name}</Typography>
        </AccordionSummary>
        <AccordionDetails  className={classes.container}>
            <Typography className={classes.description}>{props.training.description}</Typography>
            <br />
            {trainingExercises.length > 0 && exercisesWithReps.map(exercise => {
                return (<ListItem className={classes.item} key={exercise.exercise.id + "" + props.training.id}>
                    <ExerciseBox exercise={exercise.exercise} series={exercise.series} repsPerSeries={exercise.repsPerSeries}  />
                </ListItem>)
            })}
        </AccordionDetails>
    </Accordion>);
};

export default TrainingBox;