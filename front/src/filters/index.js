import Vue from 'vue';

Vue.filter('listStringify', function (list, name) {
  return list.map(element => ' ' + element[name]).join();
});
