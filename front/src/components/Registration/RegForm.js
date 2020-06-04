export default {
  data () {
    return {
      ruleForm: {
        userName: '',
        email: '',
        password: '',
        actBtn: true
      },
      rules: {
        email: [
          { required: true, message: 'Пожалуйста введите email', trigger: 'blur' },
          { type: 'email', message: 'Пожалуйста введите корректный email', trigger: 'blur' }
        ],
        userName: [
          { required: true, message: 'Введите имя пользователя', trigger: 'blur' }
        ],
        password: [
          { required: true, message: 'Введите пароль', trigger: 'blur' }
        ]
      }
    };
  },
  computed: {
    MailboxBusy () {
      return this.$store.getters.getMailboxBusy;
    },
    isDisabled () {
      if (this.ruleForm.userName.length !== 0
        && this.ruleForm.email.length !== 0
        && this.ruleForm.password.length !== 0
        && this.ruleForm.email.indexOf('@') !== -1
        && this.ruleForm.email.indexOf('.') !== -1) {
        return this.actBtn;
      }
      return !this.actBtn;
    }
  },
  methods: {
    Registration () {
      this.$store.dispatch('AddUser', {
        userName: this.ruleForm.userName,
        email: this.ruleForm.email,
        userPassword: this.ruleForm.email
      });
    },
    updateMailBusy () {
      this.$store.commit('updateMailboxBusy', false);
    }
  }
};
