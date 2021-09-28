import { createAsyncThunk, createEntityAdapter, createSlice, EntityId } from '@reduxjs/toolkit';
import { RootState } from './newConfigureStore';
import authService from '../components/api-authorization/AuthorizeService';

interface item {
    Id: EntityId,
    date: string,
    summary: string,
    temperatureC: number,
    temperatureF: number
};

const dataAdapter = createEntityAdapter<item>();

export const fetchData = createAsyncThunk('data/fetchData', async () => {
    try {
        const token = await authService.getAccessToken();
        const response = await fetch('weatherforecast', {
            headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
        });
        const data = await response.json();
        console.log(data);
        return data;
    }
    catch (e) {
        return e.json();
    }
});

const dataSlice = createSlice({
    name: 'data',
    initialState: dataAdapter.getInitialState(),
    reducers: {},
    extraReducers: builder => {
        builder.addCase(fetchData.fulfilled, (state, action) => {
            if (action.payload !== undefined) {
                dataAdapter.upsertMany(state, action);
            }
        })
    }
});

export default dataSlice.reducer;

export const {
    selectAll: selectAllData
} = dataAdapter.getSelectors((state: RootState) => state.data);