import * as React from "react";
import { useDispatch, useSelector } from "react-redux";
import { Container, Col, Row } from "reactstrap";

import { makeStyles, Theme, createStyles } from "@material-ui/core/styles";
import {
  TextField,
  Select,
  MenuItem,
  FormControl,
  FormHelperText,
  InputLabel,
  Typography,
  Divider,
} from "@material-ui/core";

import { selectAllDifficulties } from "../../../store/Training/DifficultiesSlice";
import { selectAllTrainingConditionSeverities } from "../../../store/Training/TrainingConditionSeveritiesSlice";

const useStyles = makeStyles({
  title: {
    fontSize: 20,
    textDecoration: "underline black",
    marginBottom: "10px",
  },
  subtitle: {
    fontSize: 18,
    textDecoration: "underline black",
    marginTop: "5px",
  },
  divider: {
    height: "3px",
    backgroundColor: "#000",
    marginTop: "10px",
    marginBottom: "10px",
  },
});

const DataHelp: React.FC = () => {
  const classes = useStyles();
  const difficulties = useSelector(selectAllDifficulties);
  const trainingConditionSeverities = useSelector(
    selectAllTrainingConditionSeverities
  );

  return (
    <Container>
      <Row>
        <Col>
          <Typography className={classes.title}>Activity levels:</Typography>
          <p className={classes.subtitle}>None:</p>
          <p>No physical exercise in your free time, sitting job.</p>
          <p className={classes.subtitle}>Light:</p>
          <p>
            Sporadic and light physical exercise (walking, lesiure cycling etc.)
            in your free time, sitting job.
          </p>
          <p className={classes.subtitle}>Moderate:</p>
          <p>
            Regular and more demanding physical exercise (sports, gym etc.) in
            your free time or physical job.
          </p>
          <p className={classes.subtitle}>High:</p>
          <p>
            Regular and more demanding physical exercise (sports, gym etc.) in
            your free time and physical job.
          </p>
          <Divider className={classes.divider} />
        </Col>
      </Row>
      <Row>
        <Col>
          <Typography className={classes.title}>Medical conditions:</Typography>
          <p>
            Medical conditions affecting your everyday diet. We will choose
            meals accordingly.
          </p>
          <Divider className={classes.divider} />
        </Col>
      </Row>
      <Row>
        <Col>
          <Typography className={classes.title}>Unwanted products:</Typography>
          <p>
            Products you wish to not consume. We will choose meals accordingly.
          </p>
          <Divider className={classes.divider} />
        </Col>
      </Row>
      <Row>
        <Col>
          <Typography className={classes.title}>
            Noteworthy conditions:
          </Typography>
          <p>
            Conditions which might affect your performance or health during
            exercise.
          </p>
          {trainingConditionSeverities.map((severity) => (
            <div>
              <p className={classes.subtitle}>{severity.name}:</p>
              <p>{severity.description}</p>
            </div>
          ))}
          <Divider className={classes.divider} />
        </Col>
      </Row>
      <Row>
        <Col>
          <Typography className={classes.title}>Difficulties:</Typography>
          <p>
            The level of difficulty which you feel you are comfortable with and
            most importantly, able to safely conform to (exercises can do harm
            to your body if executed incorrectly).
          </p>
          {difficulties.map((difficulty) => (
            <div>
              <p className={classes.subtitle}>{difficulty.name}:</p>
              <p>{difficulty.description}</p>
            </div>
          ))}
          <Divider className={classes.divider} />
        </Col>
      </Row>
    </Container>
  );
};

export default DataHelp;
