import './element-variables.scss';

import App from './App.vue';
import ElementUI from 'element-ui';
import Vue from 'vue';
import i18n from 'vue-i18n';
import router from '@router';
import store from '@store';

Vue.use(ElementUI);

Vue.config.productionTip = false;

new Vue({
  router,
  store,
  i18n,
  render: h => h(App)
}).$mount('#app');
