import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { Container, Col, Row } from 'reactstrap';

import { makeStyles, Theme, createStyles } from '@material-ui/core/styles';
import { TextField, Select, MenuItem, FormControl, FormHelperText, InputLabel, Typography } from '@material-ui/core';
import Button from '@material-ui/core/Button';
import { selectAllWeightTargets } from '../../../store/weightTargetSlice';
import { selectAllDifficulties } from '../../../store/difficultiesSlice';
import { selectAllTrainingConditionSeverities } from '../../../store/trainingConditionSeveritiesSlice';

const useStyles = makeStyles({

});

const SavedDietsHelp: React.FC = () => {

    return(<Container>
        <Row>
            <Col>
                <Typography>Saved diets:</Typography>
                <p>Here you have access to all your saved diets.</p>
            </Col>
        </Row>
        
    </Container>);
};

export default SavedDietsHelp;