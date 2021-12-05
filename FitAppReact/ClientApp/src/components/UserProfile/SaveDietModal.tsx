import * as React from 'react';
import { EntityId } from '@reduxjs/toolkit';
import { useSelector, useDispatch } from 'react-redux';

import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import TextInputModal from '../common/TextInputModal';
import { selectAllUserSavedDiets } from '../../store/userSavedDietsSlice';
import { Col, Container, Row } from 'reactstrap';
import DeleteUserSavedDiets from './DeleteUserSavedDiets';

type Props = {
    setInput: Function
};

const SaveDietModal: React.FC<Props> = (props) => {
    const dispatch = useDispatch();
    const userSavedDiets = useSelector(selectAllUserSavedDiets);
    return (<Container>
        <Row>
            <Col>
                {(userSavedDiets.length < 5 && <TextInputModal title="Save diet" setInput={props.setInput}/>)}
                {(userSavedDiets.length >= 5 && <DeleteUserSavedDiets />)}
            </Col>
        </Row>
    </Container>);
};

export default SaveDietModal;