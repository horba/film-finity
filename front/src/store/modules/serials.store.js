import axios from 'axios';
export default {
  actions: {
    async getSerials ({ state, commit, rootState }) {
      await axios
        .get(`${rootState.baseUrl}/api/Serial`)
        .then(response => { commit('updateSerials', response.data); });
    }
  },
  mutations: {
    updateSerials (state, serials) {
      state.serials = serials;
    }
  },
  state: () => ({
    serials: []
  }),
  getters: {}
};
