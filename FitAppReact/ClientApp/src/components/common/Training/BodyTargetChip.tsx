

import * as React from "react";

import { makeStyles } from "@material-ui/core/styles";
import { Chip } from "@material-ui/core";
import LocationSearchingIcon from "@material-ui/icons/LocationSearching";

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
  targetIcon: {
    color: "#fff",
    "&:hover": {
      color: "#fff",
    },
  },
});

const BodyTargetChip = (props: any) => {
  const classes = useStyles();
  return (
    <Chip
      {...props}
      className={classes.root}
      icon={<LocationSearchingIcon className={classes.targetIcon} />}
    />
  );
};

export default BodyTargetChip;
