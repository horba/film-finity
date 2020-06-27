import axios from 'axios';
export default {
  state: () => ({
    celebrity: null
  }),
  mutations: {
    initCelebrity (state, serverData) {
      state.celebrity = serverData;
    }
  },
  getters: {
    getCelebrity (state) {
      return state.celebrity;
    }
  },
  actions: {
    Celebrity ({ state, commit, rootState }, id) {
      axios
        .get(`${rootState.baseUrl}/api/Celebrity/${id}`)
        .then(response => { commit('initCelebrity', response.data); });
    }
  }
};
