import api from '@apiService';

export default {
  actions: {
    AddUser ({ commit }, newUser) {
      return api.post('/user', {
        userName: newUser.userName,
        email: newUser.email,
        userPassword: newUser.userPassword
      });
    },
    ChangeRegisterVisible ({ commit }) {
      commit('ChangeRegistrationVisible');
    }
  },
  state: {
    isRegistrationVisible: false
  },
  getters: {
  },
  mutations: {
    ChangeRegistrationVisible (state) {
      state.isRegistrationVisible = !state.isRegistrationVisible;
    }
  }
};
