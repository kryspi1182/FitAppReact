import * as React from "react";
import { useDispatch, useSelector } from 'react-redux';

import { Chip, ListItem, ListItemText, Typography } from "@material-ui/core";

import { Exercise } from "../../models/Exercise";
import { selectAllBodyTargets } from "../../store/bodyTargetsSlice";
import BodyTargetChip from "./BodyTargetChip";

type Props = {
    exercise: Exercise,
    series: number,
    repsPerSeries: number
};

const ExerciseBox: React.FC<Props> = (props) => {
    //TODO: body targets in chips
    const bodyTargets = useSelector(selectAllBodyTargets);
    const exerciseTargets = bodyTargets.filter(target => props.exercise.exerciseBodyTargets.some(exerciseBodyTarget => exerciseBodyTarget.bodyTargetId === target.id));
    console.log(props.exercise.exerciseBodyTargets);
    return(<ListItem>
        <ListItemText primary={props.exercise.name} />
        <span>Series: {props.series}, Reps: {props.repsPerSeries}</span>
        {exerciseTargets.map(target => {
            return (<BodyTargetChip 
                key={props.exercise.id + "" + target.id}
                label={target.target}
            />)
        })}
    </ListItem>)
};

export default ExerciseBox;