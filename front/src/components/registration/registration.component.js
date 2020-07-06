import { FfRegistrationForm, FfRegistrationConfirmation } from '@components/registration';
export default {
  name: 'ff-registration-dialog',
  components: {
    FfRegistrationForm, FfRegistrationConfirmation
  },
  data () {
    return {
      userRegistred: false
    };
  },
  computed: {
    regisrationDialogVisible: {
      get: function () {
        return this.$store.state.registration.isRegistrationVisible;
      },
      set: function () {
        this.$store.dispatch('ChangeRegisterVisible');
      }
    }
  },
  methods: {
    handleClose (done) {
      this.userRegistred = false;
      done();
    },
    changeRegisterVisible () {
      this.$store.dispatch('ChangeRegisterVisible');
    }
  }
};
