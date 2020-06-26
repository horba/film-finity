import './list-stringify.js';
import './convert-datetime.js';
import './map-by-property.js';
import './image-full-path.js';
import imageServerPath from '@/filters/image-source.filter';
import fullName from '@/filters/fullname.filter';
import listStringify from '@/filters/list-stringify.filter';

export default {
  install (Vue) {
    Vue.filter('imageServerPath', imageServerPath);
    Vue.filter('fullName', fullName);
    Vue.filter('listStringify', listStringify);
  }
};
