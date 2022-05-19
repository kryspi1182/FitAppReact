

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

const userMealsAdapter = createEntityAdapter<Meal>();

export const fetchMatchingMeals = createAsyncThunk(
  "meal/match",
  async (params: UserDietParams) => {
    try {
      return await dietApi.getMatchingMeals(params);
    } catch (e) {
      return e.json();
    }
  }
);

export const resetMeals = createAsyncThunk("meal/reset", async () => {});

export const { selectAll: selectAllUserMeals, selectById: selectUserMealById } =
  userMealsAdapter.getSelectors((state: RootState) => state.userMeals);

const userMealsSlice = createSlice({
  name: "userMeals",
  initialState: userMealsAdapter.getInitialState(),
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(
        fetchMatchingMeals.fulfilled,
        (state, action: PayloadAction<Array<Meal>>) => {
          if (action.payload) userMealsAdapter.upsertMany(state, action);
        }
      )
      .addCase(resetMeals.fulfilled, (state, action) => {
        userMealsAdapter.removeAll(state);
      });
  },
});

export default userMealsSlice.reducer;
