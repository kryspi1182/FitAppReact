import * as React from 'react';

import { Container } from 'reactstrap';
import { makeStyles } from '@material-ui/core/styles';
import List from '@material-ui/core/List';
import ListItem from '@material-ui/core/ListItem';
import ListItemText from '@material-ui/core/ListItemText';
import Divider from '@material-ui/core/Divider';
import { Chip } from '@material-ui/core';

import { Meal } from '../../models/Meal';
import MealWithProducts from '../../models/MealWithProducts';
import MealWithProductItem from './MealWithProductsItem';

const useStyles = makeStyles({
    root: {
        width: '100%',
    }
});

type Props = {
    meals: MealWithProducts[],
    day: string
}

const DayDietBox: React.FC<Props> = (props) => {
    const classes = useStyles();
    return(<Container>
        <h2>{props.day}</h2>
        {(props.meals.length === 5 && <List className={classes.root}>
            <MealWithProductItem label="Breakfast" meal={props.meals[0]}/>
            <Divider variant="inset" component="li" />
            <MealWithProductItem label="Second breakfast" meal={props.meals[1]}/>
            <Divider variant="inset" component="li" />
            <MealWithProductItem label="Lunch" meal={props.meals[2]}/>
            <Divider variant="inset" component="li" />
            <MealWithProductItem label="Snack" meal={props.meals[3]}/>
            <Divider variant="inset" component="li" />
            <MealWithProductItem label="Dinner" meal={props.meals[4]}/>
            <Divider variant="inset" component="li" />
        </List>)}
        {(props.meals.length !== 5 && <h3>Error: wrong data format</h3>)}
    </Container>)
};

export default DayDietBox;