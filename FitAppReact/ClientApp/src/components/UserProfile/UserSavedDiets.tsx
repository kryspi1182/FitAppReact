import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { EntityId } from '@reduxjs/toolkit';

import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import Accordion from '@material-ui/core/Accordion';
import AccordionDetails from '@material-ui/core/AccordionDetails';
import AccordionSummary from '@material-ui/core/AccordionSummary';
import Typography from '@material-ui/core/Typography';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';
import { Col, Container, Row } from 'reactstrap';

import { deleteUserSavedDiet, selectAllUserSavedDiets } from '../../store/userSavedDietsSlice';
import WeekDietBox from '../common/WeekDietBox';
import { MealCategoryEnum } from '../../models/enums/MealCategoryEnum';

const useStyles = makeStyles({
    buttonCol: {
        maxWidth: '10%'
    },
    row: {
        marginBottom: '10px',
        paddingBottom: '10px'
    }
});

const UserSavedDiets: React.FC = () => {
    const dispatch = useDispatch();
    const classes = useStyles();
    const userDiets = useSelector(selectAllUserSavedDiets);
    const handleDelete = (id: EntityId) => {
        dispatch(deleteUserSavedDiet(id));
    };
    return(<Container>
        {userDiets.map(userDiet => {
            let breakfasts = [] as EntityId[];
            let secondBreakfasts = [] as EntityId[];
            let lunches = [] as EntityId[];
            let snacks = [] as EntityId[];
            let dinners = [] as EntityId[];
            for(var i = 0; i < userDiet.meals.length; i++) {
                switch(userDiet.meals[i].meal.mealCategoryId) {
                    case MealCategoryEnum.Breakfast:
                        breakfasts.push(userDiet.meals[i].mealId);
                    break;
                    case MealCategoryEnum.SecondBreakfast:
                        secondBreakfasts.push(userDiet.meals[i].mealId);
                    break;
                    case MealCategoryEnum.Lunch:
                        lunches.push(userDiet.meals[i].mealId);
                    break;
                    case MealCategoryEnum.Snack:
                        snacks.push(userDiet.meals[i].mealId);
                    break;
                    case MealCategoryEnum.Dinner:
                        dinners.push(userDiet.meals[i].mealId);
                    break;
                }
            }
            return (
                <Row className={classes.row}>
                    <Col>
            <Accordion>
                <AccordionSummary
                    expandIcon={<ExpandMoreIcon />}
                    aria-controls="panel1a-content"
                    id="panel1a-header"
                >
                    <Typography>{userDiet.name}</Typography>
                    </AccordionSummary>
                    <AccordionDetails>
                        <WeekDietBox
                            breakfasts={breakfasts}
                            secondBreakfasts={secondBreakfasts}
                            lunches={lunches}
                            snacks={snacks}
                            dinners={dinners}
                        />
                    </AccordionDetails>
            </Accordion>
            </Col>
            <Col className={classes.buttonCol}>
                <Button type="button" variant="outlined" color="secondary" onClick={() => handleDelete(userDiet.id)}>Delete</Button>
            </Col>
            </Row>
            )
        })}
    </Container>);
};

export default UserSavedDiets;