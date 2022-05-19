

import * as React from "react";
import { EntityId } from "@reduxjs/toolkit";
import { useSelector, useDispatch } from "react-redux";

import { makeStyles } from "@material-ui/core/styles";
import Button from "@material-ui/core/Button";
import { Container, Row, Col } from "reactstrap";

import {
  deleteUserSavedDiet,
  selectAllUserSavedDiets,
} from "../../../store/User/UserSavedDietsSlice";
import { Typography } from "@material-ui/core";

const useStyles = makeStyles({
  container: {
    padding: "0px",
  },
  sectionTitle: {
    margin: "10px",
  },
  sectionContent: {
    margin: "10px",
    verticalAlign: "center",
  },
  row: {
    margin: "10px",
  },
  chip: {
    margin: "10px",
    color: "#fff",
    backgroundColor: "#000",
  },
});

const DeleteUserSavedDiets: React.FC = () => {
  const dispatch = useDispatch();
  const classes = useStyles();
  const userSavedDiets = useSelector(selectAllUserSavedDiets);
  const handleDelete = (id: EntityId) => {
    dispatch(deleteUserSavedDiet(id));
  };
  return (
    <Container>
      <Row className={classes.row}>
        <Col>
          <Typography>
            You have exceeded your limit of 5 saved diets. Delete one of your
            diets in order to save the new one.
          </Typography>
        </Col>
      </Row>
      {userSavedDiets.map((savedDiet) => (
        <Row className={classes.row}>
          <Col>{savedDiet.name}</Col>
          <Col>
            <Button
              type="button"
              variant="outlined"
              onClick={() => handleDelete(savedDiet.id)}
              color="secondary"
            >
              Delete
            </Button>
          </Col>
        </Row>
      ))}
    </Container>
  );
};

export default DeleteUserSavedDiets;
