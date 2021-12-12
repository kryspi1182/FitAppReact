import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';

import TrainingList from '../../common/Training/TrainingList';
import { selectAllUserSavedTrainings } from '../../../store/User/UserSavedTrainingsSlice';
import { selectAllTrainings } from '../../../store/Training/TrainingsSlice';
import { selectAllTrainingConditions } from '../../../store/Training/TrainingConditionsSlice';
import { selectUser } from '../../../store/User/UserSlice';

const UserSavedTrainings: React.FC = () => {
    const dispatch = useDispatch();

    const user = useSelector(selectUser);
    const allTrainings = useSelector(selectAllTrainings);
    const allTrainingConditions = useSelector(selectAllTrainingConditions);
    const savedTrainings = useSelector(selectAllUserSavedTrainings);
    const userTrainings = allTrainings.filter(training => savedTrainings.some(savedTraining => savedTraining.trainingId === training.id));
    const userTrainingConditions = allTrainingConditions.filter(x => user.trainingConditions.some(y => y.trainingConditionId === x.id));

    return(<TrainingList 
        trainings={userTrainings} 
        saveEnabled={false} 
        deleteEnabled={true}
        trainingConditions={userTrainingConditions}/>);
};

export default UserSavedTrainings;