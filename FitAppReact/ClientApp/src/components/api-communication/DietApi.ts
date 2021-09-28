import * as connection from './ApiConnection';
import { Macros } from '../../models/Macros';
import { UserParams } from '../../models/UserParams';
import { Meal } from '../../models/Meal';
import { Product } from '../../models/Product';

export const dietApi = {
    /*async getUser(id: EntityId) {
        try {
            return await connection.api.get<User>(`user/getUser/${id}`)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w userApi " + e);
        }
    },
    async updateUser(id: EntityId, userParams: UserParams) {
        try {
            return await connection.api.put<EntityId, UserParams>(`user/updateUser/${id}`, userParams);
        }
        catch (e) {
            console.log("error w userApi " + e);
        }
    }*/
    async getMacros(userParams: UserParams) {
        try {
            return await connection.api.post<Macros>(`diet/macros/count`, userParams)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w dietApi " + e);
        }
    },
    async getMealsForBreakfast(macros: Macros) {
        try {
            return await connection.api.post<Array<Meal>>(`diet/meals/breakfast`, macros)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w dietApi " + e);
        }
    },
    async getMealsForLunch(macros: Macros) {
        try {
            return await connection.api.post<Array<Meal>>(`diet/meals/lunch`, macros)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w dietApi " + e);
        }
    },
    async getMealsForDinner(macros: Macros) {
        try {
            return await connection.api.post<Array<Meal>>(`diet/meals/dinner`, macros)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w dietApi " + e);
        }
    },
    async getMealsForSnack(macros: Macros) {
        try {
            return await connection.api.post<Array<Meal>>(`diet/meals/snack`, macros)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w dietApi " + e);
        }
    },
    async getProducts() {
        try {
            return await connection.api.get<Array<Product>>(`diet/products`)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w dietApi " + e);
        }
    }
};