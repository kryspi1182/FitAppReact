

import * as React from "react";

import { makeStyles } from "@material-ui/core/styles";
import { Chip } from "@material-ui/core";
import AddIcon from "@material-ui/icons/Add";
import styled from "styled-components";
import Autocomplete from "@material-ui/lab/Autocomplete";
import TextField from "@material-ui/core/TextField";

import { AutocompleteItem } from "./AutocompleteItem";
import AutocompleteIcon from "./AutocompleteIcon";
import AutocompleteItemButton from "./AutocompleteItemButton";
import AutocompleteChip from "./AutocompleteChip";

type Props = {
  items: AutocompleteItem[];
  id: string;
  title: string;
  setSelected: Function;
  selectedValues: AutocompleteItem[];
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

const ListBox = styled("ul")`
  & li {
    float: left;
    .MuiListSubheader-root {
      clear: both;
    }
  }
`;

const AutocompleteInput: React.FC<Props> = (props) => {
  const classes = useStyles();
  const [selectedValues, setSelectedValues] = React.useState(
    props.selectedValues
  );

  return (
    <Autocomplete
      multiple
      id={props.id}
      value={selectedValues}
      onChange={(event, value) => {
        setSelectedValues(value);
        props.setSelected(value);
      }}
      options={props.items}
      getOptionLabel={(option) => option.name}
      classes={{ paper: classes.paper }}
      renderInput={(params) => (
        <TextField {...params} label={props.title} variant="outlined" />
      )}
      renderOption={(option, state) => (
        <AutocompleteItemButton
          item={option}
          selected={
            selectedValues.find((item) => item.id === option.id) ? true : false
          }
        />
      )}
      renderTags={(tagValues, getTagProps) => {
        return tagValues.map((option, index) => (
          <AutocompleteChip
            {...getTagProps({ index })}
            key={option.name + "" + option.id}
            label={option.name}
          />
        ));
      }}
      ListboxComponent={ListBox}
    />
  );
};

export default AutocompleteInput;
