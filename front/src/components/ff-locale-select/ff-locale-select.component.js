import { Select } from 'element-ui';

export default {
  name: 'ff-locale-select',
  components: {
    Select
  },
  data () {
    return {
      options: [{
        value: 'Option1',
        label: 'Option1'
      }, {
        value: 'Option2',
        label: 'Option2'
      }, {
        value: 'Option3',
        label: 'Option3'
      }, {
        value: 'Option4',
        label: 'Option4'
      }],
      value: this.$store.state.language
    };
  }

  // methods: {
  //   changeLanguage (language) {
  //     this.$store.commit('locale/CHANGE_LANGUAGE', language);
  //   }
  // }

};
