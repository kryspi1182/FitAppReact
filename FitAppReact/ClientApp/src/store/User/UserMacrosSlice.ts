//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import {
  createAsyncThunk,
  createEntityAdapter,
  createSlice,
  EntityId,
} from "@reduxjs/toolkit";
import { PayloadAction } from "@reduxjs/toolkit/src";

import { RootState } from "../ConfigureStore";
import { Macros } from "../../models/Diet/Macros";
import { dietApi } from "../../components/api-communication/DietApi";
import { UserParams } from "../../models/User/UserParams";

const initialState = {
  calories: 0,
  fat: 0,
  carbohydrates: 0,
  sugar: 0,
  fibre: 0,
  protein: 0,
  salt: 0,
} as Macros;

export const fetchUserMacros = createAsyncThunk(
  "user/macros",
  async (parameter: any, thunkAPI) => {
    try {
      const state = thunkAPI.getState() as RootState;
      const params = {
        weight: state.user.weight,
        height: state.user.height,
        activity: state.user.activity,
        age: state.user.age,
        gender: state.user.gender,
        weightTargetId: state.user.weightTargetId,
      } as UserParams;
      return await dietApi.getMacros(params);
    } catch (e) {
      return e.json();
    }
  }
);

const userMacrosSlice = createSlice({
  name: "userMacros",
  initialState: initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder.addCase(
      fetchUserMacros.fulfilled,
      (state, action: PayloadAction<Macros>) => {
        if (action.payload) {
          state.calories = action.payload.calories;
          state.carbohydrates = action.payload.carbohydrates;
          state.fat = action.payload.fat;
          state.fibre = action.payload.fibre;
          state.protein = action.payload.protein;
          state.salt = action.payload.salt;
          state.sugar = action.payload.sugar;
        }
      }
    );
  },
});

export default userMacrosSlice.reducer;

export const selectUserMacros = (state: RootState) => state.userMacros;
