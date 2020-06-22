import { Select } from 'element-ui';

export default {
  name: 'ff-locale-select',
  components: {
    Select
  },
  data () {
    return {
      value: this.$t('locale.language')
    };
  },
  computed: {
    language () {
      return this.$store.state.language;
    },
    locales () {
      return [
        {
          value: 'en',
          label: this.$t('locale.en')
        },
        {
          value: 'ru',
          label: this.$t('locale.ru')
        },
        {
          value: 'ua',
          label: this.$t('locale.ua')
        }
      ];
    }
  },
  methods: {
    changeLanguage (language) {
      this.$store.commit('locale/CHANGE_LANGUAGE', language);
    }
  }
};
