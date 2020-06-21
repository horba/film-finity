import Vue from 'vue';
Vue.filter('convertDateTimeToDD.MM.YY.HH:MM', (DateTime) => {
  const date = new Date(Date.parse(DateTime));
  return ('0' + date.getDate()).slice(-2) + '.'
  + ('0' + (date.getMonth() + 1)).slice(-2) + '.'
  + date.getFullYear() + ' '
  + date.getHours() + ':'
  + date.getMinutes();
});
