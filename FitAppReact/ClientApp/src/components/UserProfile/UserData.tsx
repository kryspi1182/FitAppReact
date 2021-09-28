import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';

import { makeStyles } from '@material-ui/core/styles';
import { TextField, Select, MenuItem, FormControl, FormHelperText } from '@material-ui/core';
import { useFormik } from 'formik';
import * as Yup from 'yup';

import {selectUser, updateUser} from '../../store/userSlice';
import {selectUserMacros, fetchUserMacros} from '../../store/userMacrosSlice';
import { UserParams } from '../../models/UserParams';

const useStyles = makeStyles({
    formControl: {
        margin: '10px',
        minWidth: 120
    }
});

const UserData: React.FC = () => {
    const user = useSelector(selectUser);
    const classes = useStyles();
    const dispatch = useDispatch();

    React.useEffect(() => {
        if(user.weight !== 1) //TODO: first login logic to ensure data has been filled
            dispatch(fetchUserMacros(null));
    }, [user]);

    const formik = useFormik({
        initialValues: {
            activity: user.activity,
            weight: user.weight,
            height: user.height,
            age: user.age,
            gender: user.gender
        } as UserParams,
        validationSchema: Yup.object({
            age: Yup.number()
                .min(10, "Little children should have their diets checked by an expert.")
                .max(130, "Are you sure you're that old?")
                .required("Providing your age is mandatory"),
            activity: Yup.number()
                .required("Providing your activity is mandatory"),
            weight: Yup.number()
                .min(30, "Are you sure you weigh less than 30 kg?")
                .max(500, "Are you sure you're providing your weight in kilograms?")
                .required("Providing your weight is mandatory"),
            height: Yup.number()
                .min(1, "Are you sure your height is less than a meter?")
                .max(2.5, "Are you sure you're that tall? Why aren't you in the NBA?")
                .required("Providing your height is mandatory"),
            gender: Yup.number()
                .required("Providing your gender is mandatory")
        }),
        validateOnChange: false,
        onSubmit: (values) => {
            dispatch(updateUser(values));
        }
    });
    return(<>
        <h2>User data component</h2>
        <form onSubmit={formik.handleSubmit} id="user-data-form">
            <FormControl className={classes.formControl}>
                <TextField
                    id="user-data-age"
                    label="Age"
                    type="number"
                    InputProps={{inputProps: {min: 10, max: 130}}}
                    onChange={(event) => {
                        if(!isNaN(parseInt(event.target.value)))
                            formik.setFieldValue('age', parseInt(event.target.value));
                    }}
                    value={formik.values.age}
                />
            </FormControl>
            <FormControl className={classes.formControl}>
                <Select
                    id="user-data-gender"
                    label="Gender"
                    onChange={(event) => {
                        formik.setFieldValue('gender', event.target.value as number);
                    }}
                    value={formik.values.gender}
                >
                    <MenuItem value={1}>Male</MenuItem>
                    <MenuItem value={2}>Female</MenuItem>
                </Select>
                <FormHelperText>Gender</FormHelperText>
            </FormControl>
            <FormControl className={classes.formControl}>
                <Select
                    id="user-data-activity"
                    label="Activity"
                    onChange={(event) => {
                        formik.setFieldValue('activity', event.target.value as number);
                    }}
                    value={formik.values.activity}
                >
                    <MenuItem value={1.2}>None</MenuItem>
                    <MenuItem value={1.35}>Light</MenuItem>
                    <MenuItem value={1.55}>Moderate</MenuItem>
                    <MenuItem value={1.75}>High</MenuItem>
                </Select>
                <FormHelperText>Activity</FormHelperText>
            </FormControl>
            <FormControl className={classes.formControl}>
                <TextField
                    id="user-data-weight"
                    label="Weight (kg)"
                    type="number"
                    InputProps={{inputProps: {min: 30, max: 500}}}
                    onChange={(event) => {
                        if(!isNaN(parseInt(event.target.value)))
                            formik.setFieldValue('weight', parseInt(event.target.value));
                    }}
                    value={formik.values.weight}
                />
            </FormControl>
            <FormControl className={classes.formControl}>
                <TextField
                    id="user-data-height"
                    label="Height (m)"
                    type="number"
                    InputProps={{inputProps: {min: 1, max: 2.5, step: 0.01}}}
                    onChange={(event) => {
                        if(!isNaN(parseFloat(event.target.value)))
                            formik.setFieldValue('height', parseFloat(event.target.value));
                    }}
                    value={formik.values.height}
                />
            </FormControl> 
            <button type="submit">Submit</button>
        </form>
        
    </>)
};

export default UserData;