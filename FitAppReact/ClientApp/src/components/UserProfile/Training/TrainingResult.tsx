

import * as React from "react";
import { useDispatch, useSelector } from "react-redux";
import { TrainingCondition } from "../../../models/Training/TrainingCondition";

import { selectAllUserTrainings } from "../../../store/User/UserTrainingsSlice";
import TrainingList from "../../common/Training/TrainingList";

type Props = {
  trainingConditions: TrainingCondition[];
};

const TrainingResult: React.FC<Props> = (props) => {
  const dispatch = useDispatch();

  const userTrainings = useSelector(selectAllUserTrainings);
  return (
    <>
      {userTrainings.length > 0 && (
        <TrainingList
          trainings={userTrainings}
          saveEnabled={true}
          deleteEnabled={false}
          trainingConditions={props.trainingConditions}
        />
      )}
    </>
  );
};

export default TrainingResult;
