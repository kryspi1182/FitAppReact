import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';

import { selectAllUserTrainings } from '../../store/userTrainingsSlice';
import ErrorBox from '../common/ErrorBox';
import TrainingList from '../common/TrainingList';

const TrainingResult: React.FC = () => {
    const dispatch = useDispatch();

    const userTrainings = useSelector(selectAllUserTrainings);
    return(
        <>
            {(userTrainings.length > 0 && <TrainingList trainings={userTrainings} saveEnabled={true} />)}
            
        </>);
}

export default TrainingResult;