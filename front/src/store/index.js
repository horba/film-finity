import Vue from 'vue';
import Vuex from 'vuex';
import locale from './modules/locale.store.js';
import сelebrities from './modules/celebrities.store.js';
<<<<<<< HEAD
import сelebrity from './modules/celebrity.store.js';

=======
import serials from './modules/serials.store.js';
>>>>>>> dev
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
<<<<<<< HEAD
    сelebrity
=======
    locale,
    serials
>>>>>>> dev
  }
});
