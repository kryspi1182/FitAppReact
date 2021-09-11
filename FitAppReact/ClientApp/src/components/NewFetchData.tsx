import * as React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { fetchData, selectAllData } from '../store/dataSlice';

const NewFetchData: React.FC = () => {
    const dispatch = useDispatch();
    React.useEffect(() => {
        dispatch(fetchData());
    }, [dispatch]);
    const data = useSelector(selectAllData);
    alert(data);
    return (
        <>

        </>
        );
};

export default NewFetchData;