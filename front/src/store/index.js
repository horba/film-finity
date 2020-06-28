import Vue from 'vue';
import Vuex from 'vuex';
import locale from './modules/locale.store.js';
import сelebrities from './modules/celebrities.store.js';
import news from './modules/news.store.js';
import serials from './modules/serials.store.js';

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
    serials
  }
});
