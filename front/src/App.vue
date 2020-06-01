<template>
  <div id="app" class="font">
    <div>
      <router-link to="/">Home</router-link>
    </div>
    <router-view />
    <div id="registration" class="blackout">
      <div class="okno">
        <div class="text">Создать аккаунт
          <a href="#" class="close">
            <el-button icon="el-icon-close" circle></el-button>
          </a>
        </div>
        <div>
          <el-form :model="ruleForm"
                   :rules="rules"
          >
            <el-form-item prop="userName">
              <el-input class="input" placeholder="Имя пользователя" v-model="ruleForm.userName">
              </el-input>
            </el-form-item>
            <el-form-item prop="email">
              <el-input class="input" placeholder="Email" v-model="ruleForm.email">
              </el-input>
            </el-form-item><el-form-item prop="pass">
              <el-input class="input"
                        type="password"
                        placeholder="Пароль"
                        v-model="ruleForm.password"
              >
              </el-input>
            </el-form-item>
          </el-form>
        </div>
        <div class="btn_padding">
          <el-button type="primary" @click="Registration()">Зарегистрироваться</el-button>
        </div>
        <div class="entrance">
          Уже есть аккаунт?
          <a href="#">Вход</a>
        </div>
      </div>
    </div>
    <div id="created" class="blackout">
      <div class="okno">
        <div class="text">Создать аккаунт
          <a href="#" class="close">
            <el-button icon="el-icon-close" circle></el-button>
          </a>
        </div>
        <div class="accountCreate font">
          <el-button type="success" icon="el-icon-check" circle></el-button>
          <p>Аккаунт создан!</p>
          <p>Ты стал частью большого мира, где каждый может внести свою
            лепту в то, чтобы процесс поиска фильма, сериала или мультфильма был проще и
            увлекательней.
          </p>
          <p>Вперед за просмотрами, оценками и комментариями!</p>
        </div>
      </div>
    </div>
    <a href="#registration">
      <el-button type="primary">Зарегистрироваться</el-button>
    </a>
  </div>
</template>

<script>
export default {
  name: 'app',
  data () {
    return {
      ruleForm: {
        userName: '',
        email: '',
        password: ''
      },
      rules: {
        email: [
          { required: true, message: 'Пожалуйста введите email', trigger: 'blur' },
          { type: 'email', message: 'Пожалуйста введите корректный email', trigger: 'blur' }
        ],
        userName: [
          { required: true, message: 'Введите имя пользователя', trigger: 'blur' }
        ]
      }
    };
  },
  methods: {
    Registration () {
      fetch('https://localhost:44333/api/user', {
        method: 'POST',
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          UserName: this.ruleForm.userName,
          Email: this.ruleForm.email,
          UserPassword: this.ruleForm.password
        })
      })
        .then(response => response.text())
        .then(data => {
          if (data === '1') {
            this.ruleForm.userName = this.ruleForm.email = this.ruleForm.password = '';
            document.location.href = '#created';
          } else {
            alert('Данный email уже зарегистрирован');
          }
        });
    }
  }
};
</script>

  <style>
.blackout {
  background: rgba(102, 102, 102, 0.5);
  width: 100%;
  height: 100%;
  position: absolute;
  top: 0;
  left: 0;
  display: none;
}
.okno {
  position: absolute;
  width: 464px;
  height: 700px;
  text-align: center;
  padding: 15px;
  position: absolute;
  bottom: 0;
  margin: auto;
  background: #ffffff;
  border-radius: 8px;
  border: 3px solid grey;
}
#registration:target {
  display: block;
}
#created:target {
  display: block;
}
.close {
  position: relative;
  left: 105px;
  right: 6.83px;
  top: 0px;
}
.btn_padding {
  padding-top: 40px;
  letter-spacing: 1px;
}
.input {
  display: flex;
  flex-direction: row;
  padding-top: 40px;
  position: static;
  height: 46px;
}
.text {
  font-weight: 600;
  font-size: 24px;
  line-height: 144%;
  align-items: flex-end;
  text-align: center;
  color: #292c33;
}
.font {
  font-family: Arial, Helvetica, sans-serif;
}
.entrance {
  font-weight: 600;
  padding-top: 40px;
  align-items: flex-end;
  text-align: center;
  color: #292c33;
  font-size: 18px;
}
a {
  text-decoration: none;
  color: #292c33;
}
.accountCreate {
  padding: 30px;
  text-align: center;
  line-height: 1.5;
}
</style>
