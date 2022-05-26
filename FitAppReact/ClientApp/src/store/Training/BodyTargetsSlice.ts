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
import { BodyTarget } from "../../models/Training/BodyTarget";

const bodyTargetsAdapter = createEntityAdapter<BodyTarget>();

export const fetchBodyTargets = createAsyncThunk("bodyTargets", async () => {
  try {
    return await trainingApi.getBodyTargets();
  } catch (e: any) {
    return e.json();
  }
});

export const {
  selectAll: selectAllBodyTargets,
  selectById: selectBodyTargetById,
} = bodyTargetsAdapter.getSelectors((state: RootState) => state.bodyTargets);

const bodyTargetsSlice = createSlice({
  name: "bodyTargets",
  initialState: bodyTargetsAdapter.getInitialState(),
  reducers: {},
  extraReducers: (builder) => {
    builder.addCase(
      fetchBodyTargets.fulfilled,
      (state, action: PayloadAction<Array<BodyTarget>>) => {
        if (action.payload) {
          bodyTargetsAdapter.upsertMany(state, action);
        }
      }
    );
  },
});

export default bodyTargetsSlice.reducer;
