import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { EntityId } from '@reduxjs/toolkit';

import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import { Container, Col, Row } from 'reactstrap';

import { fetchBreakfast, fetchLunch, fetchDinner, fetchSnack, selectAllUserMeals } from '../../store/userMealsSlice';
import { selectUserMacros } from '../../store/userMacrosSlice';
import { fetchProducts } from '../../store/productsSlice';
import { DietMeals } from '../../models/DietMeals';
import WeekDietBox from '../common/WeekDietBox';
import DietResult from './DietResult';

const getRandomInt = (max: number) => {
    return Math.floor(Math.random() * max);
};

const useStyles = makeStyles({
    button: {
        margin: '10px'
    },
});

const UserDiet: React.FC = () => {
    const classes = useStyles();
    const dispatch = useDispatch();
    const [chosenOption, setChosenOption] = React.useState("none");
    const [startDietProcess, setStartDietProcess] = React.useState(false);
    const [generateDiet, setGenerateDiet] = React.useState(false);
    const [step, setStep] = React.useState(1);
    const [title, setTitle] = React.useState("Generate diet based on your:");

    const macros = useSelector(selectUserMacros);
    const meals = useSelector(selectAllUserMeals);

    React.useEffect(() => {
        switch(step) {
            case 1:
                setTitle("Generate diet based on your:");
                break;
            case 2:
                setTitle("Almost there:");
                break;
            case 3:
                setTitle("Weekly diet:");
                break;
        }
    }, [step]);
    React.useEffect(() => {
        switch(chosenOption) {
            case "data":
                setStep(2);
                break;
            case "form":
                setStep(2);
                break;
            case "none":
                setStep(1);
                break;
        }
    }, [chosenOption]);
    React.useEffect(() => {
        dispatch(fetchProducts());
    }, []);
    React.useEffect(() => {
        if (macros.calories > 0 && startDietProcess) {
            dispatch(fetchBreakfast(macros));
            dispatch(fetchLunch(macros));
            dispatch(fetchDinner(macros));
            dispatch(fetchSnack(macros));
            setStep(3);
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
        <Row>
            <Col><h4>{title}</h4></Col>
        </Row>
        <Row>
        {(chosenOption === "none" && <>
            <Button 
                onClick={() => {setChosenOption("data")}}
                variant="contained"
                color="primary"
                className={classes.button}
            >Your data (recommended for beginners)</Button>
            <Button 
                onClick={() => {setChosenOption("form")}}
                variant="contained"
                color="primary"
                className={classes.button}
            >Macros of your choice</Button>
        </>)}
        {(chosenOption === "data" && <>
            <Button 
                onClick={() => {setChosenOption("none")}}
                variant="contained"
                color="primary"
                className={classes.button}
            >Back</Button>
            <Button 
                onClick={() => {setStartDietProcess(true)}}
                variant="contained"
                color="primary"
                className={classes.button}
            >Generate diet</Button>
        </>)}
        {(chosenOption === "form" && <>
            <Button 
                onClick={() => {setChosenOption("none")}}
                variant="contained"
                color="primary"
                className={classes.button}
            >Back</Button>
            <h3>Form will be here</h3>
        </>)}
        </Row>
        <Row>
            {(generateDiet && <DietResult generateDiet={generateDiet} setGenerateDiet={setGenerateDiet}/>)}
        </Row>
    </Container>
        
    </>)
};

export default UserDiet;