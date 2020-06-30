import convertDateTime from './convert-datetime.filter.js';
import mapByProperty from './map-by-property.filter.js';
import imageServerPath from '@/filters/image-source.filter';
import fullName from '@/filters/fullname.filter';
import listStringify from '@/filters/list-stringify.filter';
import listOfString from '@/filters/list-of-string.filter';

export default {
  install (Vue) {
    Vue.filter('imageServerPath', imageServerPath);
    Vue.filter('fullName', fullName);
    Vue.filter('listStringify', listStringify);
    Vue.filter('convertDateTime', convertDateTime);
    Vue.filter('mapByProperty', mapByProperty);
    Vue.filter('listOfString', listOfString);
  }
};
