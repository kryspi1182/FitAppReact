import * as React from 'react';
import { Container, Col, Row } from 'reactstrap';
import { useDispatch, useSelector } from 'react-redux';

import EditIcon from '@material-ui/icons/Edit';
import FitnessCenterIcon from '@material-ui/icons/FitnessCenter';
import FastfoodIcon from '@material-ui/icons/Fastfood';
import { makeStyles } from '@material-ui/core/styles';

import SideMenu, {menuOption} from '../common/SideMenu';
import UserData from './UserData';
import UserTraining from './UserTraining';
import UserDiet from './UserDiet';
import { fetchUser, selectUser } from '../../store/userSlice';
import UserSavedDiets from './UserSavedDiets';

const useStyles = makeStyles({
    container: {
        padding: '0px'
    },
    column: {
        margin: '10px',
    }
});

const UserProfileEdit: React.FC = () => {
    const classes = useStyles();
    const options: menuOption[] = [];
    const [chosenMenu, setChosenMenu] = React.useState("data");
    const user = useSelector(selectUser);
    const [title, setTitle] = React.useState("Edit your data");
    React.useEffect(() => {
        switch(chosenMenu) {
            case "data":
                setTitle("Your data");
                break;
            case "diet":
                setTitle("Your diet");
                break;
            case "savedDiets":
                setTitle("Your saved diets");
                break;
            case "training":
                setTitle("Your training");
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
        icon: FastfoodIcon,
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
    return(<>
        <Container className={classes.container}>
            <Row>
                <Col><h4>Hello {user.userName}</h4></Col>
                <Col><h4>{title}</h4></Col>
            </Row>
            <Row>
                <Col xs="3">
                    <SideMenu options={options}/>
                </Col>
                <Col xs="auto">
                    {(chosenMenu === "data") && <UserData />}
                    {(chosenMenu === "diet") && <UserDiet />}
                    {(chosenMenu === "savedDiets") && <UserSavedDiets />}
                    {(chosenMenu === "training") && <UserTraining />}
                </Col>
            </Row>
        </Container>
    </>);
};

export default UserProfileEdit;