

import * as connection from "./ApiConnection";
import { UserTrainingParams } from "../../models/User/UserTrainingParams";
import { Training } from "../../models/Training/Training";
import { Exercise } from "../../models/Training/Exercise";
import { BodyTarget } from "../../models/Training/BodyTarget";
import { TrainingCategory } from "../../models/Training/TrainingCategory";
import { Difficulty } from "../../models/Training/Difficulty";
import { TrainingCondition } from "../../models/Training/TrainingCondition";
import { TrainingConditionSeverity } from "../../models/Training/TrainingConditionSeverity";

export const trainingApi = {
  async getMatchingTrainings(params: UserTrainingParams) {
    try {
      return await connection.api
        .post<Array<Training>>(`training/matchingTrainings`, params)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w trainingApi " + e);
    }
  },
  async getMatchingTrainingsUserData(params: UserTrainingParams) {
    try {
      return await connection.api
        .post<Array<Training>>(`training/matchingTrainings/user`, params)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w trainingApi " + e);
    }
  },
  async getExercises() {
    try {
      return await connection.api
        .get<Array<Exercise>>(`training/exercises/get`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w training api " + e);
    }
  },
  async getBodyTargets() {
    try {
      return await connection.api
        .get<Array<BodyTarget>>(`training/bodyTargets/get`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w training api " + e);
    }
  },
  async getTrainings() {
    try {
      return await connection.api
        .get<Array<Training>>(`training/trainings/get`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w training api " + e);
    }
  },
  async getTrainingCategories() {
    try {
      return await connection.api
        .get<Array<TrainingCategory>>(`training/trainingCategories/get`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w training api " + e);
    }
  },
  async getDifficulties() {
    try {
      return await connection.api
        .get<Array<Difficulty>>(`training/difficulties/get`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w training api " + e);
    }
  },
  async getTrainingConditions() {
    try {
      return await connection.api
        .get<Array<TrainingCondition>>(`training/trainingConditions/get`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w training api " + e);
    }
  },
  async getTrainingConditionSeverities() {
    try {
      return await connection.api
        .get<Array<TrainingConditionSeverity>>(
          `training/trainingConditionSeverities/get`
        )
        .then((response) => response.data);
    } catch (e) {
      console.log("error w training api " + e);
    }
  },
};
