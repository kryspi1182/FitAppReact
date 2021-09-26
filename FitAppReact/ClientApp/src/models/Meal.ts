import { EntityId } from "@reduxjs/toolkit";
import { Product } from "./Product";

export interface Meal {
    id: EntityId,
    name: string,
    description: string,
    recipe: string,
    mealCategoryId: number,
    mealProducts: Array<Product>
};