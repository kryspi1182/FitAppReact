

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

const SavedDietsHelp: React.FC = () => {
  const classes = useStyles();
  return (
    <Container>
      <Row>
        <Col>
          <Typography className={classes.title}>Saved diets:</Typography>
          <p>
            Here you have access to all your saved diets. You can save max 5
            diets.
          </p>
          <Divider className={classes.divider} />
        </Col>
      </Row>
    </Container>
  );
};

export default SavedDietsHelp;
