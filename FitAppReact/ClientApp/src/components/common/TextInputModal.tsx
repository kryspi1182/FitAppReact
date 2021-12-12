import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { Container, Col, Row } from 'reactstrap';

import { makeStyles, Theme, createStyles } from '@material-ui/core/styles';
import { TextField, Select, MenuItem, FormControl, FormHelperText, InputLabel } from '@material-ui/core';
import Button from '@material-ui/core/Button';

type Props = {
    title: string,
    description?: string,
    setInput: Function
    //confirm: Function
};

const useStyles = makeStyles({
    modal: {
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center',
      },
      paper: {
        //border: '2px solid #000',
        backgroundColor: '#fff',
        padding: '10px'
      },
});

const TextInputModal: React.FC<Props> = (props) => {
    const classes = useStyles();
    const [inputValue, setInputValue] = React.useState("");
    const handleConfirm = () => {
        props.setInput(inputValue);
    }
    return (<Container className={classes.paper}>
        <Row>
            <Col xs="9">
                <FormControl>
                        <TextField
                            id="modal-input"
                            label={props.title}
                            onChange={(event) => {
                                setInputValue(event.target.value);
                            }}
                            value={inputValue}
                            variant="outlined"
                        />
                    </FormControl>
            </Col>
            <Col xs="3">
                <Button
                    variant="outlined"
                    color="primary"
                    onClick={handleConfirm}
                >
                    Save
                </Button>
            </Col>
        </Row>
    </Container>);
};

export default TextInputModal;
