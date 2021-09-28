import * as React from 'react';
import MenuItem from '@material-ui/core//MenuItem';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import Typography from '@material-ui/core/Typography';

type Props = {
    icon: React.ComponentType,
    label: string,
    clickHandler: Function,
    clickValue: string
};

const MenuItemWithIcon: React.FC<Props> = (props) => {
    return(
        <MenuItem onClick={(e) => props.clickHandler(props.clickValue)}>
            <ListItemIcon>
                <props.icon />
            </ListItemIcon>
            <Typography variant="inherit">{props.label}</Typography>
        </MenuItem>
    );
};

export default MenuItemWithIcon;