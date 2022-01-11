//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import * as connection from "./ApiConnection";
import { User } from "../../models/User/User";
import { EntityId } from "@reduxjs/toolkit";
import { UserParams } from "../../models/User/UserParams";
import { MedicalCondition } from "../../models/Diet/MedicalCondition";
import { UserSavedDietParams } from "../../models/User/UserSavedDietParams";
import { UserSavedDiet } from "../../models/User/UserSavedDiet";
import { UserSavedTrainingParams } from "../../models/User/UserSavedTrainingParams";
import { UserSavedTraining } from "../../models/User/UserSavedTraining";
import { WeightTarget } from "../../models/User/WeightTarget";

export const userApi = {
  async getUser(id: EntityId) {
    try {
      return await connection.api
        .get<User>(`user/getUser/${id}`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w userApi " + e);
    }
  },
  async updateUser(id: EntityId, userParams: UserParams) {
    try {
      return await connection.api
        .put<UserParams>(`user/updateUser/${id}`, userParams)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w userApi " + e);
    }
  },
  async getMedicalConditions() {
    try {
      return await connection.api
        .get<Array<MedicalCondition>>(`user/medicalConditions`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w userApi " + e);
    }
  },
  async addUserSavedDiet(params: UserSavedDietParams) {
    try {
      return await connection.api
        .post<UserSavedDiet>(`user/userSavedDiet/add`, params)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w userApi " + e);
    }
  },
  async getUserSavedDiets(id: EntityId) {
    try {
      return await connection.api
        .get<Array<UserSavedDiet>>(`user/userSavedDiet/${id}`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w userApi " + e);
    }
  },
  async addUserSavedTraining(params: UserSavedTrainingParams) {
    try {
      return await connection.api
        .post<UserSavedTraining>(`user/userSavedTraining/add`, params)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w userApi " + e);
    }
  },
  async getUserSavedTrainings(id: EntityId) {
    try {
      return await connection.api
        .get<Array<UserSavedTraining>>(`user/userSavedTraining/${id}`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w userApi " + e);
    }
  },
  async getWeightTargets() {
    try {
      return await connection.api
        .get<Array<WeightTarget>>(`user/weightTargets`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w userApi " + e);
    }
  },
  async deleteUserSavedTraining(id: EntityId) {
    try {
      return await connection.api
        .post<UserSavedTraining>(`user/userSavedTraining/delete/${id}`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w userApi " + e);
    }
  },
  async deleteUserSavedDiet(id: EntityId) {
    try {
      return await connection.api
        .post<UserSavedDiet>(`user/userSavedDiet/delete/${id}`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w userApi " + e);
    }
  },
};
