import * as React from 'react';

import { Container } from 'reactstrap';
import { makeStyles } from '@material-ui/core/styles';
import List from '@material-ui/core/List';
import ListItem from '@material-ui/core/ListItem';
import ListItemText from '@material-ui/core/ListItemText';
import Divider from '@material-ui/core/Divider';

import { Meal } from '../../models/Meal';

const useStyles = makeStyles({
    root: {
        width: '100%',
        maxWidth: 360
    }
});

type Props = {
    meals: Meal[],
    day: string
}

const DayDietBox: React.FC<Props> = (props) => {
    const classes = useStyles();
    return(<Container>
        <h2>{props.day}</h2>
        {(props.meals.length === 5 && <List className={classes.root}>
            <ListItem>
                <ListItemText primary="Breakfast" secondary={props.meals[0].name} />
                <h4>Products here</h4>
            </ListItem>
            <Divider variant="inset" component="li" />
            <ListItem>
                <ListItemText primary="Second breakfast" secondary={props.meals[1].name} />
                <h4>Products here</h4>
            </ListItem>
            <Divider variant="inset" component="li" />
            <ListItem>
                <ListItemText primary="Lunch" secondary={props.meals[2].name} />
                <h4>Products here</h4>
            </ListItem>
            <Divider variant="inset" component="li" />
            <ListItem>
                <ListItemText primary="Snack" secondary={props.meals[3].name} />
                <h4>Products here</h4>
            </ListItem>
            <Divider variant="inset" component="li" />
            <ListItem>
                <ListItemText primary="Dinner" secondary={props.meals[4].name} />
                <h4>Products here</h4>
            </ListItem>
            <Divider variant="inset" component="li" />
        </List>)}
        {(props.meals.length !== 5 && <h3>Error: wrong data format</h3>)}
    </Container>)
};

export default DayDietBox;