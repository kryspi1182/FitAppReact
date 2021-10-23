import * as React from 'react';

import { makeStyles } from '@material-ui/core/styles';

type Props = {
    icon: React.ComponentType
}

const AutocompleteIcon: React.FC<Props> = (props) => {
    return <props.icon></props.icon>
};

export default AutocompleteIcon;