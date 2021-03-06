//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import * as React from "react";
import { useDispatch, useSelector } from "react-redux";
import { EntityId } from "@reduxjs/toolkit";

import { makeStyles } from "@material-ui/core/styles";
import Button from "@material-ui/core/Button";
import { Container, Col, Row } from "reactstrap";

import {
  selectAllUserMeals,
  fetchMatchingMeals,
  resetMeals,
} from "../../../store/User/UserMealsSlice";
import { selectUserMacros } from "../../../store/User/UserMacrosSlice";
import { selectAllCustomMeals } from "../../../store/Diet/CustomMealsSlice";
import DietResult from "./DietResult";
import { selectUser } from "../../../store/User/UserSlice";
import { MealCategoryEnum } from "../../../models/enums/MealCategoryEnum";
import { DietTypeEnum } from "../../../models/enums/DietTypeEnum";
import { UserDietParams } from "../../../models/User/UserDietParams";
import CustomDiet from "./CustomDiet";
import LoadingModal from "../../common/Modal/LoadingModal";

const getRandomInt = (max: number) => {
  return Math.floor(Math.random() * max);
};

const useStyles = makeStyles({
  button: {
    marginRight: "10px",
    marginTop: "10px",
    marginBottom: "10px",
  },
  row: {
    marginBottom: "10px",
    paddingBottom: "10px",
  },
});

