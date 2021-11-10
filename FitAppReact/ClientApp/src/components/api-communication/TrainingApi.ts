import * as connection from './ApiConnection';
import { UserTrainingParams } from "../../models/UserTrainingParams";
import { Training } from '../../models/Training';

export const trainingApi = {
    async getMatchingTrainings(params: UserTrainingParams) {
        try {
            return await connection.api.post<Array<Training>>(`training/matchingTrainings`, params)
                .then(response => response.data); 
        }
        catch (e) {
            console.log("error w trainingApi " + e);
        }
    }
};