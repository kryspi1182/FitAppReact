import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { EntityId } from '@reduxjs/toolkit';

import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import { Container, Row } from 'reactstrap';

import { fetchBreakfast, fetchLunch, fetchDinner, fetchSnack, selectAllUserMeals } from '../../store/userMealsSlice';
import { selectAllCustomMeals } from '../../store/customMealsSlice';
import { selectUserMacros } from '../../store/userMacrosSlice';
import { fetchProducts } from '../../store/productsSlice';
import { DietMeals } from '../../models/DietMeals';
import { addUserSavedDiet } from '../../store/userSavedDietsSlice';
import { selectUser } from '../../store/userSlice';
import WeekDietBox from '../common/WeekDietBox';
import { DietTypeEnum } from '../../models/enums/DietTypeEnum';
import { Meal } from '../../models/Meal';
import { UserSavedDietParams } from '../../models/UserSavedDietParams';

const getRandomInt = (max: number) => {
    return Math.floor(Math.random() * max);
};

type Props = {
    generateDiet: boolean,
    setGenerateDiet: Function,
    dietType: DietTypeEnum
};

const DietResult: React.FC<Props> = (props) => {
    const dispatch = useDispatch();

    const [dietReady, setDietReady] = React.useState(false);
    const [breakfastDinners, setBreakfastDinners] = React.useState(Array<EntityId>());
    const [lunches, setLunches] = React.useState(Array<EntityId>());
    const [snacks, setSnacks] = React.useState(Array<EntityId>());
    const [dietBreakfast, setDietBreakfast] = React.useState(Array<EntityId>());
    const [dietSecondBreakfast, setDietSecondBreakfast] = React.useState(Array<EntityId>());
    const [dietLunch, setDietLunch] = React.useState(Array<EntityId>());
    const [dietSnack, setDietSnack] = React.useState(Array<EntityId>());
    const [dietDinner, setDietDinner] = React.useState(Array<EntityId>());
    const [dietSaved, setDietSaved] = React.useState(false);

    const meals = useSelector(selectAllUserMeals);
    const customMeals = useSelector(selectAllCustomMeals);
    const user = useSelector(selectUser);
    var resultMeals = [] as Meal[];
    switch(props.dietType) {
        case DietTypeEnum.Data:
            resultMeals = meals;
        break;
        case DietTypeEnum.Custom:
            resultMeals = customMeals;
        break;
    };
    const pickDietMeals = () => {
        const breakfastDinnerIds = breakfastDinners.length;
        const lunchIds = lunches.length;
        const snackIds = snacks.length;
        for(var i = 0; i < 7; i++) {
            setDietBreakfast(old => [...old, breakfastDinners[getRandomInt(breakfastDinnerIds)]]);
            setDietSecondBreakfast(old => [...old, snacks[getRandomInt(snackIds)]]);
            setDietLunch(old => [...old, lunches[getRandomInt(lunchIds)]]);
            setDietSnack(old => [...old, snacks[getRandomInt(snackIds)]]);
            setDietDinner(old => [...old, breakfastDinners[getRandomInt(breakfastDinnerIds)]]);          
        }
        setDietReady(true);
    };

    const saveDiet = () => {
        const dietMeals = [...dietBreakfast, ...dietSecondBreakfast, ...dietLunch, ...dietSnack, ...dietDinner];
        var dietName = prompt("Name your diet:", "Diet");
        if(dietName) {
            const savedDietParams = {
                userId: user.id,
                name: dietName,
                mealIds: dietMeals
            } as UserSavedDietParams;
            dispatch(addUserSavedDiet(savedDietParams));
            setDietSaved(true);
        }
    };

    React.useEffect(() => {
        if(breakfastDinners.length > 0
            && lunches.length > 0
            && snacks.length > 0) {
                pickDietMeals();
            }
    }, [breakfastDinners, lunches, snacks]);

    React.useEffect(() => {
        if(props.generateDiet && resultMeals.length > 0) {
            setBreakfastDinners(resultMeals.filter((meal) => meal.mealCategoryId === 1).map((meal) => meal.id));
            setLunches(resultMeals.filter((meal) => meal.mealCategoryId === 2).map((meal) => meal.id));
            setSnacks(resultMeals.filter((meal) => meal.mealCategoryId === 3).map((meal) => meal.id));
        }
            
    }, [props.generateDiet]);

    return (<Container>
        {((dietReady 
        && dietBreakfast.length === 7
        && dietSecondBreakfast.length === 7
        && dietLunch.length === 7
        && dietSnack.length === 7
        && dietDinner.length === 7) && 
        <Container>
            <Row>
                <WeekDietBox 
                    breakfasts={dietBreakfast}
                    secondBreakfasts={dietSecondBreakfast}
                    lunches={dietLunch}
                    snacks={dietSnack}
                    dinners={dietDinner}/>
            </Row>
            <Row>
                {(!dietSaved && <Button onClick={saveDiet}>
                    Save diet
                </Button>)}
            </Row>
        </Container>)}
    </Container>)
};

export default DietResult;