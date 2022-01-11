//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import * as React from "react";

import { Container, Row, Col } from "reactstrap";
import { makeStyles } from "@material-ui/core/styles";
import List from "@material-ui/core/List";

import MealWithProducts from "../../../models/Diet/MealWithProducts";
import MealWithProductItem from "./MealWithProductsItem";

const useStyles = makeStyles({
  root: {
    width: "100%",
  },
  title: {
    textAlign: "center",
  },
});

type Props = {
  meals: MealWithProducts[];
  day: string;
};

const DayDietBox: React.FC<Props> = (props) => {
  const classes = useStyles();
  return (
    <Container>
      <Row>
        <Col>
          <h2 className={classes.title}>{props.day}</h2>
        </Col>
      </Row>
      <Row>
        <Col>
          {props.meals.length === 5 && (
            <List className={classes.root}>
              <MealWithProductItem label="Breakfast" meal={props.meals[0]} />

              <MealWithProductItem
                label="Second breakfast"
                meal={props.meals[1]}
              />

              <MealWithProductItem label="Lunch" meal={props.meals[2]} />

              <MealWithProductItem label="Snack" meal={props.meals[3]} />

              <MealWithProductItem label="Dinner" meal={props.meals[4]} />
            </List>
          )}
        </Col>
      </Row>
      {props.meals.length !== 5 && <h3>Error: wrong data format</h3>}
    </Container>
  );
};

export default DayDietBox;
