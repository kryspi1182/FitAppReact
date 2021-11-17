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
import TrainingList from '../common/TrainingList';

const TrainingResult: React.FC = () => {
    const dispatch = useDispatch();

    const userTrainings = useSelector(selectAllUserTrainings);
    return(<TrainingList trainings={userTrainings} />);
}

export default TrainingResult;