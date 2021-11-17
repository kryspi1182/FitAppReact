import * as connection from './ApiConnection';
import { UserTrainingParams } from "../../models/UserTrainingParams";
import { Training } from '../../models/Training';
import { Exercise } from '../../models/Exercise';
import { BodyTarget } from '../../models/BodyTarget';

export const trainingApi = {
    async getMatchingTrainings(params: UserTrainingParams) {
        try {
            return await connection.api.post<Array<Training>>(`training/matchingTrainings`, params)
                .then(response => response.data); 
        }
        catch (e) {
            console.log("error w trainingApi " + e);
        }
    },
    async getExercises() {
        try {
            return await connection.api.get<Array<Exercise>>(`training/exercises/get`)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w training api " + e);
        }
    },
    async getBodyTargets() {
        try {
            return await connection.api.get<Array<BodyTarget>>(`training/bodyTargets/get`)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w training api " + e);
        }
    },
    async getTrainings() {
        try {
            return await connection.api.get<Array<Training>>(`training/trainings/get`)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w training api " + e);
        }
    }
};