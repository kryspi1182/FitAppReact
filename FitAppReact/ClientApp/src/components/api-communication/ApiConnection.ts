

import axios, { AxiosError } from "axios";
import notificationService from "./ToastNotify";

export const api = axios.create({
  baseURL: "http://192.168.0.12:25415/api/",
  withCredentials: true,
});

api.interceptors.response.use(
  async (response) => {
    return await response;
  },
  (error: AxiosError) => {
    const { data, status } = error.response!;
    const message = data.message;
    switch (status) {
      case 400:
        notificationService.BadRequest(message);
        break;
      case 401:
        notificationService.Unauthorised(message);
        break;
      case 404:
        notificationService.NotFound(message);
        break;
      default:
        break;
    }
    return Promise.reject(error);
  }
);
