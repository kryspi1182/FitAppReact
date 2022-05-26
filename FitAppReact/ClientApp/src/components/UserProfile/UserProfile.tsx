import * as React from "react";
import { useDispatch, useSelector } from "react-redux";

import { fetchUser, selectUser } from "../../store/User/UserSlice";
import { UserStorage } from "../../models/User/UserStorage";
import UserProfileEdit from "./UserProfileEdit";
import { fetchProducts } from "../../store/Diet/ProductsSlice";
import { fetchMedicalConditions } from "../../store/Diet/MedicalConditionsSlice";
import { fetchUserSavedDiets } from "../../store/User/UserSavedDietsSlice";
import { fetchMeals } from "../../store/Diet/MealsSlice";
import { fetchExercises } from "../../store/Training/ExercisesSlice";
import { fetchBodyTargets } from "../../store/Training/BodyTargetsSlice";
import { fetchUserSavedTrainings } from "../../store/User/UserSavedTrainingsSlice";
import { fetchTrainings } from "../../store/Training/TrainingsSlice";
import { fetchTrainingCategories } from "../../store/Training/TrainingCategoriesSlice";
import { fetchDifficulties } from "../../store/Training/DifficultiesSlice";
import { fetchTrainingConditions } from "../../store/Training/TrainingConditionsSlice";
import { fetchTrainingConditionSeverities } from "../../store/Training/TrainingConditionSeveritiesSlice";
import { fetchWeightTargets } from "../../store/User/WeightTargetSlice";

const UserProfile: React.FC = () => {
  const dispatch = useDispatch();
  const storage = window.sessionStorage;
  const localStorage = window.localStorage;
  const userItem = localStorage.getItem(
    "FitAppReactuser:http://192.168.0.12:25415:FitAppReact"
  ); //TODO: figure out how to set a variable for that
  const userString = userItem !== null ? userItem : "";
  const userObj = JSON.parse(userString) as UserStorage;
  React.useEffect(() => {
    dispatch(fetchProducts());
    dispatch(fetchMedicalConditions());
    dispatch(fetchMeals());
    dispatch(fetchExercises());
    dispatch(fetchBodyTargets());
    dispatch(fetchTrainings());
    dispatch(fetchTrainingCategories());
    dispatch(fetchDifficulties());
    dispatch(fetchTrainingConditions());
    dispatch(fetchTrainingConditionSeverities());
    dispatch(fetchWeightTargets());
    if (userObj && userObj.profile.sub) {
      dispatch(fetchUser(userObj.profile.sub));
      dispatch(fetchUserSavedDiets(userObj.profile.sub));
      dispatch(fetchUserSavedTrainings(userObj.profile.sub));
    }
  }, [dispatch]);
  const user = useSelector(selectUser);
  return (
    <>
      {user && user.id !== "0" && (
        <>
          <UserProfileEdit />
        </>
      )}
    </>
  );
};

export default UserProfile;
