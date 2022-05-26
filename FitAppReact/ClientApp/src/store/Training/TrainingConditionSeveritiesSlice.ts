import {
  createAsyncThunk,
  createEntityAdapter,
  createSlice,
  EntityId,
  createDraftSafeSelector,
} from "@reduxjs/toolkit";
import { PayloadAction } from "@reduxjs/toolkit";

import { RootState } from "../configureStore";
import { trainingApi } from "../../components/api-communication/TrainingApi";
import { TrainingConditionSeverity } from "../../models/Training/TrainingConditionSeverity";

const trainingConditionSeveritiesAdapter =
  createEntityAdapter<TrainingConditionSeverity>();

export const fetchTrainingConditionSeverities = createAsyncThunk(
  "trainingConditionSeverities",
  async () => {
    try {
      return await trainingApi.getTrainingConditionSeverities();
    } catch (e: any) {
      return e.json();
    }
  }
);

export const {
  selectAll: selectAllTrainingConditionSeverities,
  selectById: selectTrainingConditionSeverityById,
} = trainingConditionSeveritiesAdapter.getSelectors(
  (state: RootState) => state.trainingConditionSeverities
);

const trainingConditionSeveritiesSlice = createSlice({
  name: "trainingConditionSeverities",
  initialState: trainingConditionSeveritiesAdapter.getInitialState(),
  reducers: {},
  extraReducers: (builder) => {
    builder.addCase(
      fetchTrainingConditionSeverities.fulfilled,
      (state, action: PayloadAction<Array<TrainingConditionSeverity>>) => {
        if (action.payload) {
          trainingConditionSeveritiesAdapter.upsertMany(state, action);
        }
      }
    );
  },
});

export default trainingConditionSeveritiesSlice.reducer;
