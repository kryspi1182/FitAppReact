//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import { toast } from "react-toastify";

const notificationService = {
  BadRequest(message: string) {
    toast.error(`Bad Request! Message: ${message}`);
  },
  Unauthorised(message: string) {
    toast.error(`Unauthorised! Message: ${message}`);
  },
  NotFound(message: string) {
    toast.error(`Not Found! Message: ${message}`);
  },
};

export default notificationService;
