import { EntityId } from "@reduxjs/toolkit";

export interface User {
    Id: EntityId,
    UserName: string,
    Email: string,
    Activity: number,
    Age: number,
    Gender: number,
    Height: number,
    Weight: number
};