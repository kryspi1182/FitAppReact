import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { EntityId } from '@reduxjs/toolkit';
import { selectAllUserTrainings } from '../../store/userTrainingsSlice';
import TrainingList from '../common/TrainingList';
import { selectAllUserSavedTrainings } from '../../store/userSavedTrainingsSlice';
import { selectAllTrainings } from '../../store/trainingsSlice';
import { selectAllTrainingConditions } from '../../store/trainingConditionsSlice';
import { selectUser } from '../../store/userSlice';

const UserSavedTrainings: React.FC = () => {
    const dispatch = useDispatch();

    const user = useSelector(selectUser);
    const allTrainings = useSelector(selectAllTrainings);
    const allTrainingConditions = useSelector(selectAllTrainingConditions);
    const savedTrainings = useSelector(selectAllUserSavedTrainings);
    const userTrainings = allTrainings.filter(training => savedTrainings.some(savedTraining => savedTraining.trainingId === training.id));
    const userTrainingConditions = allTrainingConditions.filter(x => user.trainingConditions.some(y => y.trainingConditionId === x.id))

    return(<TrainingList 
        trainings={userTrainings} 
        saveEnabled={false} 
        deleteEnabled={true}
        trainingConditions={userTrainingConditions}/>);
};

export default UserSavedTrainings;