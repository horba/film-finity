import { FfLocaleSelect, FfLogo, FfRegistrationDialog } from '@components';

export default {
  name: 'ff-menu',
  components: {
    FfLogo,
    FfLocaleSelect,
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
