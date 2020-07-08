import api from '@apiService';

export default {
  state: () => ({
    status: '',
    token: localStorage.getItem('token') || '',
    user: JSON.parse(localStorage.getItem('user')) || '',
    isLoginVisible: false,
    isConfirmationVisible: false
  }),
  getters: {
    isLoggedIn: state => !!state.token,
    authStatus: state => state.status
  },
  mutations: {
    auth_request (state) {
      state.status = 'loading';
    },
    auth_success (state, obj) {
      state.status = 'success';
      state.token = obj.token;
      state.user = obj.user;
    },
    auth_error (state) {
      state.status = 'error';
    },
    logout (state) {
      state.status = '';
      state.token = '';
    },
    ChangeLoginVisible (state) {
      state.isLoginVisible = !state.isLoginVisible;
    },
    ChangeConfirmationVisible (state) {
      state.isConfirmationVisible = !state.isConfirmationVisible;
    }
  },
  actions: {
    login ({ commit, rootState }, user) {
      return new Promise((resolve, reject) => {
        commit('auth_request');
        api
          .post('/user/authenticate', user)
          .then(resp => {
            const token = resp.data.token,
                  user = {
                    name: resp.data.username,
                    id: resp.data.id,
                    email: resp.data.email
                  };
            console.log(user);
            localStorage.setItem('token', token);
            localStorage.setItem('user', JSON.stringify(user));
            console.log(localStorage.getItem('user'));
            commit('auth_success', { token, user });
            resolve(resp);
          })
          .catch(err => {
            commit('auth_error');
            localStorage.removeItem('token');
            reject(err);
          });
      });
    },
    logout ({ commit }) {
      return new Promise((resolve, reject) => {
        commit('logout');
        localStorage.removeItem('token');
        resolve();
      });
    },
    ChangeLoginVisible ({ commit }) {
      commit('ChangeLoginVisible');
    },
    ChangeConfirmationVisible ({ commit }) {
      commit('ChangeConfirmationVisible');
    }
  }
};
