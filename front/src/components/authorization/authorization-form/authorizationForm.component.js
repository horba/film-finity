
export default {
  name: 'ff-auth-form',
  data () {
    return {
      email: '',
      password: '',
      isVisibleErrors: {
        email: false,
        password: false,
        uncorrectAcc: false
      }
    };
  },
  methods: {
    changeRegisterVisible () {
      this.$store.dispatch('ChangeRegisterVisible');
      this.$store.dispatch('ChangeLoginVisible');
    },
    login: function () {
      this.isVisibleErrors.email = this.isVisibleErrors.password = false;
      const User = {
        username: this.email,
        password: this.password
      };
      this.$store.dispatch('login', User)
        .then(result => {
          this.$emit('complete');
          this.email = this.password = '';
        })
        .catch(error => {
          try {
            console.log(error);
            this.isVisibleErrors.uncorrectAcc = error.data.message;
            this.isVisibleErrors.email = error.data.errors.Username[0];
            this.isVisibleErrors.password = error.data.errors.Password[0];
          } catch {
          }
        });
    }
  }
};
