import { FfLocaleSelect, FfLogo, FfUserMenu } from '@components';
export default {
  name: 'ff-menu',
  components: {
    FfLogo,
    FfLocaleSelect,
    FfUserMenu
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
