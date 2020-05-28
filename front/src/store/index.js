import Vue from 'vue';
import Vuex from 'vuex';
import сelebrities from './modules/moduleCelebrities';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    baseUrl: 'https://localhost:5001'
  },
  mutations: {
  },
  actions: {
  },
  modules: {
    сelebrities
  }
});
