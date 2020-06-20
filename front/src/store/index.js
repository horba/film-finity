import Vue from 'vue';
import Vuex from 'vuex';
import сelebrities from './modules/celebrities.store.js';
import сelebrity from './modules/celebrity.store.js';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    baseUrl: 'http://localhost:5001'
  },
  mutations: {
  },
  actions: {
  },
  modules: {
    сelebrities,
    сelebrity
  }
});
