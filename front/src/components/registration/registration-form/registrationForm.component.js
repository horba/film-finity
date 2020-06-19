export default {
  data () {
    return {
      ruleForm: {
        userName: '',
        email: '',
        password: '',
        isDisabledButton: true
      },
      isRegistration: false,
      userRegistred: false,
      isEmailExist: false,
      rules: {
        email: [
          { required: true, message: 'Введите email', trigger: 'blur' },
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
    isFormFilled () {
      if (this.ruleForm.userName.length !== 0
        && this.ruleForm.email.length !== 0
        && this.ruleForm.password.length !== 0
        && this.ruleForm.email.indexOf('@') !== -1
        && this.ruleForm.email.indexOf('.') !== -1
        && this.ruleForm.email.slice(this.ruleForm.email.indexOf('.')).length > 2) {
        return this.isDisabledButton;
      }
      return !this.isDisabledButton;
    }
  },
  methods: {
    registration () {
      this.$store.dispatch('AddUser', {
        userName: this.ruleForm.userName,
        email: this.ruleForm.email,
        userPassword: this.ruleForm.email
      })
        .then(result => {
          this.isEmailExist = false;
          this.$emit('complete');
          this.ruleForm.email = this.ruleForm.userName = this.ruleForm.password = '';
        })
        .catch(result => {
          this.isEmailExist = true;
        });
    }
  }
};
