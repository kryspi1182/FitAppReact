import * as React from 'react';
import MenuList from '@material-ui/core/MenuList';
import MenuItem from '@material-ui/core//MenuItem';
import Paper from '@material-ui/core/Paper';
import { makeStyles } from '@material-ui/core/styles';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import { Container } from 'reactstrap';
import MenuItemWithIcon from './MenuItemWithIcon';

const useStyles = makeStyles({
    sideMenu: {
        width: 250
    }
});

export type menuOption = {
    icon: React.ComponentType,
    label: string,
    clickHandler: Function,
    clickValue: string
};

type Props = {
    options: menuOption[]
};

const SideMenu: React.FC<Props> = (props) => {
    const classes = useStyles();
    return(<>
        <Container>
            <Paper className={classes.sideMenu}>
                <MenuList>
                    {props.options.map((x) => {
                        return <MenuItemWithIcon icon={x.icon} label={x.label} clickHandler={x.clickHandler} clickValue={x.clickValue} key={x.label + x.clickValue}/>
                    })}
                </MenuList>
            </Paper>
        </Container>
    </>);
};

export default SideMenu;