import { createAsyncThunk, createEntityAdapter, createSlice, EntityId, createDraftSafeSelector } from '@reduxjs/toolkit';
import { RootState } from './newConfigureStore';
import { Product } from '../models/Product';
import { PayloadAction } from '@reduxjs/toolkit/src';
import authService from '../components/api-authorization/AuthorizeService';
import { dietApi } from '../components/api-communication/DietApi';
import { UserParams } from '../models/UserParams';
import { Macros } from '../models/Macros';

const productsAdapter = createEntityAdapter<Product>();

export const fetchProducts = createAsyncThunk('products', async () => {
    try {
        return await dietApi.getProducts();
    }
    catch (e) {
        return e.json();
    }
});

export const {
    selectAll: selectAllProducts,
    selectById: selectProductById,
} = productsAdapter.getSelectors((state: RootState) => state.products);

const productsSlice = createSlice({
    name: 'products',
    initialState: productsAdapter.getInitialState(),
    reducers: {},
    extraReducers: builder => {
        builder.addCase(fetchProducts.fulfilled, (state, action: PayloadAction<Array<Product>>) => {
            if(action.payload)
                productsAdapter.upsertMany(state, action);
        })
    }
});

export default productsSlice.reducer;