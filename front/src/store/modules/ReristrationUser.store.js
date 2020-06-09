import axios from 'axios';

export default {
  actions: {
    AddUser ({ commit }, newUser) {
      axios({
        method: 'post',
        url: 'https://localhost:44333/api/user',
        data: {
          userName: newUser.userName,
          email: newUser.email,
          userPassword: newUser.userPassword
        }
      }).then(response => {
        if (Number(response.data)) {
          commit('updateMailboxBusy', !response.data);
          commit('updateVisibleRegistrationForm', !response.data);
          commit('updateVisibleRegistrationSuccess', response.data);
        } else {
          commit('updateMailboxBusy', !response.data);
        }
      });
    }
  },
  mutations: {
    updateMailboxBusy (state, data) {
      state.mailboxBusy = data;
    },
    updateVisibleRegistrationForm (state, data) {
      state.isVisibleRegistrationForm = data;
    },
    updateVisibleRegistrationSuccess (state, data) {
      state.isVisibleRegistrationSuccess = data;
    }
  },
  state: {
    mailboxBusy: false,
    isVisibleRegistrationSuccess: false,
    isVisibleRegistrationForm: false
  },
  getters: {
    getMailboxBusy (state) {
      return state.mailboxBusy;
    },
    getRegistrationSuccess (state) {
      return state.isVisibleRegistrationSuccess;
    },
    getRegistrationForm (state) {
      return state.isVisibleRegistrationForm;
    }
  }
};
