import { EntityId } from "@reduxjs/toolkit";

export interface Training {
    id: EntityId,
    name: string,
    description: string,
    trainingCategoryId: EntityId,
    difficultyId: EntityId
};