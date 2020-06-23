import Vue from 'vue';
import { format } from 'date-fns';

Vue.filter('convertDateTime', (DateTime) => {
  return format(new Date(DateTime), 'dd.MM.yyyy kk:mm');
});
Vue.filter('listStringify', (sourceList) => {
  return sourceList.join(', ');
});
