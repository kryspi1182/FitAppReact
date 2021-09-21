import * as connection from './ApiConnection';
import { User } from '../../models/User';
import { EntityId } from '@reduxjs/toolkit';

export const userApi = {
    async getUser(id: EntityId) {
        try {
            return await connection.api.get<User>(`user/${id}`)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w userApi " + e);
        }
    }
};