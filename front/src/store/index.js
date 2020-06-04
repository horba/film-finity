import Vue from 'vue';
import Vuex from 'vuex';
import сelebrities from './modules/celebrities.store.js';
import movies from './modules/movies.store.js';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    baseUrl: 'https://localhost:44333'
  },
  mutations: {
  },
  actions: {
  },
  modules: {
    сelebrities, movies
  }
});
