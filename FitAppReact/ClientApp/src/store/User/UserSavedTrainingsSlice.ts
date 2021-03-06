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
import { UserSavedTraining } from "../../models/User/UserSavedTraining";
import { userApi } from "../../components/api-communication/UserApi";
import { UserSavedTrainingParams } from "../../models/User/UserSavedTrainingParams";

const userSavedTrainingAdapter = createEntityAdapter<UserSavedTraining>();

export const fetchUserSavedTrainings = createAsyncThunk(
  "userSavedTrainings/get",
  async (id: EntityId) => {
    try {
      return await userApi.getUserSavedTrainings(id);
    } catch (e) {
      return e.json();
    }
  }
);

export const addUserSavedTraining = createAsyncThunk(
  "userSavedTrainings/add",
  async (params: UserSavedTrainingParams) => {
    try {
      return await userApi.addUserSavedTraining(params);
    } catch (e) {
      return e.json();
    }
  }
);

export const deleteUserSavedTraining = createAsyncThunk(
  "userSavedTrainings/delete",
  async (id: EntityId) => {
    try {
      return await userApi.deleteUserSavedTraining(id);
    } catch (e) {
      return e.json();
    }
  }
);

export const {
  selectAll: selectAllUserSavedTrainings,
  selectById: selectUserSavedTrainingById,
} = userSavedTrainingAdapter.getSelectors(
  (state: RootState) => state.userSavedTrainings
);

const userSavedTrainingsSlice = createSlice({
  name: "userSavedTrainings",
  initialState: userSavedTrainingAdapter.getInitialState(),
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(
        fetchUserSavedTrainings.fulfilled,
        (state, action: PayloadAction<Array<UserSavedTraining>>) => {
          if (action.payload)
            userSavedTrainingAdapter.upsertMany(state, action);
        }
      )
      .addCase(
        addUserSavedTraining.fulfilled,
        (state, action: PayloadAction<UserSavedTraining>) => {
          if (action.payload) {
            userSavedTrainingAdapter.upsertOne(state, action);
          }
        }
      )
      .addCase(
        deleteUserSavedTraining.fulfilled,
        (state, action: PayloadAction<UserSavedTraining>) => {
          if (action.payload) {
            userSavedTrainingAdapter.removeOne(state, action.payload.id);
          }
        }
      );
  },
});

export default userSavedTrainingsSlice.reducer;
