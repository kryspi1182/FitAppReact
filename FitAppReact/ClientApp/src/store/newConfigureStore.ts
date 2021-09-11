import { configureStore } from '@reduxjs/toolkit';
import reduxThunk from 'redux-thunk';
import { connectRouter } from 'connected-react-router';
import { createBrowserHistory } from 'history';
import dataReducer from './dataSlice';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href') as string;
const history = createBrowserHistory({ basename: baseUrl });

const store = configureStore({
    // @ts-ignore
    middleware: (getDefaultMiddleware) =>
        getDefaultMiddleware({
            serializableCheck: false
        }).
            prepend(
                reduxThunk
            ),
    reducer: {
        data: dataReducer,
        //@ts-ignore
        router: connectRouter(history)
    },

});

export default store;

export type RootState = ReturnType<typeof store.getState>;