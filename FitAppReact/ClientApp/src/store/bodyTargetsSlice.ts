import { createAsyncThunk, createEntityAdapter, createSlice, EntityId, createDraftSafeSelector } from '@reduxjs/toolkit';
import { PayloadAction } from '@reduxjs/toolkit/src';
import { RootState } from './newConfigureStore';
import { trainingApi } from '../components/api-communication/TrainingApi';
import { UserTrainingParams } from '../models/UserTrainingParams';
import { Training } from '../models/Training';
import { fetchMatchingMeals } from './userMealsSlice';
import { Exercise } from '../models/Exercise';
import { BodyTarget } from '../models/BodyTarget';

const bodyTargetsAdapter = createEntityAdapter<BodyTarget>();

export const fetchBodyTargets = createAsyncThunk('bodyTargets', async () => {
    try {
        return await trainingApi.getBodyTargets();
    }
    catch (e) {
        return e.json();
    }
});

export const {
    selectAll: selectAllBodyTargets,
    selectById: selectBodyTargetById,
} = bodyTargetsAdapter.getSelectors((state: RootState) => state.bodyTargets);

const bodyTargetsSlice = createSlice({
    name: 'bodyTargets',
    initialState: bodyTargetsAdapter.getInitialState(),
    reducers: {},
    extraReducers: builder => {
        builder.addCase(fetchBodyTargets.fulfilled, (state, action: PayloadAction<Array<BodyTarget>>) => {
            if (action.payload) {
                bodyTargetsAdapter.upsertMany(state, action);
            }
        })
    }
});

export default bodyTargetsSlice.reducer;