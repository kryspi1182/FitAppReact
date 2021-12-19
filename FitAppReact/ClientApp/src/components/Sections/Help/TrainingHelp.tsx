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
import InfoOutlinedIcon from "@material-ui/icons/InfoOutlined";
import WarningOutlinedIcon from "@material-ui/icons/WarningOutlined";
import CheckCircleOutlineOutlinedIcon from "@material-ui/icons/CheckCircleOutlineOutlined";

import { selectAllTrainingCategories } from "../../../store/Training/TrainingCategoriesSlice";

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

const TrainingHelp: React.FC = () => {
  const classes = useStyles();
  const trainingCategories = useSelector(selectAllTrainingCategories);

  return (
    <Container>
      <Row>
        <Col>
          <Typography className={classes.title}>Your data:</Typography>
          <p>
            We will show you a list of trainings suiting you based on the data
            you provided in your profile.
          </p>
          <Divider className={classes.divider} />
        </Col>
      </Row>
      <Row>
        <Col>
          <Typography className={classes.title}>
            Parameters of your choice:
          </Typography>
          <p>You decide what type of training you are looking for.</p>
          <Divider className={classes.divider} />
        </Col>
      </Row>
      <Row>
        <Col>
          <Typography className={classes.title}>Save training:</Typography>
          <p>Save a training to your list for easier and quicker access.</p>
          <Divider className={classes.divider} />
        </Col>
      </Row>
      <Row>
        <Col>
          <Typography className={classes.title}>
            Training categories:
          </Typography>
          <p>Trainings are grouped into these categories:</p>
          {trainingCategories.map((category) => (
            <div>
              <p className={classes.subtitle}>{category.name}:</p>
              <p>{category.description}</p>
            </div>
          ))}
          <Divider className={classes.divider} />
        </Col>
      </Row>
      <Row>
        <Col>
          <Typography className={classes.title}>Icon meaning:</Typography>
          <p>
            <CheckCircleOutlineOutlinedIcon /> - no need for extra caution.
          </p>
          <p>
            <InfoOutlinedIcon /> - this exercise targets a body part you
            mentioned in your conditions as "Unnoticable", nothing should
            happen, just in case be extra focused.
          </p>
          <p>
            <WarningOutlinedIcon /> - this exercise targets a body part you
            mentioned in your conditions as "Mild". Be careful, if you feel any
            discomfort other than standard exhaustion, reduce the intensity or
            omit the exercise completely.
          </p>
          <p>
            We do not show you any exercises/trainings which target a body part
            you mentioned in your conditions as "Severe".
          </p>
          <Divider className={classes.divider} />
        </Col>
      </Row>
    </Container>
  );
};

export default TrainingHelp;
