import { FfLocaleSelect, FfLogo, FfRegistrationDialog, FfUserAvatar, FfAuthDialog }
  from '@components';

export default {
  name: 'ff-menu',
  components: {
    FfLogo,
    FfLocaleSelect,
    FfRegistrationDialog,
    FfUserAvatar,
    FfAuthDialog
  },
  data () {
    return {
      activeIndex: '1',
      activeIndex2: '1'
    };
  },
  methods: {
    handleSelect (key, keyPath) { }
  },
  computed: {
    isLoggedIn: function () {
      return this.$store.getters.isLoggedIn;
    },
    isConfirmationVisible: function () {
      return this.$store.state.auth.isConfirmationVisible;
    }
  }
};
