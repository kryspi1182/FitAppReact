//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import * as React from "react";
import { Container } from "reactstrap";

import { ListItem, List } from "@material-ui/core";
import Paper from "@material-ui/core/Paper";
import { makeStyles } from "@material-ui/core/styles";

import { Macros } from "../../../models/Diet/Macros";

const useStyles = makeStyles({
  container: {
    padding: "0px",
  },
});

export type menuOption = {
  icon: React.ComponentType;
  label: string;
  clickHandler: Function;
  clickValue: string;
};

type Props = {
  macros: Macros;
};

const MacrosBox: React.FC<Props> = (props) => {
  const classes = useStyles();
  return (
    <>
      <Container className={classes.container}>
        <Paper>
          <List>
            <ListItem>
              <h4>Macros per 100g</h4>
            </ListItem>
            <ListItem>Calories: {props.macros.calories} kcal</ListItem>
            <ListItem>Carbohydrates: {props.macros.carbohydrates} g</ListItem>
            <ListItem>Protein: {props.macros.protein} g</ListItem>
            <ListItem>Fat: {props.macros.fat} g</ListItem>
            <ListItem>Sugar: {props.macros.sugar} g</ListItem>
            <ListItem>Fibre: {props.macros.fibre} g</ListItem>
            <ListItem>Salt: {props.macros.salt} g</ListItem>
          </List>
        </Paper>
      </Container>
    </>
  );
};

export default MacrosBox;
