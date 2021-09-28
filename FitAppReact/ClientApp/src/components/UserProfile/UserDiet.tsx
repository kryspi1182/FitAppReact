import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';

import { makeStyles } from '@material-ui/core/styles';
import { Container } from 'reactstrap';

import { fetchBreakfast, fetchLunch, fetchDinner, fetchSnack, selectAllUserMeals } from '../../store/userMealsSlice';
import { selectUserMacros } from '../../store/userMacrosSlice';
import { fetchProducts } from '../../store/productsSlice';

const UserDiet: React.FC = () => {
    const dispatch = useDispatch();
    const [chosenOption, setChosenOption] = React.useState("none");
    const [showDiet, setShowDiet] = React.useState(false);
    const macros = useSelector(selectUserMacros);
    const generateDiet = () => {
        //setShowDiet(false);
        setShowDiet(true);
    };
    const meals = useSelector(selectAllUserMeals);
    React.useEffect(() => {
        dispatch(fetchProducts());
    }, []);
    React.useEffect(() => {
        if (macros.calories > 0) {
            dispatch(fetchBreakfast(macros));
            dispatch(fetchLunch(macros));
            dispatch(fetchDinner(macros));
            dispatch(fetchSnack(macros));
        }
    }, [showDiet]);

    return(<>
    <Container>
    <h2>User diet component</h2>
        {(chosenOption === "none" && <>
            <button onClick={() => {setChosenOption("data")}}>Generate diet based on your data (recommended for beginners)</button>
            <button onClick={() => {setChosenOption("form")}}>Generate diet based on macros of your choice</button>
        </>)}
        {(chosenOption === "data" && <>
            <button onClick={() => {setChosenOption("none")}}>Back</button>
            <button onClick={() => {generateDiet()}}>Generate diet</button>
        </>)}
        {(chosenOption === "form" && <>
            <button onClick={() => {setChosenOption("none")}}>Back</button>
            <h3>Form will be here</h3>
        </>)}

    </Container>
        
    </>)
};

export default UserDiet;