import * as React from 'react';
import { EntityId } from '@reduxjs/toolkit';
import { useSelector, useDispatch } from 'react-redux';

import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import { Container, Row, Col } from 'reactstrap';

import TextInputModal from '../common/TextInputModal';
import { deleteUserSavedDiet, selectAllUserSavedDiets } from '../../store/userSavedDietsSlice';
import { Typography } from '@material-ui/core';

const DeleteUserSavedDiets: React.FC = () => {
    const dispatch = useDispatch();
    const userSavedDiets = useSelector(selectAllUserSavedDiets);
    const handleDelete = (id: EntityId) => {
        dispatch(deleteUserSavedDiet(id));
    };
    return(<Container>
        <Row>
            <Col>
                <Typography>You have exceeded your limit of 5 saved diets. Delete one of your diets in order to save the new one.</Typography>
            </Col>
        </Row>
        {userSavedDiets.map(savedDiet => <Row>
            <Col>
                {savedDiet.name}
            </Col>
            <Col>
                <Button onClick={() => handleDelete(savedDiet.id)}>Delete</Button>
            </Col>
        </Row>)}
    </Container>);
};

export default DeleteUserSavedDiets;