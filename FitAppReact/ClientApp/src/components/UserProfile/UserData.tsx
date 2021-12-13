import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { Container, Col, Row } from 'reactstrap';

import { makeStyles } from '@material-ui/core/styles';
import { TextField, Select, MenuItem, FormControl, FormHelperText, InputLabel } from '@material-ui/core';
import Button from '@material-ui/core/Button';
import { useFormik } from 'formik';
import * as Yup from 'yup';

import {selectUser, updateUser} from '../../store/User/UserSlice';
import {selectUserMacros, fetchUserMacros} from '../../store/User/UserMacrosSlice';
import { selectAllMedicalConditions, fetchMedicalConditions } from '../../store/Diet/MedicalConditionsSlice';
import { UserParams } from '../../models/User/UserParams';
import { AutocompleteItem } from '../common/Autocomplete/AutocompleteItem';
import AutocompleteInput from '../common/Autocomplete/AutocompleteInput';
import { selectAllProducts } from '../../store/Diet/ProductsSlice';
import { UserMedicalCondition } from '../../models/User/UserMedicalCondition';
import { UserUnwantedProduct } from '../../models/User/UserUnwantedProduct';
import { selectAllTrainingConditions } from '../../store/Training/TrainingConditionsSlice';
import { selectAllTrainingConditionSeverities } from '../../store/Training/TrainingConditionSeveritiesSlice';
import { selectAllBodyTargets } from '../../store/Training/BodyTargetsSlice';
import { UserTrainingCondition } from '../../models/User/UserTrainingCondition';
import { DifficultyEnum } from '../../models/enums/DifficultyEnum';
import { selectAllWeightTargets } from '../../store/User/WeightTargetSlice';
import { WeightTargetEnum } from '../../models/enums/WeightTargetEnum';
import LoadingModal from '../common/Modal/LoadingModal';

const useStyles = makeStyles({
    formControl: {
        display: 'block'
    },
    container: {
        //padding: '10px'
    },
    column: {
        //margin: '10px'
    },
    formInput: {
        width: '100%'
    },
    row: {
        marginBottom: '10px',
        paddingBottom: '10px'
    },
    title: {
        textAlign: 'center'
    },
    submitButton: {
        float: 'right'
    },
    modal: {
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center',
      },
      paper: {
        border: '2px solid #000',
        backgroundColor: '#fff',
        padding: '10px',
        borderRadius: '5px'
        
      },
      content: {
        overflowY: "auto",
        maxHeight: "80vh",
        maxWidth: "inherit"
      },
      exitButton: {
        float: 'right'
      }
});

