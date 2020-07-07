import { Select } from 'element-ui';
import { FfUserAvatar }
  from '@components';

export default {
  name: 'ff-user-menu',
  components: {
    Select,
    FfUserAvatar
  },
  data () {
    return {
      isCollapse: true,
      user: this.$store.state.auth.user
    };
  },
  methods: {
    handleOpen (key, keyPath) {
      console.log(key, keyPath);
    },
    handleClose (key, keyPath) {
      console.log(key, keyPath);
    },
    logout: function () {
      this.$store.dispatch('logout')
        .then(() => {
          this.$router.go();
        });
    }
  }
};
