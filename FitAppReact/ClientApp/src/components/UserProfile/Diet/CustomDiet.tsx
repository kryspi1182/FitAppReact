//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import * as React from "react";
import { useDispatch, useSelector } from "react-redux";
import { EntityId } from "@reduxjs/toolkit";

import { makeStyles } from "@material-ui/core/styles";
import { FormControl, TextField } from "@material-ui/core";
import Button from "@material-ui/core/Button";
import { Container, Col, Row } from "reactstrap";
import { useFormik } from "formik";
import * as Yup from "yup";
import { userInfo } from "os";

import { selectAllMedicalConditions } from "../../../store/Diet/MedicalConditionsSlice";
import { selectAllProducts } from "../../../store/Diet/ProductsSlice";
import {
  fetchMatchingCustomMeals,
  resetCustomMeals,
} from "../../../store/Diet/CustomMealsSlice";
import { AutocompleteItem } from "../../common/Autocomplete/AutocompleteItem";
import AutocompleteInput from "../../common/Autocomplete/AutocompleteInput";
import { Macros } from "../../../models/Diet/Macros";
import { dietApi } from "../../api-communication/DietApi";
import { UserDietParams } from "../../../models/User/UserDietParams";
import { MealCategoryEnum } from "../../../models/enums/MealCategoryEnum";

const useStyles = makeStyles({
  formControl: {
    display: "block",
  },
  container: {
    paddingLeft: "0px",
  },
  column: {
    //margin: '10px',
  },
  formInput: {
    width: "100%",
  },
  row: {
    marginBottom: "10px",
    paddingBottom: "10px",
  },
  title: {
    textAlign: "center",
  },
  submitButton: {
    float: "right",
  },
});

type Props = {
  setStartProcess: Function;
};

