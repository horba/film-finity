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
      isRegistration: false,
      isRegistrationDone: false,
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
    isButton () {
      if (this.ruleForm.userName.length !== 0
        && this.ruleForm.email.length !== 0
        && this.ruleForm.password.length !== 0
        && this.ruleForm.email.indexOf('@') !== -1
        && this.ruleForm.email.indexOf('.') !== -1
        && this.ruleForm.email.slice(this.ruleForm.email.indexOf('.')).length > 2) {
        return this.isDisabledBtn;
      }
      return !this.isDisabledBtn;
    }
  },
  methods: {
    Registration () {
      this.$store.dispatch('AddUser', {
        userName: this.ruleForm.userName,
        email: this.ruleForm.email,
        userPassword: this.ruleForm.email
      })
        .then(result => {
          this.isRegistrationDone = true;
          this.isEmailExist = false;
          this.isRegistration = false;
          this.ruleForm.email = this.ruleForm.userName = this.ruleForm.password = '';
        })
        .catch(result => {
          this.isRegistrationDone = false;
          this.isEmailExist = true;
        });
    },
    ShowModalWindow (value) {
      this.isRegistration = value;
      if (!value) {
        this.ruleForm.email = this.ruleForm.userName = this.ruleForm.password = '';
        this.SetEmailExistFalse();
      }
    },
    ClouseWindowRegDone () {
      this.isRegistrationDone = false;
    },
    SetEmailExistFalse () {
      this.isEmailExist = false;
    }
  }
};
