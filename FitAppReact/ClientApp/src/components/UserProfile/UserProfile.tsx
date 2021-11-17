import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { fetchUser, selectUser } from '../../store/userSlice';
import { UserStorage } from '../../models/UserStorage';
import { ProfileStorage } from '../../models/ProfileStorage';
import UserProfileEdit from './UserProfileEdit';
import { fetchProducts } from '../../store/productsSlice';
import { fetchMedicalConditions } from '../../store/medicalConditionsSlice';
import { fetchUserSavedDiets } from '../../store/userSavedDietsSlice';
import { fetchMeals } from '../../store/mealsSlice';
import { fetchExercises } from '../../store/exercisesSlice';
import { fetchBodyTargets } from '../../store/bodyTargetsSlice';
import { fetchUserSavedTrainings } from '../../store/userSavedTrainingsSlice';
import { fetchTrainings } from '../../store/trainingsSlice';

const UserProfile: React.FC = () => {
    const dispatch = useDispatch();
    const storage = window.sessionStorage;
    const localStorage = window.localStorage;
    const userString = localStorage.getItem("FitAppReactuser:http://192.168.0.15:25415:FitAppReact"); //TODO: figure out how to set a variable for that
    const userObj = JSON.parse(userString) as UserStorage;
    React.useEffect(() => {
        dispatch(fetchProducts());
        dispatch(fetchMedicalConditions());
        dispatch(fetchMeals());
        dispatch(fetchExercises());
        dispatch(fetchBodyTargets());
        dispatch(fetchTrainings());
        if (userObj && userObj.profile.sub) {
            dispatch(fetchUser(userObj.profile.sub));
            dispatch(fetchUserSavedDiets(userObj.profile.sub));
            dispatch(fetchUserSavedTrainings(userObj.profile.sub));
        }
            
    }, [dispatch]);
    const user = useSelector(selectUser);
    return (
        <>
            {(user && user.id !== "0") && <>
                <UserProfileEdit />
            </>}
        </>
        );
};

export default UserProfile;