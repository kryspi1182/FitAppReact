import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';

import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import { Container, Col, Row } from 'reactstrap';

import { fetchMatchingTrainings, selectAllUserTrainings } from '../../store/userTrainingsSlice';
import { UserTrainingParams } from '../../models/UserTrainingParams';
import { TrainingCategoryEnum } from '../../models/enums/TrainingCategoryEnum';
import { DifficultyEnum } from '../../models/enums/DifficultyEnum';
import { TrainingCondition } from '../../models/TrainingCondition';
import { BodyTargetEnum } from '../../models/enums/BodyTargetEnum';
import TrainingBox from '../common/TrainingBox';
import TrainingResult from './TrainingResult';

const useStyles = makeStyles({
    button: {
        margin: '10px'
    },
});

const UserTraining: React.FC = () => {
    const dispatch = useDispatch();
    const classes = useStyles();
    const [chosenOption, setChosenOption] = React.useState("none");
    const [step, setStep] = React.useState(1);
    const [title, setTitle] = React.useState("Find trainings based on:");
    const [startTrainingProcess, setStartTrainingProcess] = React.useState(false);
    const [showTraining, setShowTraining] = React.useState(false);

    const userTrainings = useSelector(selectAllUserTrainings);

    React.useEffect(() => {
        switch(step) {
            case 1:
                setTitle("Find trainings based on:");
                break;
            case 2:
                setTitle("Almost there:");
                break;
            case 3:
                setTitle("Matching trainings:");
                break;
        }
    }, [step]);
    React.useEffect(() => {
        switch(chosenOption) {
            case "data":
                setStep(2);
                break;
            case "form":
                setStep(2);
                break;
            case "none":
                setStep(1);
                break;
        }
    }, [chosenOption]);
    React.useEffect(() => {
        if(startTrainingProcess) {
            let params = {
                trainingCategory: TrainingCategoryEnum.Weight,
                difficulty: DifficultyEnum.Beginner,
                trainingConditions: [] as TrainingCondition[],
                bodyTarget: BodyTargetEnum.Arms
            } as UserTrainingParams;
            dispatch(fetchMatchingTrainings(params));
        }
    }, [startTrainingProcess]);

    React.useEffect(() => {
        if(userTrainings.length > 0) {
            setShowTraining(true);
        }
    }, [userTrainings]);
    
    return(<>
        <Container>
        <Row>
            <Col><h4>{title}</h4></Col>
        </Row>
        <Row>
        {(chosenOption === "none" && <>
            <Button 
                onClick={() => {setChosenOption("data")}}
                variant="contained"
                color="primary"
                className={classes.button}
            >Your data (recommended for beginners)</Button>
            <Button 
                onClick={() => {setChosenOption("form")}}
                variant="contained"
                color="primary"
                className={classes.button}
            >Parameters of your choice</Button>
        </>)}
        {(chosenOption === "data" && <>
            <Button 
                onClick={() => {setChosenOption("none")}}
                variant="contained"
                color="primary"
                className={classes.button}
            >Back</Button>
            <Button 
                onClick={() => {setStartTrainingProcess(true)}}
                variant="contained"
                color="primary"
                className={classes.button}
            >Find trainings</Button>
        </>)}
        {(chosenOption === "form" && <>
            <Button 
                onClick={() => {setChosenOption("none")}}
                variant="contained"
                color="primary"
                className={classes.button}
            >Back</Button>
            
        </>)}
        </Row>
        <Row>
            {(showTraining && <TrainingResult />)}
        </Row>
    </Container>
    </>)
};

export default UserTraining;