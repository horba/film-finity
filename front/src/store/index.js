import * as configurationData from '../../dev.config.json';

import Vue from 'vue';
import Vuex from 'vuex';
import locale from './modules/locale.store.js';
import сelebrities from './modules/celebrities.store.js';
import auth from './modules/auth.store.js';
import movieDetails from './modules/movie-details.store.js';
import movies from './modules/movies.store.js';
import news from './modules/news.store.js';
import registration from './modules/registration.store.js';
import serials from './modules/serials.store.js';
import favorites from './modules/favorites.store.js';
<<<<<<< HEAD
=======
import movies from './modules/movies.store.js';
import reviews from './modules/reviews.store.js';
import * as configurationData from '../../dev.config.json';
>>>>>>> dev

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    baseUrl: configurationData.baseUrl
  },
  mutations: {
  },
  actions: {
  },
  modules: {
    сelebrities,
    news,
    locale,
    auth,
    registration,
    serials,
    favorites,
    movies,
<<<<<<< HEAD
    movieDetails
=======
    reviews
>>>>>>> dev
  }
});
