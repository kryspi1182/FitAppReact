import { Chip, ListItem, ListItemText } from "@material-ui/core";
import React from "react";
import MealWithProducts from "../../models/MealWithProducts";

type Props = {
    meal: MealWithProducts,
    label: string
};

const MealWithProductItem: React.FC<Props> = (props) => {
    return (<ListItem>
                <ListItemText primary={props.label} secondary={props.meal.meal.name} />
                {props.meal.products.map(product => {
                return <Chip label={product.name} key={product.id + "-" + props.meal.meal.id}/>
                })}
            </ListItem>)
};

export default MealWithProductItem;
