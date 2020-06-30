export default {
  data () {
    return {
      name: '',
      email: '',
      password: '',
      isVisibleErrors: {
        name: false,
        email: false,
        emailRegistered: false,
        password: false
      }
    };
  },
  methods: {
    registration () {
      this.isVisibleErrors.name = this.isVisibleErrors.email
      = this.isVisibleErrors.password = false;
      this.$store.dispatch('AddUser', {
        userName: this.name,
        email: this.email,
        userPassword: this.password
      })
        .then(result => {
          this.$emit('complete');
          this.email = this.userName = this.password = '';
        })
        .catch(error => {
          try {
            this.isVisibleErrors.emailRegistered = error.response.data.Email[0];
          } catch {
            this.isVisibleErrors.name = error.response.data.errors.UserName[0];
            this.isVisibleErrors.email = error.response.data.errors.Email[0];
            this.isVisibleErrors.password = error.response.data.errors.UserPassword[0];
          }
        });
    }
  }
};
