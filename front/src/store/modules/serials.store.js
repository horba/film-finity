import api from '@apiService';
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
      await api.get('/Serial')
        .then(response => { commit('updateSerials', response.data); });
    }
  }
};
