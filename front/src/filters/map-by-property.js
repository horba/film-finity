import Vue from 'vue';
Vue.filter('mapByProperty', (data, propertyName) => {
  return Array.isArray(data) && data.length
    ? data.map(x => x[propertyName])
    : data[propertyName];
});
