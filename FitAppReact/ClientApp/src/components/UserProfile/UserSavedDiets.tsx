import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { EntityId } from '@reduxjs/toolkit';

import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import { Container, Row } from 'reactstrap';

import { selectAllUserSavedDiets } from '../../store/userSavedDietsSlice';
import WeekDietBox from '../common/WeekDietBox';

const UserSavedDiets: React.FC = () => {
    const dispatch = useDispatch();
    const userDiets = useSelector(selectAllUserSavedDiets);
    return(<Container>
        {userDiets.map(userDiet => {
            let breakfasts = [] as EntityId[];
            let secondBreakfasts = [] as EntityId[];
            let lunches = [] as EntityId[];
            let snacks = [] as EntityId[];
            let dinners = [] as EntityId[];
            for(var i = 0; i < userDiet.meals.length; i++) {
                switch(i%5) {
                    case 0:
                        breakfasts.push(userDiet.meals[i].id);
                    break;
                    case 1:
                        secondBreakfasts.push(userDiet.meals[i].id);
                    break;
                    case 2:
                        lunches.push(userDiet.meals[i].id);
                    break;
                    case 3:
                        snacks.push(userDiet.meals[i].id);
                    break;
                    case 4:
                        dinners.push(userDiet.meals[i].id);
                    break;
                };
            }
            return <WeekDietBox
                breakfasts={breakfasts}
                secondBreakfasts={secondBreakfasts}
                lunches={lunches}
                snacks={snacks}
                dinners={dinners}
            />
        })}
    </Container>);
};

export default UserSavedDiets;