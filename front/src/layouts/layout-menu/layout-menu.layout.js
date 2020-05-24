import { Logo } from '@components';

export default {
  name: 'ff-menu',
  components: {
    'ff-logo': Logo
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