const CustomDiet: React.FC<Props> = (props) => {
  const dispatch = useDispatch();
  const classes = useStyles();
  const medicalConditions = useSelector(selectAllMedicalConditions);
  const products = useSelector(selectAllProducts);
  const mappedMedicalConditions = medicalConditions.map((x) => {
    return { id: x.id, name: x.name } as AutocompleteItem;
  });
  const mappedProducts = products.map((x) => {
    return { id: x.id, name: x.name } as AutocompleteItem;
  });
  const [selectedMedicalConditions, setSelectedMedicalConditions] =
    React.useState([] as EntityId[]);
  const [selectedUnwantedProducts, setSelectedUnwantedProducts] =
    React.useState([] as EntityId[]);
  const [selectedMappedMedicalConditions, setSelectedMappedMedicalConditions] =
    React.useState([] as AutocompleteItem[]);
  const [selectedMappedUnwantedProducts, setSelectedMappedUnwantedProducts] =
    React.useState([] as AutocompleteItem[]);
  const mapItemsToMedicalConditions = (items: AutocompleteItem[]) => {
    setSelectedMappedMedicalConditions(items);
    setSelectedMedicalConditions(items.map((x) => x.id));
  };
  const mapItemsToUnwantedProducts = (items: AutocompleteItem[]) => {
    setSelectedMappedUnwantedProducts(items);
    setSelectedUnwantedProducts(items.map((x) => x.id));
  };
  React.useEffect(() => {
    formik.setFieldValue("conditionIds", selectedMedicalConditions);
  }, [selectedMedicalConditions]);

  React.useEffect(() => {
    formik.setFieldValue("unwantedProductIds", selectedUnwantedProducts);
  }, [selectedUnwantedProducts]);

  const formik = useFormik({
    initialValues: {
      calories: 0,
      carbohydrates: 0,
      protein: 0,
      fat: 0,
      sugar: 0,
      salt: 0,
      fibre: 0,
      unwantedProductIds: [] as EntityId[],
      conditionIds: [] as EntityId[],
    },
    validationSchema: Yup.object({
      calories: Yup.number().min(1000).max(10000).required(),
      carbohydrates: Yup.number().min(10).max(1000).required(),
      protein: Yup.number().min(10).max(1000).required(),
      fat: Yup.number().min(10).max(1000).required(),
      sugar: Yup.number().min(10).max(1000).required(),
      salt: Yup.number().min(1).max(100).required(),
      fibre: Yup.number().min(1).max(100).required(),
    }),
    onSubmit: (values) => {
      //console.log(values);
      dispatch(resetCustomMeals());
      const macros = {
        calories: formik.values.calories,
        fat: formik.values.fat,
        carbohydrates: formik.values.carbohydrates,
        sugar: formik.values.sugar,
        fibre: formik.values.fibre,
        protein: formik.values.protein,
        salt: formik.values.salt,
      } as Macros;
      var dietParams = {
        macros: macros,
        unwantedProductIds: selectedUnwantedProducts,
        conditionIds: selectedMedicalConditions,
        mealCategory: MealCategoryEnum.Breakfast,
      } as UserDietParams;
      dispatch(fetchMatchingCustomMeals(dietParams));
      dietParams.mealCategory = MealCategoryEnum.Lunch;
      dispatch(fetchMatchingCustomMeals(dietParams));
      dietParams.mealCategory = MealCategoryEnum.Snack;
      dispatch(fetchMatchingCustomMeals(dietParams));
      dietParams.mealCategory = MealCategoryEnum.SecondBreakfast;
      dispatch(fetchMatchingCustomMeals(dietParams));
      dietParams.mealCategory = MealCategoryEnum.Dinner;
      dispatch(fetchMatchingCustomMeals(dietParams));
      props.setStartProcess(true);
    },
  });
  return (
    <Container className={classes.container}>
      <form onSubmit={formik.handleSubmit} id="custom-diet">
        <Row className={classes.row}>
          <Col className={classes.column}>
            <FormControl className={classes.formControl}>
              <TextField
                id="custom-diet-calories"
                label="Calories"
                type="number"
                InputProps={{ inputProps: { min: 1000, max: 10000 } }}
                onChange={(event) => {
                  if (!isNaN(parseInt(event.target.value)))
                    formik.setFieldValue(
                      "calories",
                      parseInt(event.target.value)
                    );
                }}
                value={formik.values.calories}
                variant="outlined"
                className={classes.formInput}
              />
            </FormControl>
          </Col>
          <Col className={classes.column}>
            <FormControl className={classes.formControl}>
              <TextField
                id="custom-diet-carbohydrates"
                label="Carbohydrates"
                type="number"
                InputProps={{ inputProps: { min: 10, max: 1000 } }}
                onChange={(event) => {
                  if (!isNaN(parseInt(event.target.value)))
                    formik.setFieldValue(
                      "carbohydrates",
                      parseInt(event.target.value)
                    );
                }}
                value={formik.values.carbohydrates}
                variant="outlined"
                className={classes.formInput}
              />
            </FormControl>
          </Col>
        </Row>
        <Row className={classes.row}>
          <Col className={classes.column}>
            <FormControl className={classes.formControl}>
              <TextField
                id="custom-diet-protein"
                label="Protein"
                type="number"
                InputProps={{ inputProps: { min: 10, max: 1000 } }}
                onChange={(event) => {
                  if (!isNaN(parseInt(event.target.value)))
                    formik.setFieldValue(
                      "protein",
                      parseInt(event.target.value)
                    );
                }}
                value={formik.values.protein}
                variant="outlined"
                className={classes.formInput}
              />
            </FormControl>
          </Col>
          <Col className={classes.column}>
            <FormControl className={classes.formControl}>
              <TextField
                id="custom-diet-fat"
                label="Fat"
                type="number"
                InputProps={{ inputProps: { min: 10, max: 1000 } }}
                onChange={(event) => {
                  if (!isNaN(parseInt(event.target.value)))
                    formik.setFieldValue("fat", parseInt(event.target.value));
                }}
                value={formik.values.fat}
                variant="outlined"
                className={classes.formInput}
              />
            </FormControl>
          </Col>
        </Row>
        <Row className={classes.row}>
          <Col className={classes.column}>
            <FormControl className={classes.formControl}>
              <TextField
                id="custom-diet-sugar"
                label="Sugar"
                type="number"
                InputProps={{ inputProps: { min: 10, max: 1000 } }}
                onChange={(event) => {
                  if (!isNaN(parseInt(event.target.value)))
                    formik.setFieldValue("sugar", parseInt(event.target.value));
                }}
                value={formik.values.sugar}
                variant="outlined"
                className={classes.formInput}
              />
            </FormControl>
          </Col>
          <Col className={classes.column}>
            <FormControl className={classes.formControl}>
              <TextField
                id="custom-diet-salt"
                label="Salt"
                type="number"
                InputProps={{ inputProps: { min: 1, max: 100 } }}
                onChange={(event) => {
                  if (!isNaN(parseInt(event.target.value)))
                    formik.setFieldValue("salt", parseInt(event.target.value));
                }}
                value={formik.values.salt}
                variant="outlined"
                className={classes.formInput}
              />
            </FormControl>
          </Col>
        </Row>
        <Row className={classes.row}>
          <Col className={classes.column}>
            <FormControl className={classes.formControl}>
              <TextField
                id="custom-diet-fibre"
                label="Fibre"
                type="number"
                InputProps={{ inputProps: { min: 1, max: 100 } }}
                onChange={(event) => {
                  if (!isNaN(parseInt(event.target.value)))
                    formik.setFieldValue("fibre", parseInt(event.target.value));
                }}
                value={formik.values.fibre}
                variant="outlined"
                className={classes.formInput}
              />
            </FormControl>
          </Col>
        </Row>
        <Row className={classes.row}>
          <Col className={classes.column} xs="12">
            <FormControl className={classes.formControl}>
              <AutocompleteInput
                items={mappedMedicalConditions}
                id="medical-conditions"
                title="Medical conditions"
                setSelected={mapItemsToMedicalConditions}
                selectedValues={selectedMappedMedicalConditions}
              />
            </FormControl>
          </Col>
        </Row>
        <Row className={classes.row}>
          <Col className={classes.column} xs="12">
            <FormControl className={classes.formControl}>
              <AutocompleteInput
                items={mappedProducts}
                id="unwanted-products"
                title="Unwanted products"
                setSelected={mapItemsToUnwantedProducts}
                selectedValues={selectedMappedUnwantedProducts}
              />
            </FormControl>
          </Col>
        </Row>
        <Row className={classes.row}>
          <Col className={classes.column}>
            <Button
              type="submit"
              variant="contained"
              color="primary"
              className={classes.submitButton}
            >
              Submit
            </Button>
          </Col>
        </Row>
      </form>
    </Container>
  );
};

export default CustomDiet;
