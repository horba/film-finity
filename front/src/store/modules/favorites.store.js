import axios from 'axios';
export default {
  state: () => ({
    favorites: []
  }),
  getters: {},
  mutations: {
    updateFavorites (state, favorites) {
      state.favorites = favorites;
    }
  },
  actions: {
    async getFavorites ({ state, commit, rootState }) {
      await axios
        .get(`${rootState.baseUrl}/api/Favorite`)
        .then(response => { commit('updateFavorites', response.data); });
    }
  }
};
