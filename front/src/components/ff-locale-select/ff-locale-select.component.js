import { Select } from 'element-ui';

export default {
  name: 'ff-locale-select',
  components: {
    Select
  },
  computed: {
    language () {
      return this.$store.state.language;
    },
    locales () {
      return [
        {
          value: 'EN',
          label: this.$t('locale.en')
        },
        {
          value: 'RU',
          label: this.$t('locale.ru')
        },
        {
          value: 'UA',
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
