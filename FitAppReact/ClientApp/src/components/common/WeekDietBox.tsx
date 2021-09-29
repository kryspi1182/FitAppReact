import * as React from 'react';
import { EntityId } from '@reduxjs/toolkit';
import { useSelector } from 'react-redux';

import { makeStyles } from '@material-ui/core/styles';
import { Container } from 'reactstrap';

import DayDietBox from './DayDietBox';
import { Meal } from '../../models/Meal';
import { selectAllUserMeals } from '../../store/userMealsSlice';
import { DietMeals } from '../../models/DietMeals';


const useStyles = makeStyles({

});

type Props = {
    breakfasts: EntityId[],
    secondBreakfasts: EntityId[],
    lunches: EntityId[],
    snacks: EntityId[],
    dinners: EntityId[],
};

const WeekDietBox: React.FC<Props> = (props) => {
    const meals = useSelector(selectAllUserMeals);
    const breakfasts = props.breakfasts.map((meal) => {
        return meals.filter((m) => m.id === meal)[0]
    });
    const secondBreakfasts = props.secondBreakfasts.map((meal) => {
        return meals.filter((m) => m.id === meal)[0]
    });
    const lunches = props.lunches.map((meal) => {
        return meals.filter((m) => m.id === meal)[0]
    });
    const snacks = props.snacks.map((meal) => {
        return meals.filter((m) => m.id === meal)[0]
    });
    const dinners = props.dinners.map((meal) => {
        return meals.filter((m) => m.id === meal)[0]
    });
    return(<Container>
            <DayDietBox meals={[breakfasts[0], secondBreakfasts[0], lunches[0], snacks[0], dinners[0]]} day="Monday" />
            <DayDietBox meals={[breakfasts[1], secondBreakfasts[1], lunches[1], snacks[1], dinners[1]]} day="Tuesday" />
            <DayDietBox meals={[breakfasts[2], secondBreakfasts[2], lunches[2], snacks[2], dinners[2]]} day="Wednesday" />
            <DayDietBox meals={[breakfasts[3], secondBreakfasts[3], lunches[3], snacks[3], dinners[3]]} day="Thursday" />
            <DayDietBox meals={[breakfasts[4], secondBreakfasts[4], lunches[4], snacks[4], dinners[4]]} day="Friday" />
            <DayDietBox meals={[breakfasts[5], secondBreakfasts[5], lunches[5], snacks[5], dinners[5]]} day="Saturday" />
            <DayDietBox meals={[breakfasts[6], secondBreakfasts[6], lunches[6], snacks[6], dinners[6]]} day="Sunday" />
            
    </Container>)
};

export default WeekDietBox;