import './element-variables.scss';

import App from './App.vue';
import ElementUI from 'element-ui';
import Vue from 'vue';
import i18n from './plugins/i18n';
import router from '@router';
import store from '@store';
import Axios from 'axios';

Vue.use(ElementUI);

Vue.config.productionTip = false;

Vue.prototype.$http = Axios;

const token = localStorage.getItem('token');
if (token) {
  Vue.prototype.$http.defaults.headers.common.Authorization = token;
}

new Vue({
  router,
  store,
  i18n,
  created () {
    this.$store.commit('locale/INIT_LANGUAGE');
  },
  render: h => h(App)
}).$mount('#app');
