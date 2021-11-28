import * as React from 'react';
import MenuList from '@material-ui/core/MenuList';
import { ListItem, List } from '@material-ui/core';
import MenuItem from '@material-ui/core//MenuItem';
import Paper from '@material-ui/core/Paper';
import { makeStyles } from '@material-ui/core/styles';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import { Container } from 'reactstrap';
import MenuItemWithIcon from './MenuItemWithIcon';
import { Macros } from '../../models/Macros';

const useStyles = makeStyles({
    container: {
        padding: '0px'
    }
});

export type menuOption = {
    icon: React.ComponentType,
    label: string,
    clickHandler: Function,
    clickValue: string
};

type Props = {
    macros: Macros
};

const MacrosBox: React.FC<Props> = (props) => {
    const classes = useStyles();
    return(<>
        <Container className={classes.container}>
            <Paper>
                <List>
                    <ListItem><h4>Macros per 100g</h4></ListItem>
                    <ListItem>Calories: {props.macros.calories}</ListItem>
                    <ListItem>Carbohydrates: {props.macros.carbohydrates}</ListItem>
                    <ListItem>Protein: {props.macros.protein}</ListItem>
                    <ListItem>Fat: {props.macros.fat}</ListItem>
                    <ListItem>Sugar: {props.macros.sugar}</ListItem>
                    <ListItem>Fibre: {props.macros.fibre}</ListItem>
                    <ListItem>Salt: {props.macros.salt}</ListItem>
                </List>
            </Paper>
        </Container>
    </>);
};

export default MacrosBox;