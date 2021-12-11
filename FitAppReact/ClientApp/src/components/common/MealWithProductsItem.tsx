import { Chip, ListItem, ListItemText } from "@material-ui/core";
import InfoIcon from '@material-ui/icons/Info';
import Button from '@material-ui/core/Button';
import { makeStyles } from '@material-ui/core/styles';
import React from "react";
import MealWithProducts from "../../models/MealWithProducts";
import ModalWithContent from "./ModalWithContent";
import MealDetails from "../MealDetails";
import { Container, Row, Col } from "reactstrap";

type Props = {
    meal: MealWithProducts,
    label: string
};

const useStyles = makeStyles({
    container: {
        padding: '0px'
    },
    column: {
        margin: '10px',
    },
    helpDiv: {
        margin: '10px',
        padding: '10px',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center'
    },
    text: {
        marginTop: '0px'
    },
    row: {
        marginBottom: '10px',
        paddingBottom: '10px'
    },
    chip: {
        margin: '5px'
    }
});

const MealWithProductItem: React.FC<Props> = (props) => {
    const classes = useStyles();
    return (<ListItem>
                <Container className={classes.container}>
                    <Row className={classes.row}>
                        <Col>
                            <ModalWithContent title="Details" content={<MealDetails mealId={props.meal.meal.id}/>}/>
                        </Col>
                        <Col>
                            <ListItemText primary={props.label} secondary={props.meal.meal.name} className={classes.text} />
                        </Col>
                        <Col>
                            {props.meal.products.map(product => {
                                return <Chip label={product.name} key={product.id + "-" + props.meal.meal.id} color="primary" className={classes.chip}/>
                            })}
                        </Col>
                    </Row>
                </Container>
            </ListItem>)
};

export default MealWithProductItem;
