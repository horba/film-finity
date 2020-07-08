import axios from 'axios';
export default {
  state: () => ({
    serials: []
  }),
  getters: {},
  mutations: {
    updateSerials (state, serials) {
      state.serials = serials;
    }
  },
  actions: {
    async getSerials ({ state, commit, rootState }) {
      await axios
        .get(`${rootState.baseUrl}/api/Serial`)
        .then(response => { commit('updateSerials', response.data); });
    }
  }
};
