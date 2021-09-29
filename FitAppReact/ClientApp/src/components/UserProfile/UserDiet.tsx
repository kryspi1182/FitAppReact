import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { EntityId } from '@reduxjs/toolkit';

import { makeStyles } from '@material-ui/core/styles';
import { Container } from 'reactstrap';

import { fetchBreakfast, fetchLunch, fetchDinner, fetchSnack, selectAllUserMeals } from '../../store/userMealsSlice';
import { selectUserMacros } from '../../store/userMacrosSlice';
import { fetchProducts } from '../../store/productsSlice';
import { DietMeals } from '../../models/DietMeals';
import WeekDietBox from '../common/WeekDietBox';
import DietResult from './DietResult';

const getRandomInt = (max: number) => {
    return Math.floor(Math.random() * max);
};

const UserDiet: React.FC = () => {
    const dispatch = useDispatch();
    const [chosenOption, setChosenOption] = React.useState("none");
    const [startDietProcess, setStartDietProcess] = React.useState(false);
    const [generateDiet, setGenerateDiet] = React.useState(false);

    const macros = useSelector(selectUserMacros);
    const meals = useSelector(selectAllUserMeals);
    React.useEffect(() => {
        dispatch(fetchProducts());
    }, []);
    React.useEffect(() => {
        if (macros.calories > 0 && startDietProcess) {
            dispatch(fetchBreakfast(macros));
            dispatch(fetchLunch(macros));
            dispatch(fetchDinner(macros));
            dispatch(fetchSnack(macros));
            //setTimeout(() => setGenerateDiet(true), 500);
        }
    }, [startDietProcess]);
    React.useEffect(() => {
        if(meals.some((meal) => meal.mealCategoryId === 1) 
        && meals.some((meal) => meal.mealCategoryId === 2)
        && meals.some((meal) => meal.mealCategoryId === 3))
            setGenerateDiet(true);
    }, [meals]);
    return(<>
    <Container>
    <h2>User diet component</h2>
        {(chosenOption === "none" && <>
            <button onClick={() => {setChosenOption("data")}}>Generate diet based on your data (recommended for beginners)</button>
            <button onClick={() => {setChosenOption("form")}}>Generate diet based on macros of your choice</button>
        </>)}
        {(chosenOption === "data" && <>
            <button onClick={() => {setChosenOption("none")}}>Back</button>
            <button onClick={() => {setStartDietProcess(true)}}>Generate diet</button>
        </>)}
        {(chosenOption === "form" && <>
            <button onClick={() => {setChosenOption("none")}}>Back</button>
            <h3>Form will be here</h3>
        </>)}
        {(generateDiet && <DietResult generateDiet={generateDiet} setGenerateDiet={setGenerateDiet}/>)}

    </Container>
        
    </>)
};

export default UserDiet;