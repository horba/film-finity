import api from './api-service.service.js';
import store from '@store';

api.interceptors.request.use(
  config => {
    const token = localStorage.getItem('token');
    if (token) {
      config.headers.common.Authorization = 'Bearer ' + token;
    }
    return config;
  },
  error => {
    return Promise.reject(error);
  }
);
api.interceptors.response.use(
  response => {
    if (response.status === 200 || response.status === 201) {
      return Promise.resolve(response);
    } else {
      return Promise.reject(response);
    }
  },
  error => {
    if (error.response.status) {
      switch (error.response.status) {
        case 400:
          break;
        case 401:
          alert('session expired');
          store.dispatch('logout');
          store.state.auth.isLoginVisible = true;
          break;
        case 403:
          break;
        case 404:
          alert('page not exist');
          break;
        case 502:
          setTimeout(() => {
          }, 1000);
      }
      return Promise.reject(error.response);
    }
  }
);

export default api;
