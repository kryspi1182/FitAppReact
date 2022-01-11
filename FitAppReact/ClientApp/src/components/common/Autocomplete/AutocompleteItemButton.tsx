//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import * as React from "react";

import { makeStyles } from "@material-ui/core/styles";
import { Chip } from "@material-ui/core";
import AddIcon from "@material-ui/icons/Add";

import { AutocompleteItem } from "./AutocompleteItem";
import AutocompleteIcon from "./AutocompleteIcon";

type Props = {
  item: AutocompleteItem;
  selected: boolean;
};

const useStyles = makeStyles({
  paper: {
    border: "5px solid black",
  },
  root: {
    borderRadius: "5px",
    margin: "5px",
    padding: "5px",
    background: "#000",
    color: "#fff",
    justifyContent: "center",
  },
  icon: {
    margin: "auto",
    height: "25px",
    "&:hover": {
      color: "#fff",
    },
  },
  selected: {
    color: "#fff",
    background: "#000",
    borderRadius: "5px",
    border: "1px solid #000",
    padding: "5px",
    minHeight: "50px",
    minWidth: "100px",
    display: "flex",
  },
  unselected: {
    color: "#000",
    background: "#fff",
    borderRadius: "5px",
    border: "1px solid #000",
    padding: "5px",
    minHeight: "50px",
    minWidth: "100px",
    display: "flex",
    "&:hover": {
      color: "#fff",
      background: "#000",
    },
  },
  itemDiv: {
    flex: "1",
    margin: "auto",
    height: "25px",
  },
});

const AutocompleteItemButton: React.FC<Props> = (props) => {
  const classes = useStyles();
  const iconProps = { style: { color: "#ff0000" } };
  return (
    <div className={props.selected ? classes.selected : classes.unselected}>
      <div className={classes.itemDiv}>{props.item.name}</div>
      <div className={classes.icon}>{<AutocompleteIcon icon={AddIcon} />}</div>
    </div>
  );
};

export default AutocompleteItemButton;
