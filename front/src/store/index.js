import Vue from 'vue';
import Vuex from 'vuex';
import сelebrities from './modules/celebrities.store.js';
import movies from './modules/movies.store.js';
import * as data from '../../dev.config.json';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    baseUrl: data.baseUrl
  },
  mutations: {
  },
  actions: {
  },
  modules: {
    сelebrities,
    movies
  }
});
