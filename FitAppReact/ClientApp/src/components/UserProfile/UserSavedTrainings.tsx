import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { EntityId } from '@reduxjs/toolkit';
import { selectAllUserTrainings } from '../../store/userTrainingsSlice';
import TrainingList from '../common/TrainingList';
import { selectAllUserSavedTrainings } from '../../store/userSavedTrainingsSlice';
import { selectAllTrainings } from '../../store/trainingsSlice';

const UserSavedTrainings: React.FC = () => {
    const dispatch = useDispatch();

    
    const allTrainings = useSelector(selectAllTrainings);
    const savedTrainings = useSelector(selectAllUserSavedTrainings);
    const userTrainings = allTrainings.filter(training => savedTrainings.some(savedTraining => savedTraining.trainingId === training.id));

    return(<TrainingList trainings={userTrainings} />);
};

export default UserSavedTrainings;