const UserData: React.FC = () => {
    const user = useSelector(selectUser);
    const classes = useStyles();
    const dispatch = useDispatch();
    const medicalConditions = useSelector(selectAllMedicalConditions);
    const products = useSelector(selectAllProducts);
    const trainingConditions = useSelector(selectAllTrainingConditions);
    const trainingConditionSeverities = useSelector(selectAllTrainingConditionSeverities);
    const bodyTargets = useSelector(selectAllBodyTargets);
    const weightTargets = useSelector(selectAllWeightTargets);

    const [firstRender, setFirstRender] = React.useState(true);
    const [loaded, setLoaded] = React.useState(false);
    const [open, setOpen] = React.useState(false);

    const handleOpen = () => {
        setOpen(true);
    };

    const mappedMedicalConditions = medicalConditions.map(x => {
        return {id: x.id, name: x.name} as AutocompleteItem;
    });
    const mappedProducts = products.map(x => {
        return {id: x.id, name: x.name} as AutocompleteItem;
    });
    const mappedTrainingConditions = trainingConditions.map(trainingCondition => {
        var trainingConditionSeverity = trainingConditionSeverities.find(severity => severity.id === trainingCondition.trainingConditionSeverityId);
        var bodyTarget = bodyTargets.find(target => target.id === trainingCondition.bodyTargetId);
        var result = {} as AutocompleteItem;
        result.id = trainingCondition.id;
        if (trainingConditionSeverity && bodyTarget) {
            result.name = trainingConditionSeverity.name + "(" + bodyTarget.target + ")";
        }
        return result;
    });

    const [selectedMedicalConditions, setSelectedMedicalConditions] = React.useState(user.medicalConditions);
    const [selectedUnwantedProducts, setSelectedUnwantedProducts] = React.useState(user.unwantedProducts);
    const [selectedTrainingConditions, setSelectedTrainingConditions] = React.useState(user.trainingConditions);
    const [selectedMappedMedicalConditions, setSelectedMappedMedicalConditions] = React.useState(user.medicalConditions ? mappedMedicalConditions.filter(mapped => user.medicalConditions.some(med => med.medicalConditionId === mapped.id)): [] as AutocompleteItem[]);
    const [selectedMappedUnwantedProducts, setSelectedMappedUnwantedProducts] = React.useState(user.unwantedProducts ? mappedProducts.filter(mapped => user.unwantedProducts.some(prod => prod.productId === mapped.id)): [] as AutocompleteItem[]);
    const [selectedMappedTrainingConditions, setSelectedMappedTrainingConditions] = React.useState(user.trainingConditions ? mappedTrainingConditions.filter(mapped => user.trainingConditions.some(cond => cond.trainingConditionId === mapped.id)): [] as AutocompleteItem[]);
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
    const mapItemsToTrainingConditions = (items: AutocompleteItem[]) => {
        setSelectedMappedTrainingConditions(items);
        const conditions = trainingConditions.filter(condition => items.some(x => x.id === condition.id));
        const userTrainingConditions = conditions.map(cond => {
            return {userId: user.id, trainingConditionId: cond.id} as UserTrainingCondition;
        });
        setSelectedTrainingConditions(userTrainingConditions);
    };

    React.useEffect(() => {
        if(user.weight !== 1) {
            dispatch(fetchUserMacros(null));
            if (firstRender)
                setFirstRender(false);
            else
                setLoaded(true);
        } //TODO: first login logic to ensure data has been filled
            
    }, [user]);

    React.useEffect(() => {
        formik.setFieldValue('medicalConditions', selectedMedicalConditions);
    }, [selectedMedicalConditions]);

    React.useEffect(() => {
        formik.setFieldValue('unwantedProducts', selectedUnwantedProducts);
    }, [selectedUnwantedProducts]);

    React.useEffect(() => {
        formik.setFieldValue('trainingConditions', selectedTrainingConditions);
    }, [selectedTrainingConditions]);

    const formik = useFormik({
        initialValues: {
            activity: user.activity,
            weight: user.weight,
            height: user.height,
            age: user.age,
            gender: user.gender,
            difficulty: user.difficultyId,
            weightTargetId: user.weightTargetId,
            unwantedProducts: selectedUnwantedProducts,
            medicalConditions: selectedMedicalConditions,
            trainingConditions: selectedTrainingConditions
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
            setLoaded(false);
            handleOpen();
            dispatch(updateUser(values));
        }
    });
    return(<Container className={classes.container}>
        {/*Did not use ModalWithContent here due to modal showing on a submit button, not a dedicated modal button*/}
        <LoadingModal open={open} setOpen={setOpen} loaded={loaded} />
        <form onSubmit={formik.handleSubmit} id="user-data-form">
            <Row className={classes.row}>
                <Col className={classes.column} xs="6">
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
                            color="primary"
                            className={classes.formInput}
                        />
                    </FormControl>
                </Col>
                <Col className={classes.column} xs="6">
                    <FormControl className={classes.formControl} variant="outlined">
                        <InputLabel>Gender</InputLabel>
                        <Select
                            id="user-data-gender"
                            label="Gender"
                            onChange={(event) => {
                                formik.setFieldValue('gender', event.target.value as number);
                            }}
                            value={formik.values.gender}
                            className={classes.formInput}
                        >
                            <MenuItem value={1}>Male</MenuItem>
                            <MenuItem value={2}>Female</MenuItem>
                        </Select>
                    </FormControl>
                </Col>
                
            </Row>
            <Row className={classes.row}>
                <Col className={classes.column} xs="6">
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
                            className={classes.formInput}
                        />
                    </FormControl>
                </Col>
                <Col className={classes.column} xs="6">
                    <FormControl className={classes.formControl} variant="outlined">
                        <InputLabel>Activity</InputLabel>
                        <Select
                            id="user-data-activity"
                            label="Activity"
                            onChange={(event) => {
                                formik.setFieldValue('activity', event.target.value as number);
                            }}
                            value={formik.values.activity}
                            className={classes.formInput}
                        >
                            <MenuItem value={1.2}>None</MenuItem>
                            <MenuItem value={1.35}>Light</MenuItem>
                            <MenuItem value={1.55}>Moderate</MenuItem>
                            <MenuItem value={1.75}>High</MenuItem>
                        </Select>
                    </FormControl>
                </Col>
            </Row>
            <Row className={classes.row}>
                <Col className={classes.column} xs="6">
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
                            className={classes.formInput}
                        />
                    </FormControl> 
                </Col>
                <Col className={classes.column} xs="6">
                    <FormControl className={classes.formControl} variant="outlined">
                        <InputLabel>Target</InputLabel>
                        <Select
                            id="user-data-target"
                            label="Target"
                            onChange={(event) => {
                                formik.setFieldValue('weightTargetId', event.target.value as number);
                            }}
                            value={formik.values.weightTargetId}
                            className={classes.formInput}
                        >
                            <MenuItem value={WeightTargetEnum.LoseWeight}>Lose weight</MenuItem>
                            <MenuItem value={WeightTargetEnum.MaintainWeight}>Maintain weight</MenuItem>
                            <MenuItem value={WeightTargetEnum.GainWeight}>Gain weight</MenuItem>
                        </Select>
                    </FormControl>
                </Col>
            </Row>
            <Row className={classes.row}>
                <Col className={classes.column} xs="12">
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
            <Row className={classes.row}>
                <Col className={classes.column} xs="12">
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
            <Row className={classes.row}>
                <Col className={classes.column} xs="12">
                    <FormControl className={classes.formControl}>
                        <AutocompleteInput 
                            items={mappedTrainingConditions}
                            id="user-training-conditions"
                            title="Noteworthy conditions"
                            setSelected={mapItemsToTrainingConditions}
                            selectedValues={selectedMappedTrainingConditions}
                        />
                    </FormControl>
                </Col>
            </Row>
            <Row className={classes.row}>
                <Col className={classes.column} xs="6">
                    <FormControl className={classes.formControl}>
                        <InputLabel>Difficulty</InputLabel>
                        <Select
                            id="user-difficulty"
                            label="Difficulty"
                            onChange={(event) => {
                                formik.setFieldValue('difficulty', event.target.value as number);
                            }}
                            value={formik.values.difficulty}
                            className={classes.formInput}
                        >
                            <MenuItem value={DifficultyEnum.Beginner}>Beginner</MenuItem>
                            <MenuItem value={DifficultyEnum.Intermediate}>Intermediate</MenuItem>
                            <MenuItem value={DifficultyEnum.Advanced}>Advanced</MenuItem>
                            <MenuItem value={DifficultyEnum.Professional}>Professional</MenuItem>
                        </Select>
                    </FormControl>
                </Col>
            </Row>
            
            <Row className={classes.row}>
                <Col className={classes.column}>
                    <Button
                    type="submit"
                    variant="contained"
                    color="primary"
                    className={classes.submitButton}
                    >
                        Submit
                    </Button>
                </Col>
            </Row> 
        </form>
        
    </Container>)
};

export default UserData;