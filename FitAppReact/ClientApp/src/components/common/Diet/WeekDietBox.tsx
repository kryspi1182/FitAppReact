import * as React from 'react';
import { EntityId } from '@reduxjs/toolkit';
import { useSelector } from 'react-redux';

import { makeStyles } from '@material-ui/core/styles';
import { Container } from 'reactstrap';

import DayDietBox from './DayDietBox';
import { Meal } from '../../../models/Diet/Meal';
import { selectAllProducts } from '../../../store/Diet/ProductsSlice';
import { selectAllMeals } from '../../../store/Diet/MealsSlice';
import MealWithProducts from '../../../models/Diet/MealWithProducts';


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
    const meals = useSelector(selectAllMeals);
    const allProducts = useSelector(selectAllProducts);
    const [show, setShow] = React.useState(false);
    const [breakfasts, setBreakfasts] = React.useState([] as MealWithProducts[]);
    const [secondBreakfasts, setSecondBreakfasts] = React.useState([] as MealWithProducts[]);
    const [lunches, setLunches] = React.useState([] as MealWithProducts[]);
    const [snacks, setSnacks] = React.useState([] as MealWithProducts[]);
    const [dinners, setDinners] = React.useState([] as MealWithProducts[]);

    const mapMealToMealWithProducts = (m: Meal) => {
        const prod = allProducts.filter((product) => m.mealProducts.some((mealProduct) => mealProduct.productId === product.id));
        return {meal: m, products: prod} as MealWithProducts;
    };
    const mapIdsToMealsWithProducts = (mealIds: EntityId[]) => {
        return mealIds.map((meal) => {
            return mapMealToMealWithProducts(meals.filter((m) => m.id === meal)[0]);
        });
    };

    React.useEffect(() => {
        if (meals.length > 0) {
            setBreakfasts(mapIdsToMealsWithProducts(props.breakfasts));
            setSecondBreakfasts(mapIdsToMealsWithProducts(props.secondBreakfasts));
            setLunches(mapIdsToMealsWithProducts(props.lunches));
            setSnacks(mapIdsToMealsWithProducts(props.snacks));
            setDinners(mapIdsToMealsWithProducts(props.dinners));
        }
    }, [meals]);

    React.useEffect(() => {
        if (breakfasts.length === 7 && secondBreakfasts.length === 7 && lunches.length === 7 && snacks.length === 7 && dinners.length === 7)
            setShow(true);
    }, [breakfasts, secondBreakfasts, lunches, snacks, dinners]);

    return(<Container>
        {(show &&
            <Container>
                <DayDietBox meals={[breakfasts[0], secondBreakfasts[0], lunches[0], snacks[0], dinners[0]]} day="Monday" />
                <DayDietBox meals={[breakfasts[1], secondBreakfasts[1], lunches[1], snacks[1], dinners[1]]} day="Tuesday" />
                <DayDietBox meals={[breakfasts[2], secondBreakfasts[2], lunches[2], snacks[2], dinners[2]]} day="Wednesday" />
                <DayDietBox meals={[breakfasts[3], secondBreakfasts[3], lunches[3], snacks[3], dinners[3]]} day="Thursday" />
                <DayDietBox meals={[breakfasts[4], secondBreakfasts[4], lunches[4], snacks[4], dinners[4]]} day="Friday" />
                <DayDietBox meals={[breakfasts[5], secondBreakfasts[5], lunches[5], snacks[5], dinners[5]]} day="Saturday" />
                <DayDietBox meals={[breakfasts[6], secondBreakfasts[6], lunches[6], snacks[6], dinners[6]]} day="Sunday" />
            </Container>)}
    </Container>)
};

export default WeekDietBox;