export default {
  name: 'ff-registration-user',
  data () {
    return {
      ruleForm: {
        userName: '',
        email: '',
        password: '',
        isDisabledBtn: true
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
        && this.ruleForm.email.indexOf('.') !== -1
        && this.ruleForm.email.slice(this.ruleForm.email.indexOf('.')).length > 2) {
        return this.isDisabledBtn;
      }
      return !this.isDisabledBtn;
    },
    isVisibleRegistrationForm () {
      return this.$store.getters.getRegistrationForm;
    },
    isVisibleRegistrationSuccess () {
      return this.$store.getters.getRegistrationSuccess;
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
    VisibleRegistrationForm (value) {
      this.$store.commit('updateVisibleRegistrationForm', value);
    },
    VisibleRegistrationSuccess (value) {
      this.$store.commit('updateVisibleRegistrationSuccess', value);
    }
  }
};
