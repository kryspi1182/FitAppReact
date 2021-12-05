import * as React from "react";
import { useDispatch, useSelector } from 'react-redux';

import { Chip, ListItem, ListItemText, Typography } from "@material-ui/core";
import { Col, Container, Row } from 'reactstrap';

import { Exercise } from "../../models/Exercise";
import { selectAllBodyTargets } from "../../store/bodyTargetsSlice";
import BodyTargetChip from "./BodyTargetChip";
import { EntityId } from "@reduxjs/toolkit";

type Props = {
    exercise: Exercise,
    series: number,
    repsPerSeries: number,
    severity: EntityId | undefined
};

const ExerciseBox: React.FC<Props> = (props) => {
    const bodyTargets = useSelector(selectAllBodyTargets);
    const exerciseTargets = bodyTargets.filter(target => props.exercise.exerciseBodyTargets.some(exerciseBodyTarget => exerciseBodyTarget.bodyTargetId === target.id));
    console.log(props.exercise.exerciseBodyTargets);
    return(<ListItem>
        
        <Container>
            <Row>
                <Col>
                    {(props.severity && <span>{props.severity}</span>)}
                </Col>
                <Col>
                    <ListItemText primary={props.exercise.name} />
                </Col>
                <Col>
                    <span>Series: {props.series}, Reps: {props.repsPerSeries}</span>
                </Col>
            </Row>
            <Row>
                {exerciseTargets.map(target => {
                    return (<Col><BodyTargetChip 
                        key={props.exercise.id + "" + target.id}
                        label={target.target}
                    /></Col>)
                })}
            </Row>
        </Container>
        
        
    </ListItem>)
};

export default ExerciseBox;