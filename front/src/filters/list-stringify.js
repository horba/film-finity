import Vue from 'vue';
Vue.filter('listStringify', (sourceList) => {
  return sourceList ? sourceList.join(', ') : 'undefined';
});
