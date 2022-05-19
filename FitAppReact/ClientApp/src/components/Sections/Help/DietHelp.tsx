

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

const DietHelp: React.FC = () => {
  const classes = useStyles();
  return (
    <Container>
      <Row>
        <Col>
          <Typography className={classes.title}>Your data:</Typography>
          <p>
            We will calculate your daily macros based on the data you provided
            in your profile.
          </p>
          <Divider className={classes.divider} />
        </Col>
      </Row>
      <Row>
        <Col>
          <Typography className={classes.title}>
            Macros of your choice:
          </Typography>
          <p>You decide how much of each macro you want to consume daily.</p>
          <Divider className={classes.divider} />
        </Col>
      </Row>
      <Row>
        <Col>
          <Typography className={classes.title}>Save diet:</Typography>
          <p>
            Save the generated diet with a name of your choice. That diet will
            show up in the "Saved diets" tab.
          </p>
          <Divider className={classes.divider} />
        </Col>
      </Row>
    </Container>
  );
};

export default DietHelp;
