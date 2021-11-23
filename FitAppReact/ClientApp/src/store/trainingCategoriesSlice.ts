import { createAsyncThunk, createEntityAdapter, createSlice, EntityId, createDraftSafeSelector } from '@reduxjs/toolkit';
import { PayloadAction } from '@reduxjs/toolkit/src';
import { RootState } from './newConfigureStore';
import { trainingApi } from '../components/api-communication/TrainingApi';
import { UserTrainingParams } from '../models/UserTrainingParams';
import { Training } from '../models/Training';
import { fetchMatchingMeals } from './userMealsSlice';
import { Exercise } from '../models/Exercise';
import { BodyTarget } from '../models/BodyTarget';
import { TrainingCategory } from '../models/TrainingCategory';

const trainingCategoriesAdapter = createEntityAdapter<TrainingCategory>();

export const fetchTrainingCategories = createAsyncThunk('trainingCategories', async () => {
    try {
        return await trainingApi.getTrainingCategories();
    }
    catch (e) {
        return e.json();
    }
});

export const {
    selectAll: selectAllTrainingCategories,
    selectById: selectTrainingCategoryById,
} = trainingCategoriesAdapter.getSelectors((state: RootState) => state.trainingCategories);

const trainingCategoriesSlice = createSlice({
    name: 'trainingCategories',
    initialState: trainingCategoriesAdapter.getInitialState(),
    reducers: {},
    extraReducers: builder => {
        builder.addCase(fetchTrainingCategories.fulfilled, (state, action: PayloadAction<Array<TrainingCategory>>) => {
            if (action.payload) {
                trainingCategoriesAdapter.upsertMany(state, action);
            }
        })
    }
});

export default trainingCategoriesSlice.reducer;