import { createAsyncThunk, createEntityAdapter, createSlice, EntityId, createDraftSafeSelector } from '@reduxjs/toolkit';
import { PayloadAction } from '@reduxjs/toolkit/src';

import { RootState } from '../ConfigureStore';
import { userApi } from '../../components/api-communication/UserApi';
import { MedicalCondition } from '../../models/Diet/MedicalCondition';

const medicalConditionAdapter = createEntityAdapter<MedicalCondition>();

export const fetchMedicalConditions = createAsyncThunk('medicalCondition', async () => {
    try {
        return await userApi.getMedicalConditions();
    }
    catch (e) {
        return e.json();
    }
});

export const {
    selectAll: selectAllMedicalConditions,
    selectById: selectMedicalConditionById,
} = medicalConditionAdapter.getSelectors((state: RootState) => state.medicalConditions);

const medicalConditionSlice = createSlice({
    name: 'medicalConditions',
    initialState: medicalConditionAdapter.getInitialState(),
    reducers: {},
    extraReducers: builder => {
        builder.addCase(fetchMedicalConditions.fulfilled, (state, action: PayloadAction<Array<MedicalCondition>>) => {
            if(action.payload)
                medicalConditionAdapter.upsertMany(state, action);
        })
    }
});

export default medicalConditionSlice.reducer;