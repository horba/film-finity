import axios from 'axios';
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
      axios
        .get(`${rootState.baseUrl}/api/Celebrity/Celebrities`)
        .then(response => { commit('initCelebrities', response.data); });
    }
  }
};
