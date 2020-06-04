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
          document.location.href = '#created';
        } else {
          commit('updateMailboxBusy', !response.data);
        }
      });
    }
  },
  mutations: {
    updateMailboxBusy (state, data) {
      state.mailboxBusy = data;
    }
  },
  state: {
    mailboxBusy: false
  },
  getters: {
    getMailboxBusy (state) {
      return state.mailboxBusy;
    }
  }
};
