

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
import Button from "@material-ui/core/Button";
import InfoOutlinedIcon from "@material-ui/icons/InfoOutlined";
import WarningOutlinedIcon from "@material-ui/icons/WarningOutlined";
import CheckCircleOutlineOutlinedIcon from "@material-ui/icons/CheckCircleOutlineOutlined";

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

const SavedTrainingsHelp: React.FC = () => {
  const classes = useStyles();
  return (
    <Container>
      <Row>
        <Col>
          <Typography className={classes.title}>Saved trainings:</Typography>
          <p>Here you have access to all your saved trainings.</p>
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

export default SavedTrainingsHelp;
