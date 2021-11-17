import { createAsyncThunk, createEntityAdapter, createSlice, EntityId, createDraftSafeSelector } from '@reduxjs/toolkit';
import { RootState } from './newConfigureStore';
import { Meal } from '../models/Meal';
import { Product } from '../models/Product';
import { PayloadAction } from '@reduxjs/toolkit/src';
import authService from '../components/api-authorization/AuthorizeService';
import { trainingApi } from '../components/api-communication/TrainingApi';
import { UserParams } from '../models/UserParams';
import { Macros } from '../models/Macros';
import { UserDietParams } from '../models/UserDietParams';
import { Training } from '../models/Training';

const trainingsAdapter = createEntityAdapter<Training>();

export const fetchTrainings = createAsyncThunk('training/all', async () => {
    try {
        return await trainingApi.getTrainings();
    }
    catch (e) {
        return e.json();
    }
});

export const {
    selectAll: selectAllTrainings,
    selectById: selectTraningById,
} = trainingsAdapter.getSelectors((state: RootState) => state.trainings);

const trainingsSlice = createSlice({
    name: 'trainings',
    initialState: trainingsAdapter.getInitialState(),
    reducers: {},
    extraReducers: builder => {
        builder.addCase(fetchTrainings.fulfilled, (state, action: PayloadAction<Array<Training>>) => {
            if (action.payload)
                trainingsAdapter.upsertMany(state, action);
        })
    }
});

export default trainingsSlice.reducer;