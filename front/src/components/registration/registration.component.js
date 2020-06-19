import { FfRegistrationForm, FfRegistrationConfirmation } from '@components/registration';
export default {
  name: 'ff-registration-dialog',
  components: {
    FfRegistrationForm, FfRegistrationConfirmation
  },
  data () {
    return {
      regisrationDialogVisible: false,
      userRegistred: false
    };
  },
  computed: {
  },
  methods: {
    handleClose (done) {
      this.userRegistred = false;
      done();
    }
  }
};
