

import * as React from "react";
import { Container } from "reactstrap";

import { Theme, createStyles, makeStyles } from "@material-ui/core/styles";
import List from "@material-ui/core/List";
import ListItem from "@material-ui/core/ListItem";
import ListItemText from "@material-ui/core/ListItemText";
import Divider from "@material-ui/core/Divider";

import { Product } from "../../../models/Diet/Product";

const useStyles = makeStyles({
  root: {
    width: "100%",
    maxWidth: 360,
  },
});

type Props = {
  product: Product;
};

const ProductBox: React.FC<Props> = (props) => {
  const classes = useStyles();
  return (
    <Container>
      <List className={classes.root}>
        <ListItem>
          <ListItemText primary="Calories" secondary={props.product.calories} />
        </ListItem>
        <Divider variant="inset" component="li" />
      </List>
    </Container>
  );
};
