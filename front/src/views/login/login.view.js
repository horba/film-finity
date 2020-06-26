export default {
  data () {
    return {
      email: '',
      password: ''
    };
  },
  methods: {
    login: function () {
      const email = this.email,
            password = this.password;
      this.$store.dispatch('login', { email, password })
        .then(() => this.$router.push('/'))
        .catch(err => console.log(err));
    }
  }
};
