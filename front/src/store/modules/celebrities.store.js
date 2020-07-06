import api from '@apiService';
export default {
  state: () => ({
    celebrities: []
  }),
  mutations: {
    initCelebrities (state, serverData) {
      state.celebrities = serverData;
    }
  },
  getters: {
    getCelebritiesList (state) {
      return state.celebrities;
    }
  },
  actions: {
    getCelebrities ({ state, commit, rootState }) {
      api
        .get('/Celebrity/Celebrities')
        .then(response => { commit('initCelebrities', response.data); });
    }
  }
};
