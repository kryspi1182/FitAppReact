import { Chip, ListItem, ListItemText } from "@material-ui/core";
import InfoIcon from '@material-ui/icons/Info';
import Button from '@material-ui/core/Button';
import React from "react";
import MealWithProducts from "../../models/MealWithProducts";
import ModalWithContent from "./ModalWithContent";
import MealDetails from "../MealDetails";
import { Container, Row, Col } from "reactstrap";

type Props = {
    meal: MealWithProducts,
    label: string
};

const MealWithProductItem: React.FC<Props> = (props) => {
    return (<ListItem>
                <Container>
                    <Row>
                        <Col>
                            <ModalWithContent title="Details" content={<MealDetails mealId={props.meal.meal.id}/>}/>
                        </Col>
                        <Col>
                            <ListItemText primary={props.label} secondary={props.meal.meal.name} />
                        </Col>
                        <Col>
                            {props.meal.products.map(product => {
                                return <Chip label={product.name} key={product.id + "-" + props.meal.meal.id}/>
                            })}
                        </Col>
                    </Row>
                </Container>
            </ListItem>)
};

export default MealWithProductItem;
