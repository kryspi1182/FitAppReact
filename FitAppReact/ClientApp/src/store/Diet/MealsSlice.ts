import {
  createAsyncThunk,
  createEntityAdapter,
  createSlice,
  EntityId,
  createDraftSafeSelector,
} from "@reduxjs/toolkit";
import { PayloadAction } from "@reduxjs/toolkit";

import { RootState } from "../configureStore";
import { Meal } from "../../models/Diet/Meal";
import { dietApi } from "../../components/api-communication/DietApi";

const mealsAdapter = createEntityAdapter<Meal>();

export const fetchMeals = createAsyncThunk("meal/all", async () => {
  try {
    return await dietApi.getMeals();
  } catch (e: any) {
    return e.json();
  }
});

export const { selectAll: selectAllMeals, selectById: selectMealById } =
  mealsAdapter.getSelectors((state: RootState) => state.meals);

const mealsSlice = createSlice({
  name: "meals",
  initialState: mealsAdapter.getInitialState(),
  reducers: {},
  extraReducers: (builder) => {
    builder.addCase(
      fetchMeals.fulfilled,
      (state, action: PayloadAction<Array<Meal>>) => {
        if (action.payload) mealsAdapter.upsertMany(state, action);
      }
    );
  },
});

export default mealsSlice.reducer;
