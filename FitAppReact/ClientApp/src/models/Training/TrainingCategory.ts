//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import { EntityId } from "@reduxjs/toolkit";

export interface TrainingCategory {
  id: EntityId;
  name: string;
  description: string;
}
