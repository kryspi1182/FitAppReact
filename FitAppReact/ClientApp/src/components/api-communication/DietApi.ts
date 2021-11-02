import * as connection from './ApiConnection';
import { Macros } from '../../models/Macros';
import { UserParams } from '../../models/UserParams';
import { Meal } from '../../models/Meal';
import { Product } from '../../models/Product';
import { UserDietParams } from '../../models/UserDietParams';

export const dietApi = {
    async getMacros(userParams: UserParams) {
        try {
            return await connection.api.post<Macros>(`diet/macros/count`, userParams)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w dietApi " + e);
        }
    },
    async getMatchingMeals(params: UserDietParams) {
        try {
            return await connection.api.post<Array<Meal>>(`diet/meals/match`, params)
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
            return await connection.api.get<Array<Product>>(`diet/products/get`)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w dietApi " + e);
        }
    },
    async getMeals() {
        try {
            return await connection.api.get<Array<Meal>>(`diet/meals/get`)
                .then(response => response.data);
        }
        catch (e) {
            console.log("error w dietApi " + e);
        }
    }
};