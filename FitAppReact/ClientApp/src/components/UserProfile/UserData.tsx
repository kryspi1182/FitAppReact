import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { Container, Col, Row } from 'reactstrap';

import { makeStyles } from '@material-ui/core/styles';
import { TextField, Select, MenuItem, FormControl, FormHelperText, InputLabel } from '@material-ui/core';
import Button from '@material-ui/core/Button';
import { useFormik } from 'formik';
import * as Yup from 'yup';

import {selectUser, updateUser} from '../../store/userSlice';
import {selectUserMacros, fetchUserMacros} from '../../store/userMacrosSlice';
import { selectAllMedicalConditions, fetchMedicalConditions } from '../../store/medicalConditionsSlice';
import { UserParams } from '../../models/UserParams';
import { AutocompleteItem } from '../common/Autocomplete/AutocompleteItem';
import AutocompleteInput from '../common/Autocomplete/AutocompleteInput';
import { selectAllProducts } from '../../store/productsSlice';
import { UserMedicalCondition } from '../../models/UserMedicalCondition';
import { UserUnwantedProduct } from '../../models/UserUnwantedProduct';

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

const UserData: React.FC = () => {
    const user = useSelector(selectUser);
    const classes = useStyles();
    const dispatch = useDispatch();
    const medicalConditions = useSelector(selectAllMedicalConditions);
    const products = useSelector(selectAllProducts);

    const mappedMedicalConditions = medicalConditions.map(x => {
        return {id: x.id, name: x.name} as AutocompleteItem;
    });
    const mappedProducts = products.map(x => {
        return {id: x.id, name: x.name} as AutocompleteItem;
    });
    const [selectedMedicalConditions, setSelectedMedicalConditions] = React.useState(user.medicalConditions);
    const [selectedUnwantedProducts, setSelectedUnwantedProducts] = React.useState(user.unwantedProducts);
    const [selectedMappedMedicalConditions, setSelectedMappedMedicalConditions] = React.useState(user.medicalConditions ? mappedMedicalConditions.filter(mapped => user.medicalConditions.some(med => med.medicalConditionId === mapped.id)): [] as AutocompleteItem[]);
    const [selectedMappedUnwantedProducts, setSelectedMappedUnwantedProducts] = React.useState(user.unwantedProducts ? mappedProducts.filter(mapped => user.unwantedProducts.some(prod => prod.productId === mapped.id)): [] as AutocompleteItem[]);
    const mapItemsToMedicalConditions = (items: AutocompleteItem[]) => {
        setSelectedMappedMedicalConditions(items);
        const medCons = medicalConditions.filter(medCon => items.some(item => item.id === medCon.id));
        const userMedCons = medCons.map(medCon => {
            return { userId: user.id, medicalConditionId: medCon.id } as UserMedicalCondition;
        });
        setSelectedMedicalConditions(userMedCons);
    };
    const mapItemsToUnwantedProducts = (items: AutocompleteItem[]) => {
        setSelectedMappedUnwantedProducts(items);
        const unProds = products.filter(prod => items.some(item => item.id === prod.id));
        const userUnProds = unProds.map(prod => {
            return { userId: user.id, productId: prod.id } as UserUnwantedProduct;
        });
        setSelectedUnwantedProducts(userUnProds);
    };

    React.useEffect(() => {
        if(user.weight !== 1) {
            dispatch(fetchUserMacros(null));
            
        } //TODO: first login logic to ensure data has been filled
            
    }, [user]);

    React.useEffect(() => {
        formik.setFieldValue('medicalConditions', selectedMedicalConditions);
    }, [selectedMedicalConditions]);

    React.useEffect(() => {
        formik.setFieldValue('unwantedProducts', selectedUnwantedProducts);
    }, [selectedUnwantedProducts]);

    const formik = useFormik({
        initialValues: {
            activity: user.activity,
            weight: user.weight,
            height: user.height,
            age: user.age,
            gender: user.gender,
            unwantedProducts: selectedUnwantedProducts,
            medicalConditions: selectedMedicalConditions
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
    return(<Container className={classes.container}>
        <form onSubmit={formik.handleSubmit} id="user-data-form">
            <Row>
                <Col className={classes.column}>
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
                            variant="outlined"
                        />
                    </FormControl>
                </Col>
                <Col className={classes.column}>
                    <FormControl className={classes.formControl} variant="outlined">
                        <InputLabel>Gender</InputLabel>
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
                    </FormControl>
                </Col>
                <Col className={classes.column}>
                    <FormControl className={classes.formControl} variant="outlined">
                        <InputLabel>Activity</InputLabel>
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
                    </FormControl>
                </Col>
            </Row>
            <Row>
                <Col className={classes.column}>
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
                            variant="outlined"
                        />
                    </FormControl>
                </Col>
                <Col className={classes.column}>
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
                            variant="outlined"
                        />
                    </FormControl> 
                </Col>
            </Row>
            <Row>
                <Col className={classes.column}>
                    <FormControl className={classes.formControl}>
                        <AutocompleteInput 
                            items={mappedMedicalConditions} 
                            id="medical-conditions" 
                            title="Medical conditions"
                            setSelected={mapItemsToMedicalConditions}
                            selectedValues={selectedMappedMedicalConditions}
                        />
                    </FormControl>
                </Col>
            </Row>
            <Row>
                <Col className={classes.column}>
                    <FormControl className={classes.formControl}>
                        <AutocompleteInput 
                            items={mappedProducts} 
                            id="unwanted-products" 
                            title="Unwanted products"
                            setSelected={mapItemsToUnwantedProducts}
                            selectedValues={selectedMappedUnwantedProducts}
                        />
                    </FormControl>
                </Col>
            </Row>
            <Row>
                <Col className={classes.column}>
                    <Button
                    type="submit"
                    variant="contained"
                    color="primary"
                    >
                        Submit
                    </Button>
                </Col>
            </Row> 
        </form>
        
    </Container>)
};

export default UserData;