const UserDiet: React.FC = () => {
  const classes = useStyles();
  const dispatch = useDispatch();
  const [chosenOption, setChosenOption] = React.useState("none");
  const [startDietProcess, setStartDietProcess] = React.useState(false);
  const [startCustomDietProcess, setStartCustomDietProcess] =
    React.useState(false);
  const [generateDiet, setGenerateDiet] = React.useState(false);
  const [generateCustomDiet, setGenerateCustomDiet] = React.useState(false);
  const [step, setStep] = React.useState(1);
  const [title, setTitle] = React.useState("Generate diet based on your:");
  const [firstRender, setFirstRender] = React.useState(true);
  const [loaded, setLoaded] = React.useState(false);
  const [open, setOpen] = React.useState(false);

  const handleOpen = () => {
    setOpen(true);
  };

  const macros = useSelector(selectUserMacros);
  const meals = useSelector(selectAllUserMeals);
  const customMeals = useSelector(selectAllCustomMeals);
  const user = useSelector(selectUser);

  React.useEffect(() => {
    switch (step) {
      case 1:
        setTitle("Generate diet based on your:");
        break;
      case 2:
        setTitle("Almost there:");
        break;
      case 3:
        setTitle("Weekly diet:");
        break;
    }
  }, [step]);
  React.useEffect(() => {
    switch (chosenOption) {
      case "data":
        setStep(2);
        break;
      case "form":
        setStep(2);
        break;
      case "none":
        setStep(1);
        setStartDietProcess(false);
        setStartCustomDietProcess(false);
        setGenerateDiet(false);
        setGenerateCustomDiet(false);
        break;
    }
  }, [chosenOption]);

  React.useEffect(() => {
    if (macros.calories > 0 && startDietProcess) {
      setLoaded(false);
      handleOpen();
      dispatch(resetMeals());
      const breakfastParams = {
        macros: macros,
        unwantedProductIds: user.unwantedProducts.map((x) => x.productId),
        conditionIds: user.medicalConditions.map((x) => x.medicalConditionId),
        mealCategory: MealCategoryEnum.Breakfast,
        weightTarget: user.weightTargetId,
      } as UserDietParams;
      const lunchParams = {
        macros: macros,
        unwantedProductIds: user.unwantedProducts.map((x) => x.productId),
        conditionIds: user.medicalConditions.map((x) => x.medicalConditionId),
        mealCategory: MealCategoryEnum.Lunch,
        weightTarget: user.weightTargetId,
      } as UserDietParams;
      const snackParams = {
        macros: macros,
        unwantedProductIds: user.unwantedProducts.map((x) => x.productId),
        conditionIds: user.medicalConditions.map((x) => x.medicalConditionId),
        mealCategory: MealCategoryEnum.Snack,
        weightTarget: user.weightTargetId,
      } as UserDietParams;
      const secondBreakfastParams = {
        macros: macros,
        unwantedProductIds: user.unwantedProducts.map((x) => x.productId),
        conditionIds: user.medicalConditions.map((x) => x.medicalConditionId),
        mealCategory: MealCategoryEnum.SecondBreakfast,
        weightTarget: user.weightTargetId,
      } as UserDietParams;
      const dinnerParams = {
        macros: macros,
        unwantedProductIds: user.unwantedProducts.map((x) => x.productId),
        conditionIds: user.medicalConditions.map((x) => x.medicalConditionId),
        mealCategory: MealCategoryEnum.Dinner,
        weightTarget: user.weightTargetId,
      } as UserDietParams;
      dispatch(fetchMatchingMeals(breakfastParams));
      dispatch(fetchMatchingMeals(lunchParams));
      dispatch(fetchMatchingMeals(snackParams));
      dispatch(fetchMatchingMeals(secondBreakfastParams));
      dispatch(fetchMatchingMeals(dinnerParams));
      setStep(3);
    }
  }, [startDietProcess]);

  React.useEffect(() => {
    if (startCustomDietProcess) {
      setLoaded(false);
      handleOpen();
    }
  }, [startCustomDietProcess]);

  React.useEffect(() => {
    if (
      meals.some(
        (meal) => meal.mealCategoryId === MealCategoryEnum.Breakfast
      ) &&
      meals.some(
        (meal) => meal.mealCategoryId === MealCategoryEnum.SecondBreakfast
      ) &&
      meals.some((meal) => meal.mealCategoryId === MealCategoryEnum.Lunch) &&
      meals.some((meal) => meal.mealCategoryId === MealCategoryEnum.Snack) &&
      meals.some((meal) => meal.mealCategoryId === MealCategoryEnum.Dinner) &&
      startDietProcess
    ) {
      setLoaded(true);
      setGenerateDiet(true);
      setGenerateCustomDiet(false);
    }
  }, [meals]);
  React.useEffect(() => {
    if (
      customMeals.some(
        (meal) => meal.mealCategoryId === MealCategoryEnum.Breakfast
      ) &&
      customMeals.some(
        (meal) => meal.mealCategoryId === MealCategoryEnum.SecondBreakfast
      ) &&
      customMeals.some(
        (meal) => meal.mealCategoryId === MealCategoryEnum.Lunch
      ) &&
      customMeals.some(
        (meal) => meal.mealCategoryId === MealCategoryEnum.Snack
      ) &&
      customMeals.some(
        (meal) => meal.mealCategoryId === MealCategoryEnum.Dinner
      ) &&
      startCustomDietProcess
    ) {
      setLoaded(true);
      setGenerateCustomDiet(true);
      setGenerateDiet(false);
    }
  }, [customMeals]);
  return (
    <>
      <Container>
        {/*Did not use ModalWithContent here due to modal showing on a submit button, not a dedicated modal button*/}
        <LoadingModal open={open} setOpen={setOpen} loaded={loaded} />
        <Row className={classes.row}>
          <Col xs="12">
            <h4>{title}</h4>
          </Col>
        </Row>
        <Row className={classes.row}>
          {chosenOption === "none" && (
            <Col xs="12">
              <Button
                onClick={() => {
                  setChosenOption("data");
                }}
                variant="contained"
                color="primary"
                className={classes.button}
              >
                Your data (recommended for beginners)
              </Button>
              <Button
                onClick={() => {
                  setChosenOption("form");
                }}
                variant="contained"
                color="primary"
                className={classes.button}
              >
                Macros of your choice
              </Button>
            </Col>
          )}
          {chosenOption === "data" && (
            <Col xs="12">
              <Button
                onClick={() => {
                  setChosenOption("none");
                }}
                variant="contained"
                color="primary"
                className={classes.button}
              >
                Back
              </Button>
              <Button
                onClick={() => {
                  setStartDietProcess(true);
                }}
                variant="contained"
                color="primary"
                className={classes.button}
              >
                Generate diet
              </Button>
            </Col>
          )}
          {chosenOption === "form" && (
            <Col xs="12">
              <Button
                onClick={() => {
                  setChosenOption("none");
                }}
                variant="contained"
                color="primary"
                className={classes.button}
              >
                Back
              </Button>
              <CustomDiet setStartProcess={setStartCustomDietProcess} />
            </Col>
          )}
        </Row>
        <Row className={classes.row}>
          {generateDiet && (
            <DietResult
              generateDiet={generateDiet}
              setGenerateDiet={setGenerateDiet}
              dietType={DietTypeEnum.Data}
            />
          )}
          {generateCustomDiet && (
            <DietResult
              generateDiet={generateCustomDiet}
              setGenerateDiet={setGenerateCustomDiet}
              dietType={DietTypeEnum.Custom}
            />
          )}
        </Row>
      </Container>
    </>
  );
};

export default UserDiet;
