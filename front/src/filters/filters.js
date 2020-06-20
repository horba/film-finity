import Vue from 'vue';

Vue.filter('getImgSrc', function (imgPath, baseUrl) {
  return baseUrl + '/' + imgPath;
});
Vue.filter('spaceBetweenElement', function (titles) {
  return titles.map(element => ' ' + element.firstName + ' ' + element.lastName).join();
});
