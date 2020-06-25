import Vue from 'vue';
import store from '@store';
Vue.filter('imageFullPath', (imagePath) => {
  return store.state.baseUrl + '/' + imagePath;
});
