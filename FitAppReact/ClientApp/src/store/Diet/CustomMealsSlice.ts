//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import {
  createAsyncThunk,
  createEntityAdapter,
  createSlice,
  EntityId,
  createDraftSafeSelector,
} from "@reduxjs/toolkit";
import { PayloadAction } from "@reduxjs/toolkit/src";

import { RootState } from "../ConfigureStore";
import { Meal } from "../../models/Diet/Meal";
import { dietApi } from "../../components/api-communication/DietApi";
import { UserDietParams } from "../../models/User/UserDietParams";

const customMealsAdapter = createEntityAdapter<Meal>();

export const fetchMatchingCustomMeals = createAsyncThunk(
  "customMeal/match",
  async (params: UserDietParams) => {
    try {
      console.log(params);
      return await dietApi.getMatchingMeals(params);
    } catch (e) {
      return e.json();
    }
  }
);

export const resetCustomMeals = createAsyncThunk(
  "customMeal/reset",
  async () => {}
);

export const {
  selectAll: selectAllCustomMeals,
  selectById: selectCustomMealById,
} = customMealsAdapter.getSelectors((state: RootState) => state.customMeals);

const customMealsSlice = createSlice({
  name: "customMeals",
  initialState: customMealsAdapter.getInitialState(),
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(
        fetchMatchingCustomMeals.fulfilled,
        (state, action: PayloadAction<Array<Meal>>) => {
          if (action.payload) customMealsAdapter.upsertMany(state, action);
        }
      )
      .addCase(resetCustomMeals.fulfilled, (state, action) => {
        customMealsAdapter.removeAll(state);
      });
  },
});

export default customMealsSlice.reducer;
