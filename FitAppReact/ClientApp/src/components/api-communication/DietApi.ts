//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import * as connection from "./ApiConnection";
import { Macros } from "../../models/Diet/Macros";
import { UserParams } from "../../models/User/UserParams";
import { Meal } from "../../models/Diet/Meal";
import { Product } from "../../models/Diet/Product";
import { UserDietParams } from "../../models/User/UserDietParams";

export const dietApi = {
  async getMacros(userParams: UserParams) {
    try {
      return await connection.api
        .post<Macros>(`diet/macros/count`, userParams)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w dietApi " + e);
    }
  },
  async getMatchingMeals(params: UserDietParams) {
    try {
      return await connection.api
        .post<Array<Meal>>(`diet/meals/match`, params)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w dietApi " + e);
    }
  },
  async getProducts() {
    try {
      return await connection.api
        .get<Array<Product>>(`diet/products/get`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w dietApi " + e);
    }
  },
  async getMeals() {
    try {
      return await connection.api
        .get<Array<Meal>>(`diet/meals/get`)
        .then((response) => response.data);
    } catch (e) {
      console.log("error w dietApi " + e);
    }
  },
};
