import Vue from 'vue';
import Vuex from 'vuex';
import ReristrationUser from './modules/ReristrationUser';

Vue.use(Vuex);

export default new Vuex.Store({
  modules: {
    ReristrationUser
  }
});
