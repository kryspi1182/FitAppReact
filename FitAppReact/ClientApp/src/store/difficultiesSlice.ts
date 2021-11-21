import { createAsyncThunk, createEntityAdapter, createSlice, EntityId, createDraftSafeSelector } from '@reduxjs/toolkit';
import { PayloadAction } from '@reduxjs/toolkit/src';
import { RootState } from './newConfigureStore';
import { trainingApi } from '../components/api-communication/TrainingApi';
import { UserTrainingParams } from '../models/UserTrainingParams';
import { Training } from '../models/Training';
import { fetchMatchingMeals } from './userMealsSlice';
import { Exercise } from '../models/Exercise';
import { BodyTarget } from '../models/BodyTarget';
import { Difficulty } from '../models/Difficulty';

const difficultiesAdapter = createEntityAdapter<Difficulty>();

export const fetchDifficulties = createAsyncThunk('difficulties', async () => {
    try {
        return await trainingApi.getDifficulties();
    }
    catch (e) {
        return e.json();
    }
});

export const {
    selectAll: selectAllDifficulties,
    selectById: selectDifficultyById,
} = difficultiesAdapter.getSelectors((state: RootState) => state.difficulties);

const difficultiesSlice = createSlice({
    name: 'difficulties',
    initialState: difficultiesAdapter.getInitialState(),
    reducers: {},
    extraReducers: builder => {
        builder.addCase(fetchDifficulties.fulfilled, (state, action: PayloadAction<Array<Difficulty>>) => {
            if (action.payload) {
                difficultiesAdapter.upsertMany(state, action);
            }
        })
    }
});

export default difficultiesSlice.reducer;