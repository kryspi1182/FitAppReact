import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';

import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import { Container, Col, Row } from 'reactstrap';

import { fetchMatchingTrainings, fetchMatchingTrainingsUserData, resetTrainings, selectAllUserTrainings } from '../../../store/User/UserTrainingsSlice';
import { UserTrainingParams } from '../../../models/User/UserTrainingParams';
import TrainingResult from './TrainingResult';
import CustomTraining from './CustomTraining';
import { selectUser } from '../../../store/User/UserSlice';
import { selectAllTrainingConditions } from '../../../store/Training/TrainingConditionsSlice';
import ErrorBox from '../../common/ErrorBox';
import LoadingModal from '../../common/Modal/LoadingModal';

const useStyles = makeStyles({
    button: {
        marginRight: '10px',
        marginTop: '10px',
        marginBottom: '10px'
    },
    result: {
        marginTop: "10px",
        marginBottom: "10px",
        paddingLeft: '0px'
    },
    row: {
        marginBottom: '10px',
        paddingBottom: '10px'
    }
});

const UserTraining: React.FC = () => {
    const dispatch = useDispatch();
    const classes = useStyles();
    const [chosenOption, setChosenOption] = React.useState("none");
    const [step, setStep] = React.useState(1);
    const [title, setTitle] = React.useState("Find trainings based on:");
    const [startTrainingProcess, setStartTrainingProcess] = React.useState(false);
    const [showTraining, setShowTraining] = React.useState(false);
    const [showError, setShowError] = React.useState(false);
    const [notFirstRender, setNotFirstRender] = React.useState(false);
    const [loaded, setLoaded] = React.useState(false);
    const [open, setOpen] = React.useState(false);

    const handleOpen = () => {
        setOpen(true);
    };

    const startLoading = () => {
        setLoaded(false);
        handleOpen();
    };

    const notify = () => {
        setNotFirstRender(true);
        setTimeout(() => {
            if (!loaded) {
                setShowError(true);
                setLoaded(true);
            }
        }, 10000);
    };

    const userTrainings = useSelector(selectAllUserTrainings);
    const trainingConditions = useSelector(selectAllTrainingConditions);
    const user = useSelector(selectUser);

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
                setStartTrainingProcess(false);
                setShowTraining(false);
                setShowError(false);
                setNotFirstRender(false);
                
                break;
        }
        setLoaded(false);
    }, [chosenOption]);
    React.useEffect(() => {
        if(startTrainingProcess) {
            //setNotFirstRender(true);
            startLoading();
            dispatch(resetTrainings());
            let params = {
                difficulty: user.difficultyId,
                trainingConditions: trainingConditions.filter(x => user.trainingConditions.some(y => y.trainingConditionId === x.id)),
            } as UserTrainingParams;
            dispatch(fetchMatchingTrainingsUserData(params));
            notify();
        }
    }, [startTrainingProcess]);

    React.useEffect(() => {
        if(userTrainings.length > 0) {
            setShowTraining(true);
            setShowError(false);
            setLoaded(true);
        }
        else {
            setShowTraining(false);
            setShowError(true);
        }
    }, [userTrainings]);
    
    return(<>
        <Container>
            {/*Did not use ModalWithContent here due to modal showing on a submit button, not a dedicated modal button*/}
            <LoadingModal open={open} setOpen={setOpen} loaded={loaded} />
        <Row className={classes.row}>
            <Col><h4>{title}</h4></Col>
        </Row>
        <Row className={classes.row}>
        {(chosenOption === "none" && <Col>
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
        </Col>)}
        {(chosenOption === "data" && <Col>
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
        </Col>)}
        {(chosenOption === "form" && <Col>
            <Button 
                onClick={() => {setChosenOption("none")}}
                variant="contained"
                color="primary"
                className={classes.button}
            >Back</Button>
            <CustomTraining notify={notify} startLoading={startLoading}/>
        </Col>)}
        </Row>
        <Row className={classes.row}>
            <Col className={classes.result}>
            {(showTraining && notFirstRender && <TrainingResult trainingConditions={trainingConditions.filter(x => user.trainingConditions.some(y => y.trainingConditionId === x.id))} />)}
            {(showError && notFirstRender && !showTraining && <ErrorBox message="No matching trainings were found." />)}
            </Col>
        </Row>
    </Container>
    </>)
};

export default UserTraining;