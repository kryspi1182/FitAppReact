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
import { Product } from "../../models/Diet/Product";
import { dietApi } from "../../components/api-communication/DietApi";

const productsAdapter = createEntityAdapter<Product>();

export const fetchProducts = createAsyncThunk("products", async () => {
  try {
    return await dietApi.getProducts();
  } catch (e) {
    return e.json();
  }
});

export const { selectAll: selectAllProducts, selectById: selectProductById } =
  productsAdapter.getSelectors((state: RootState) => state.products);

const productsSlice = createSlice({
  name: "products",
  initialState: productsAdapter.getInitialState(),
  reducers: {},
  extraReducers: (builder) => {
    builder.addCase(
      fetchProducts.fulfilled,
      (state, action: PayloadAction<Array<Product>>) => {
        if (action.payload) productsAdapter.upsertMany(state, action);
      }
    );
  },
});

export default productsSlice.reducer;
