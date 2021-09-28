import * as React from 'react';
import { Container } from 'reactstrap';

import EditIcon from '@material-ui/icons/Edit';
import FitnessCenterIcon from '@material-ui/icons/FitnessCenter';
import FastfoodIcon from '@material-ui/icons/Fastfood';

import SideMenu, {menuOption} from '../common/SideMenu';
import UserData from './UserData';
import UserTraining from './UserTraining';
import UserDiet from './UserDiet';

const UserProfileEdit: React.FC = () => {
    const options: menuOption[] = [];
    const [chosenMenu, setChosenMenu] = React.useState("data");
    React.useEffect(() => {
        //alert(chosenMenu);
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
        icon: FitnessCenterIcon,
        label: "Training",
        clickHandler: setChosenMenu,
        clickValue: "training"
    } as menuOption);
    return(<>
        <Container>
            <SideMenu options={options}/>
            {(chosenMenu === "data") && <UserData />}
            {(chosenMenu === "diet") && <UserDiet />}
            {(chosenMenu === "training") && <UserTraining />}
        </Container>
    </>);
};

export default UserProfileEdit;