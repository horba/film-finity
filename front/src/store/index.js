import Vue from 'vue';
import Vuex from 'vuex';
import registration from './modules/registration.store.js';
import locale from './modules/locale.store.js';
import сelebrities from './modules/celebrities.store.js';
import serials from './modules/serials.store.js';
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
    сelebrities,
    locale,
    registration,
    serials
  }
});
