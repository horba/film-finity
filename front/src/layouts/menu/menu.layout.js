import { FfLogo, FfRegistrationUser } from '@components';
export default {
  name: 'ff-menu',
  components: {
    FfLogo, FfRegistrationUser
  },
  data () {
    return {
      activeIndex: '1',
      activeIndex2: '1'
    };
  },
  methods: {
    handleSelect (key, keyPath) { }
  }
};
