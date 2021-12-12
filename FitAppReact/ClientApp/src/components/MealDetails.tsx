import * as React from "react";
import { useDispatch, useSelector } from 'react-redux';
import { EntityId } from '@reduxjs/toolkit';
import { useParams } from "react-router";
import { Container, Col, Row } from "reactstrap";
import store, {RootState} from "../store/newConfigureStore";

import { selectMealById } from "../store/mealsSlice";
import { Meal } from "../models/Meal";
import { selectAllProducts } from "../store/productsSlice";
import MealWithProducts from '../models/MealWithProducts';
import MacrosBox from "./common/MacrosBox";
import { Macros } from "../models/Macros";
import MealWithProductItem from "./common/MealWithProductsItem";
import { makeStyles, ListItem, Typography, Divider, Chip } from "@material-ui/core";

const useStyles = makeStyles({
    container: {
        padding: '0px',
    },
    sectionTitle: {
        margin: '10px'
    },
    sectionContent: {
        margin: '10px',
        verticalAlign: 'center'
    },
    row: {
        margin: '10px'
    },
    chip: {
        margin: '10px',
        color: '#fff',
        backgroundColor: '#000'
    }
});

type Props = {
    mealId : EntityId
}

const MealDetails: React.FC<Props> = (props) => {
    const classes = useStyles();
    const products = useSelector(selectAllProducts);
    let meal = useSelector((state: RootState) => selectMealById(state, props.mealId)); 
    let mealProducts = meal !== undefined ? products.filter(product => meal.mealProducts.some(mealProduct => mealProduct.productId === product.id)) : [];
    let mealWithProducts = {
        meal: meal,
        products: mealProducts
    } as MealWithProducts;
    let macros = {
        calories : 0,
        fat : 0,
        carbohydrates : 0,
        sugar : 0,
        fibre : 0,
        protein : 0,
        salt : 0,
    } as Macros;
    
    mealWithProducts.products.forEach(product => {
        macros.calories += product.calories;
        macros.fat += product.fat;
        macros.carbohydrates += product.carbohydrates;
        macros.sugar += product.sugar;
        macros.fibre += product.fibre;
        macros.protein += product.protein;
        macros.salt += product.salt;
    });
    return(<>{(mealWithProducts.meal && mealWithProducts.products && <Container className={classes.container}>
        <Row>
            <Col>
                <h3>Details</h3>
            </Col>
        </Row>
        <Row>
            <Col xs="3">
                <MacrosBox macros={macros} />
            </Col>
            <Col xs="9">
                    <Container>
                        <Row className={classes.row}>
                            <Col>
                            <h3 className={classes.sectionTitle}>{mealWithProducts.meal.name}</h3>
                            </Col>
                        </Row>
                        <Row className={classes.row}>
                            <Col xs="3">
                            <Typography className={classes.sectionTitle}>Description:</Typography>
                            </Col>
                            <Col xs="6">
                            <Typography className={classes.sectionContent}>{mealWithProducts.meal.description}</Typography>
                            </Col>
                        </Row>
                        <Row className={classes.row}>
                            <Col xs="3">
                            <Typography className={classes.sectionTitle}>Recipe:</Typography>
                            </Col>
                            <Col xs="auto">
                            <Typography className={classes.sectionContent}>{mealWithProducts.meal.recipe}</Typography>
                            </Col>
                        </Row>
                        <Row className={classes.row}>
                            <Col xs="3">
                            <Typography className={classes.sectionTitle}>Products:</Typography>
                            </Col>
                            <Col xs="auto">
                            {mealWithProducts.products.map(product => {
                                let quantity = mealWithProducts.meal.mealProducts.find(mp => mp.productId === product.id);
                                if (quantity) {
                                    return <Chip label={product.name + " " + quantity.quantity * 100 + "g"} 
                                        key={product.id + "" + quantity.mealId} 
                                        className={classes.chip}
                                        />
                                }
                            })}
                            </Col>
                        </Row>
                    </Container>
            </Col>
        </Row>
    </Container>)}</>);
};

export default MealDetails;