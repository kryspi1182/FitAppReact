import * as React from 'react';
import { Route } from 'react-router';

import { MuiThemeProvider, createTheme } from '@material-ui/core/styles';

import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import UserProfile from './components/UserProfile/UserProfile';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import MealDetails from './components/MealDetails';

import './custom.css';

const theme = createTheme({
    palette: {
        primary: {
            main: '#000'
        },
      secondary: {
        main: '#000'
      }
    }
  });

export default () => (
    <MuiThemeProvider theme={theme}>
        <Layout>
            <Route exact path='/' component={Home} />
            <Route path='/counter' component={Counter} />
            <AuthorizeRoute path='/user-hub' component={UserProfile} />
            <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
        </Layout>
    </MuiThemeProvider>
);
