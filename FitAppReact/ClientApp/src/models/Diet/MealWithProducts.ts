//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import { Meal } from "./Meal";
import { Product } from "./Product";

export default interface MealWithProducts {
  meal: Meal;
  products: Product[];
}
