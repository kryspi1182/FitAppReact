//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import { BodyTargetEnum } from "../enums/BodyTargetEnum";
import { DifficultyEnum } from "../enums/DifficultyEnum";
import { TrainingCategoryEnum } from "../enums/TrainingCategoryEnum";
import { TrainingCondition } from "../Training/TrainingCondition";

export interface UserTrainingParams {
  trainingCategory: TrainingCategoryEnum;
  difficulty: DifficultyEnum;
  trainingConditions: TrainingCondition[];
  bodyTarget: BodyTargetEnum;
}
