import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { EntityId } from '@reduxjs/toolkit';

import { makeStyles } from '@material-ui/core/styles';
import { FormControl, InputLabel, MenuItem, Select, TextField } from '@material-ui/core';
import Button from '@material-ui/core/Button';
import { Container, Col, Row } from 'reactstrap';
import { useFormik } from 'formik';
import * as Yup from 'yup';
import { TrainingCondition } from '../../models/TrainingCondition';
import AutocompleteInput from '../common/Autocomplete/AutocompleteInput';
import { TrainingCategoryEnum } from '../../models/enums/TrainingCategoryEnum';
import { DifficultyEnum } from '../../models/enums/DifficultyEnum';
import { BodyTargetEnum } from '../../models/enums/BodyTargetEnum';
import { selectAllTrainingConditions } from '../../store/trainingConditionsSlice';
import { selectAllTrainingConditionSeverities } from '../../store/trainingConditionSeveritiesSlice';
import { AutocompleteItem } from '../common/Autocomplete/AutocompleteItem';
import { selectAllBodyTargets } from '../../store/bodyTargetsSlice';
import { UserTrainingParams } from '../../models/UserTrainingParams';
import { fetchMatchingTrainings } from '../../store/userTrainingsSlice';

const useStyles = makeStyles({
    formControl: {
        display: 'block'
    },
    container: {
        paddingLeft: '0px'
    },
    column: {
        //margin: '10px',
    },
    row: {
        marginBottom: '10px',
        paddingBottom: '10px'
    },
    submitButton: {
        float: 'right'
    },
    formInput: {
        width: '100%'
    }
});

type Props = {
    notify: Function
};

const CustomTraining: React.FC<Props> = (props) => {
    const dispatch = useDispatch();
    const classes = useStyles();
    const trainingConditions = useSelector(selectAllTrainingConditions);
    const trainingConditionSeverities = useSelector(selectAllTrainingConditionSeverities);
    const bodyTargets = useSelector(selectAllBodyTargets);

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

    const [selectedMappedTrainingConditions, setSelectedMappedTrainingConditions] = React.useState([] as AutocompleteItem[]);

    const mapItemsToTrainingConditions = (items: AutocompleteItem[]) => {
        setSelectedMappedTrainingConditions(items);
        formik.setFieldValue('trainingConditions', trainingConditions.filter(condition => items.some(x => x.id === condition.id)));
    };

    const formik = useFormik({
        initialValues: {
            trainingCategory: 1,
            difficulty: 1,
            trainingConditions: [] as TrainingCondition[],
            bodyTarget: 1,
        },
        onSubmit: (values) => {
            var params = {
                trainingCategory: values.trainingCategory,
                difficulty: values.difficulty,
                bodyTarget: values.bodyTarget,
                trainingConditions: values.trainingConditions
            } as UserTrainingParams;
            dispatch(fetchMatchingTrainings(params));
            props.notify(true);
        }
    });
    return(<Container className={classes.container}>
        <form onSubmit={formik.handleSubmit} id="custom-training">
            <Row className={classes.row}>
                <Col xs="6">
                    <FormControl className={classes.formControl}>
                        <InputLabel>Category</InputLabel>
                        <Select
                            id="custom-training-category"
                            label="Category"
                            onChange={(event) => {
                                formik.setFieldValue('trainingCategory', event.target.value as number);
                            }}
                            value={formik.values.trainingCategory}
                            className={classes.formInput}
                        >
                            <MenuItem value={TrainingCategoryEnum.Circuit}>Circuit</MenuItem>
                            <MenuItem value={TrainingCategoryEnum.Fartlek}>Fartlek</MenuItem>
                            <MenuItem value={TrainingCategoryEnum.Flexibility}>Flexibility</MenuItem>
                            <MenuItem value={TrainingCategoryEnum.Continuous}>Continuous</MenuItem>
                            <MenuItem value={TrainingCategoryEnum.Interval}>Interval</MenuItem>
                            <MenuItem value={TrainingCategoryEnum.Plyometric}>Plyometric</MenuItem>
                            <MenuItem value={TrainingCategoryEnum.Weight}>Weight</MenuItem>
                        </Select>
                    </FormControl>
                </Col>
                
                <Col xs="6">
                    <FormControl className={classes.formControl}>
                        <InputLabel>Body target</InputLabel>
                        <Select
                            id="custom-training-target"
                            label="Body target"
                            onChange={(event) => {
                                formik.setFieldValue('bodyTarget', event.target.value as number);
                            }}
                            value={formik.values.bodyTarget}
                            className={classes.formInput}
                        >
                            <MenuItem value={BodyTargetEnum.Arms}>Arms</MenuItem>
                            <MenuItem value={BodyTargetEnum.Back}>Back</MenuItem>
                            <MenuItem value={BodyTargetEnum.Chest}>Chest</MenuItem>
                            <MenuItem value={BodyTargetEnum.Stomach}>Stomach</MenuItem>
                            <MenuItem value={BodyTargetEnum.Legs}>Legs</MenuItem>
                            <MenuItem value={BodyTargetEnum.Cardio}>Cardio</MenuItem>
                        </Select>
                    </FormControl>
                </Col>
            </Row>
            <Row className={classes.row}>
                <Col xs="12">
                    <FormControl className={classes.formControl}>
                        <AutocompleteInput 
                            items={mappedTrainingConditions}
                            id="custom-training-conditions"
                            title="Noteworthy conditions"
                            setSelected={mapItemsToTrainingConditions}
                            selectedValues={selectedMappedTrainingConditions}
                        />
                    </FormControl>
                </Col>
            </Row>
            <Row>
                <Col xs="6">
                    <FormControl className={classes.formControl}>
                        <InputLabel>Difficulty</InputLabel>
                        <Select
                            id="custom-training-difficulty"
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
                <Col>
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
    </Container>);
};

export default CustomTraining;