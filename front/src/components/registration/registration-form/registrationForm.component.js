export default {
  data () {
    return {
      name: '',
      email: '',
      password: '',
      errors: {
        name: '',
        email: '',
        password: ''
      }
    };
  },
  methods: {
    registration () {
      this.errors.name = this.errors.email = this.errors.password = '';
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
            this.errors.email = error.response.data.Email[0];
          } catch {
            this.errors.name = error.response.data.errors.UserName[0];
            this.errors.email = error.response.data.errors.Email[0];
            this.errors.password = error.response.data.errors.UserPassword[0];
          }
        });
    }
  }
};
