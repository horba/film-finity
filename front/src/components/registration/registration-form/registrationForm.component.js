export default {
  data () {
    return {
      name: '',
      email: '',
      password: '',
      errors: {
        UserName: '',
        Email: '',
        UserPassword: ''
      }
    };
  },
  methods: {
    registration () {
      this.errors.UserName = this.errors.Email = this.errors.UserPassword = '';
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
            this.errors.Email = error.response.data.Email[0];
          } catch {
            this.errors = error.response.data.errors;
          }
        });
    }
  }
};
