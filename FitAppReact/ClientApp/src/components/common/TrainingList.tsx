import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { EntityId } from '@reduxjs/toolkit';

import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';
import { Container, Row } from 'reactstrap';
import { getAllEnumEntries, getAllEnumKeys, getAllEnumValues } from 'enum-for';

import { selectAllUserTrainings } from '../../store/userTrainingsSlice';
import { TrainingCategoryEnum } from '../../models/enums/TrainingCategoryEnum';
import TrainingBox from '../common/TrainingBox';
import { Accordion, AccordionDetails, AccordionSummary, Typography } from '@material-ui/core';
import { Training } from '../../models/Training';
import { TrainingCondition } from '../../models/TrainingCondition';

type Props = {
    trainings: Training[],
    saveEnabled: boolean,
    trainingConditions: TrainingCondition[],
};

const TrainingList: React.FC<Props> = (props) => {
    const dispatch = useDispatch();
    const trainingCategoryIds = getAllEnumValues(TrainingCategoryEnum);
    const trainingCategories = getAllEnumKeys(TrainingCategoryEnum);
    return(<Container>
        {trainingCategoryIds.map(catId => {
            if (props.trainings.some(training => training.trainingCategoryId === catId)) {
                return <Accordion>
                    <AccordionSummary
                        expandIcon={<ExpandMoreIcon />}
                        aria-controls="panel1a-content"
                        id="panel1a-header"
                    >
                        <Typography>{trainingCategories[catId-1]}</Typography>
                    </AccordionSummary>
                    <AccordionDetails>
                        <Container>
                        {props.trainings
                        .filter(training => training.trainingCategoryId === catId)
                        .map(training => <TrainingBox training={training} saveEnabled={props.saveEnabled} trainingConditions={props.trainingConditions} />)}
                        </Container>
                    </AccordionDetails>
                </Accordion>
            }
        })}
    </Container>)
}

export default TrainingList;