import * as React from 'react';
import { Container, Col, Row } from 'reactstrap';
import { useDispatch, useSelector } from 'react-redux';

import EditIcon from '@material-ui/icons/Edit';
import FitnessCenterIcon from '@material-ui/icons/FitnessCenter';
import FastfoodIcon from '@material-ui/icons/Fastfood';
import SaveIcon from '@material-ui/icons/Save';
import LineWeightIcon from '@material-ui/icons/LineWeight';
import { makeStyles } from '@material-ui/core/styles';

import SideMenu, {menuOption} from '../common/SideMenu';
import UserData from './UserData';
import UserTraining from './UserTraining';
import UserDiet from './UserDiet';
import { fetchUser, selectUser } from '../../store/userSlice';
import UserSavedDiets from './UserSavedDiets';
import UserSavedTrainings from './UserSavedTrainings';
import ModalWithContent from '../common/ModalWithContent';
import HelpModal from '../common/HelpModal';
import DataHelp from '../Sections/Help/DataHelp';
import DietHelp from '../Sections/Help/DietHelp';
import SavedDietsHelp from '../Sections/Help/SavedDietsHelp';
import TrainingHelp from '../Sections/Help/TrainingHelp';
import SavedTrainingsHelp from '../Sections/Help/SavedTrainingsHelp';

const useStyles = makeStyles({
    container: {
        padding: '0px'
    },
    column: {
        margin: '10px',
    },
    helpDiv: {
        margin: '10px',
        padding: '10px',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center'
    },
    title: {
        textAlign: 'center'
    },
    row: {
        marginBottom: '10px',
        paddingBottom: '10px'
    }
});

const UserProfileEdit: React.FC = () => {
    const classes = useStyles();
    const options: menuOption[] = [];
    const [chosenMenu, setChosenMenu] = React.useState("data");
    const user = useSelector(selectUser);
    const [title, setTitle] = React.useState("Edit your data");
    const [helpTitle, setHelpTitle] = React.useState("Your data");
    const [helpDescription, setHelpDescription] = React.useState("Data description");
    const [helpContent, setHelpContent] = React.useState(<DataHelp />);
    
    React.useEffect(() => {
        switch(chosenMenu) {
            case "data":
                setTitle("Your data");
                setHelpTitle("Your data");
                setHelpDescription("Data description");
                setHelpContent(<DataHelp />);
                break;
            case "diet":
                setTitle("Your diet");
                setHelpTitle("Your diet");
                setHelpDescription("Diet generating description");
                setHelpContent(<DietHelp />);
                break;
            case "savedDiets":
                setTitle("Your saved diets");
                setHelpTitle("Your saved diets");
                setHelpDescription("Saved diets description");
                setHelpContent(<SavedDietsHelp />);
                break;
            case "training":
                setTitle("Your training");
                setHelpTitle("Your training");
                setHelpDescription("Training generating description");
                setHelpContent(<TrainingHelp />);
                break;
            case "savedTrainings":
                setTitle("Your saved trainings");
                setHelpTitle("Your saved trainings");
                setHelpDescription("Saved trainings description");
                setHelpContent(<SavedTrainingsHelp />);
                break;
        }
    }, [chosenMenu]);
    options.push({
        icon: EditIcon,
        label: "Edit profile",
        clickHandler: setChosenMenu,
        clickValue: "data"
    } as menuOption);
    options.push({
        icon: FastfoodIcon,
        label: "Diet",
        clickHandler: setChosenMenu,
        clickValue: "diet"
    } as menuOption);
    options.push({
        icon: SaveIcon,
        label: "Saved diets",
        clickHandler: setChosenMenu,
        clickValue: "savedDiets"
    } as menuOption);
    options.push({
        icon: FitnessCenterIcon,
        label: "Training",
        clickHandler: setChosenMenu,
        clickValue: "training"
    } as menuOption);
    options.push({
        icon: LineWeightIcon,
        label: "Saved trainings",
        clickHandler: setChosenMenu,
        clickValue: "savedTrainings"
    } as menuOption);
    return(<>
        <Container className={classes.container}>
            <Row className={classes.row}>
                <Col xs="3"><h4 className={classes.title}>Hello {user.userName}</h4></Col>
                <Col xs="9"><h4 className={classes.title}>{title}</h4></Col>
            </Row>
            <Row className={classes.row}>
                <Col xs="3">
                    <Row>
                        <Col>
                            <SideMenu options={options}/>
                        </Col>
                    </Row>
                    <Row>
                        <Col>
                            <div className={classes.helpDiv}>
                                <ModalWithContent title="Help" content={<HelpModal content={helpContent}/>}  />
                            </div>
                        </Col>
                    </Row>
                </Col>
                <Col xs="9">
                    {(chosenMenu === "data") && <UserData />}
                    {(chosenMenu === "diet") && <UserDiet />}
                    {(chosenMenu === "savedDiets") && <UserSavedDiets />}
                    {(chosenMenu === "training") && <UserTraining />}
                    {(chosenMenu === "savedTrainings") && <UserSavedTrainings />}
                </Col>
            </Row>
        </Container>
    </>);
};

export default UserProfileEdit;