import { FfLocaleSelect, FfLogo, FfRegistrationDialog, FfUserMenu } from '@components';

export default {
  name: 'ff-menu',
  components: {
    FfLogo,
    FfLocaleSelect,
    FfUserMenu,
    FfRegistrationDialog
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
