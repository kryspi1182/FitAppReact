import * as React from "react";
import { useDispatch, useSelector } from 'react-redux';

import { Chip, ListItem, ListItemText, Typography } from "@material-ui/core";
import { makeStyles } from '@material-ui/core/styles';
import { Col, Container, Row } from 'reactstrap';
import InfoOutlinedIcon from '@material-ui/icons/InfoOutlined';
import WarningOutlinedIcon from '@material-ui/icons/WarningOutlined';
import CheckCircleOutlineOutlinedIcon from '@material-ui/icons/CheckCircleOutlineOutlined';

import { Exercise } from "../../../models/Training/Exercise";
import { selectAllBodyTargets } from "../../../store/Training/BodyTargetsSlice";
import BodyTargetChip from "./BodyTargetChip";
import { EntityId } from "@reduxjs/toolkit";
import { TrainingConditionSeverityEnum } from "../../../models/enums/TrainingConditionSeverityEnum";

type Props = {
    exercise: Exercise,
    series: number,
    repsPerSeries: number,
    severity: EntityId | undefined
};

const useStyles = makeStyles({
    iconCol: {
        maxWidth: '10%',
        marginTop: 'auto',
        marginBottom: 'auto'
    },
    contentCol: {
        marginTop: 'auto',
        marginBottom: 'auto'
    }
});

const ExerciseBox: React.FC<Props> = (props) => {
    const classes = useStyles();
    const bodyTargets = useSelector(selectAllBodyTargets);
    const exerciseTargets = bodyTargets.filter(target => props.exercise.exerciseBodyTargets.some(exerciseBodyTarget => exerciseBodyTarget.bodyTargetId === target.id));
    console.log(props.exercise.exerciseBodyTargets);
    return(<ListItem>
        
        <Container>
            <Row>
                <Col className={classes.iconCol}>
                    {(props.severity == 0 && <CheckCircleOutlineOutlinedIcon /> )}
                    {(props.severity == TrainingConditionSeverityEnum.Unnoticeable && <InfoOutlinedIcon /> )}
                    {(props.severity == TrainingConditionSeverityEnum.Mild && <WarningOutlinedIcon /> )}
                </Col>
                <Col className={classes.contentCol}>
                    <ListItemText primary={props.exercise.name} />
                </Col>
                <Col className={classes.contentCol}>
                    <span>Series: {props.series}, Reps: {props.repsPerSeries}</span>
                </Col>
                <Col>
                {exerciseTargets.map(target => {
                    return (<Col><BodyTargetChip 
                        key={props.exercise.id + "" + target.id}
                        label={target.target}
                    /></Col>)
                })}
                </Col>
            </Row>
        </Container>
        
        
    </ListItem>)
};

export default ExerciseBox;