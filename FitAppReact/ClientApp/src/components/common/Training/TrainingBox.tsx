//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import * as React from "react";
import { EntityId } from "@reduxjs/toolkit";
import { useSelector, useDispatch } from "react-redux";
import { Col, Container, Row } from "reactstrap";

import { makeStyles } from "@material-ui/core/styles";
import Button from "@material-ui/core/Button";
import Divider from "@material-ui/core/Divider";
import ExpandMoreIcon from "@material-ui/icons/ExpandMore";
import {
  Accordion,
  AccordionDetails,
  AccordionSummary,
  ListItem,
  Typography,
} from "@material-ui/core";

import { Training } from "../../../models/Training/Training";
import { selectAllExercises } from "../../../store/Training/ExercisesSlice";
import ExerciseBox from "./ExerciseBox";
import { Exercise } from "../../../models/Training/Exercise";
import {
  addUserSavedTraining,
  deleteUserSavedTraining,
  selectAllUserSavedTrainings,
} from "../../../store/User/UserSavedTrainingsSlice";
import { UserSavedTrainingParams } from "../../../models/User/UserSavedTrainingParams";
import { selectUser } from "../../../store/User/UserSlice";
import { TrainingCondition } from "../../../models/Training/TrainingCondition";

type Props = {
  training: Training;
  saveEnabled: boolean;
  deleteEnabled: boolean;
  trainingConditions: TrainingCondition[];
};

type ExerciseWithReps = {
  exercise: Exercise;
  series: number;
  repsPerSeries: number;
};

const useStyles = makeStyles({
  item: {
    width: "100%",
  },
  description: {
    display: "block",
  },
  row: {
    display: "flex",
    flexWrap: "wrap",
    marginBottom: "10px",
    paddingBottom: "10px",
  },
  trainingCol: {
    width: "85%",
    //display: 'block'
  },
  buttonCol: {
    maxWidth: "15%",
  },
});

const TrainingBox: React.FC<Props> = (props) => {
  const dispatch = useDispatch();
  const exercises = useSelector(selectAllExercises);
  const userSavedTrainings = useSelector(selectAllUserSavedTrainings);
  const user = useSelector(selectUser);
  const classes = useStyles();
  const trainingExercises = exercises.filter((exercise) =>
    props.training.trainingExercises.some(
      (trainingExercise) => trainingExercise.exerciseId === exercise.id
    )
  );
  const exercisesWithReps = props.training.trainingExercises.map(
    (trainingExercise) => {
      let ex = {
        exercise: exercises.find(
          (exercise) => exercise.id === trainingExercise.exerciseId
        ),
        series: trainingExercise.series,
        repsPerSeries: trainingExercise.repsPerSeries,
      } as ExerciseWithReps;
      return ex;
    }
  );
  const handleSave = () => {
    let params = {
      userId: user.id,
      trainingId: props.training.id,
    } as UserSavedTrainingParams;
    dispatch(addUserSavedTraining(params));
    setSaved(true);
  };

  const handleDelete = () => {
    var training = userSavedTrainings.find(
      (x) => x.trainingId === props.training.id
    );
    if (training) dispatch(deleteUserSavedTraining(training.id));
  };

  const [saved, setSaved] = React.useState(false);

  React.useEffect(() => {
    if (userSavedTrainings.some((x) => x.trainingId === props.training.id))
      setSaved(true);
  }, [userSavedTrainings]);

  return (
    <Row className={classes.row}>
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
                  <Typography className={classes.description}>
                    {props.training.description}
                  </Typography>
                </Col>
              </Row>
              <Row>
                <Col>
                  {trainingExercises.length > 0 &&
                    exercisesWithReps.map((exercise) => {
                      var severity = props.trainingConditions.find(
                        (trainingCondition) =>
                          exercise.exercise.exerciseBodyTargets.some(
                            (x) =>
                              x.bodyTargetId === trainingCondition.bodyTargetId
                          )
                      );

                      let severityId = 0 as EntityId;
                      if (severity)
                        severityId = severity.trainingConditionSeverityId;

                      return (
                        <Row
                          className={classes.item}
                          key={exercise.exercise.id + "" + props.training.id}
                        >
                          <ExerciseBox
                            exercise={exercise.exercise}
                            series={exercise.series}
                            repsPerSeries={exercise.repsPerSeries}
                            severity={severityId}
                          />
                        </Row>
                      );
                    })}
                </Col>
              </Row>
            </Container>
          </AccordionDetails>
        </Accordion>
      </Col>
      {props.saveEnabled && !saved && (
        <Col className={classes.buttonCol}>
          <Button
            type="button"
            variant="outlined"
            color="secondary"
            onClick={handleSave}
          >
            Save
          </Button>
        </Col>
      )}
      {props.saveEnabled && saved && (
        <Col className={classes.buttonCol}>
          <Button type="button" variant="outlined" color="secondary" disabled>
            Saved
          </Button>
        </Col>
      )}
      {props.deleteEnabled && saved && (
        <Col className={classes.buttonCol}>
          <Button
            type="button"
            variant="outlined"
            color="secondary"
            onClick={handleDelete}
          >
            Delete
          </Button>
        </Col>
      )}
    </Row>
  );
};

export default TrainingBox;
