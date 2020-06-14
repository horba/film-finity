import Vue from 'vue';
import VueI18n from 'vue-i18n';

Vue.use(VueI18n);

export default new VueI18n({
  locale: window.localStorage.Language || 'ru',
  fallbackLocale: 'en',
  messages: {
    en: require('@/locales/translations/en.json'),
    ru: require('@/locales/translations/ua.json'),
    ua: require('@/locales/translations/ru.json')
  }
});
