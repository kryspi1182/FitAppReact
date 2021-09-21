import { createAsyncThunk, createEntityAdapter, createSlice, EntityId } from '@reduxjs/toolkit';
import { RootState } from './newConfigureStore';
import { User } from '../models/User';
import { PayloadAction } from '@reduxjs/toolkit/src';
import authService from '../components/api-authorization/AuthorizeService';
import { userApi } from '../components/api-communication/UserApi';

const initialState: User = {
    Id: "0",
    UserName: "test",
    Email: "test@mail.com",
    Height: 1,
    Weight: 1,
    Activity: 1,
    Age: 20,
    Gender: 1
};

export const fetchUser = createAsyncThunk('user/fetchUser', async (id: string) => {
    //try {
    //    const currentUser = authService.getUser() as Promise<any>;
    //    await currentUser.then(function (result) {
    //        console.log(result);
    //    }, function (err) {
    //        console.log(err);
    //    });
    //    console.log("implement fetch user: " + id);
    //    return id;
    //}
    //catch (e) {
    //    console.log("error fetch user");
    //    return null;
    //}
    try {
        return await userApi.getUser(id);
    }
    catch (e) {
        return e.json();
    }
});

const userSlice = createSlice({
    name: 'user',
    initialState: initialState,
    reducers: {},
    extraReducers: builder => {
        builder.addCase(fetchUser.fulfilled, (state, action: PayloadAction<User>) => {
            if (action.payload) {
                state.Id = action.payload.Id;
            }
        })
    }
});

export default userSlice.reducer;

export const selectUser = (state: RootState) => state.user;