import { configureStore } from '@reduxjs/toolkit';
import reduxThunk from 'redux-thunk';
import { connectRouter } from 'connected-react-router';
import { createBrowserHistory } from 'history';
import dataReducer from './dataSlice';
import userReducer from './userSlice';
import userMacrosReducer from './userMacrosSlice';
import userMealsReducer from './userMealsSlice';
import customMealsReducer from './customMealsSlice';
import productsReducer from './productsSlice';
import medicalConditionsReducer from './medicalConditionsSlice';
import userSavedDietsReducer from './userSavedDietsSlice';
import mealsReducer from './mealsSlice';
import userTrainingsReducer from './userTrainingsSlice';
import exercisesReducer from './exercisesSlice';
import bodyTargetsReducer from './bodyTargetsSlice';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href') as string;
const history = createBrowserHistory({ basename: baseUrl });

const store = configureStore({
    // @ts-ignore
    middleware: (getDefaultMiddleware) =>
        getDefaultMiddleware({
            serializableCheck: false
        }).
            prepend(
                reduxThunk
            ),
    reducer: {
        data: dataReducer,
        user: userReducer,
        userMacros: userMacrosReducer,
        userMeals: userMealsReducer,
        products: productsReducer,
        medicalConditions: medicalConditionsReducer,
        customMeals: customMealsReducer,
        userSavedDiets: userSavedDietsReducer,
        meals: mealsReducer,
        userTrainings: userTrainingsReducer,
        exercises: exercisesReducer,
        bodyTargets: bodyTargetsReducer,
        //@ts-ignore
        router: connectRouter(history)
    },

});

export default store;

export type RootState = ReturnType<typeof store.getState>;