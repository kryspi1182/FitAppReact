import { configureStore } from '@reduxjs/toolkit';
import reduxThunk from 'redux-thunk';
import { connectRouter } from 'connected-react-router';
import { createBrowserHistory } from 'history';
import userReducer from './User/UserSlice';
import userMacrosReducer from './User/UserMacrosSlice';
import userMealsReducer from './User/UserMealsSlice';
import customMealsReducer from './Diet/CustomMealsSlice';
import productsReducer from './Diet/ProductsSlice';
import medicalConditionsReducer from './Diet/MedicalConditionsSlice';
import userSavedDietsReducer from './User/UserSavedDietsSlice';
import mealsReducer from './Diet/MealsSlice';
import userTrainingsReducer from './User/UserTrainingsSlice';
import exercisesReducer from './Training/ExercisesSlice';
import bodyTargetsReducer from './Training/BodyTargetsSlice';
import userSavedTrainingsReducer from './User/UserSavedTrainingsSlice';
import trainingsReducer from './Training/TrainingsSlice';
import trainingCategoriesReducer from './Training/TrainingCategoriesSlice';
import difficultiesReducer from './Training/DifficultiesSlice';
import trainingConditionsReducer from './Training/TrainingConditionsSlice';
import trainingConditionSeveritiesReducer from './Training/TrainingConditionSeveritiesSlice';
import weightTargetReducer from './User/WeightTargetSlice';

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
        userSavedTrainings: userSavedTrainingsReducer,
        trainings: trainingsReducer,
        trainingCategories: trainingCategoriesReducer,
        difficulties: difficultiesReducer,
        trainingConditions: trainingConditionsReducer,
        trainingConditionSeverities: trainingConditionSeveritiesReducer,
        weightTargets: weightTargetReducer,
        //@ts-ignore
        router: connectRouter(history)
    },

});

export default store;

export type RootState = ReturnType<typeof store.getState>;