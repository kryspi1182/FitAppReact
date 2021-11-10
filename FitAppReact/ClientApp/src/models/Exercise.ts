import { EntityId } from "@reduxjs/toolkit";

export interface Exercise {
    id: EntityId,
    name: string,
    exerciseCategoryId: EntityId,
    difficultyId: EntityId
};