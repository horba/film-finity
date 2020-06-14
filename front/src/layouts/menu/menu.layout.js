import { FfLocale, FfLogo } from '@components';

export default {
  name: 'ff-menu',
  components: {
    FfLogo,
    FfLocale
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
