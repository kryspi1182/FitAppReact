import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { EntityId } from '@reduxjs/toolkit';

import { makeStyles } from '@material-ui/core/styles';
import { FormControl, TextField } from '@material-ui/core';
import Button from '@material-ui/core/Button';
import { Container, Col, Row } from 'reactstrap';
import { useFormik } from 'formik';
import * as Yup from 'yup';
import { TrainingCondition } from '../../models/TrainingCondition';

const useStyles = makeStyles({
    formControl: {
        display: 'block'
    },
    container: {
        padding: '10px'
    },
    column: {
        margin: '10px',
    }
});

const CustomTraining: React.FC = () => {
    const dispatch = useDispatch();
    const classes = useStyles();

    /*const formik = useFormik({
        initialValues: {
            trainingCategory: 1,
            difficulty: 1,
            trainingConditions: [] as TrainingCondition[],
            bodyTarget: 1,
        },
    });*/
    return(<></>);
};

export default CustomTraining;