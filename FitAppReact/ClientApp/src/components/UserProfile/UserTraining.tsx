import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';

import { makeStyles } from '@material-ui/core/styles';

import { fetchMatchingTrainings } from '../../store/userTrainingsSlice';
import { UserTrainingParams } from '../../models/UserTrainingParams';
import { TrainingCategoryEnum } from '../../models/enums/TrainingCategoryEnum';
import { DifficultyEnum } from '../../models/enums/DifficultyEnum';
import { TrainingCondition } from '../../models/TrainingCondition';
import { BodyTargetEnum } from '../../models/enums/BodyTargetEnum';

const UserTraining: React.FC = () => {
    const dispatch = useDispatch();
    React.useEffect(() => {
        let params = {
            trainingCategory: TrainingCategoryEnum.Weight,
            difficulty: DifficultyEnum.Beginner,
            trainingConditions: [] as TrainingCondition[],
            bodyTarget: BodyTargetEnum.Arms
        } as UserTrainingParams;
        dispatch(fetchMatchingTrainings(params));
    }, []);
    return(<>
        <h2>User training component</h2>
    </>)
};

export default UserTraining;