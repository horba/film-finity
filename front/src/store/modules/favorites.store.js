import axios from 'axios';
export default {
  state: () => ({
    favorites: [],
    totalCount: null,
    pageSize: null

  }),
  getters: {},
  mutations: {
    updateFavorites (state, favorites) {
      state.favorites = favorites;
    },
    updateTotalCount (state, totalCount) {
      state.totalCount = totalCount;
    },
    updatePageSize (state, pageSize) {
      state.pageSize = pageSize;
    }
  },
  actions: {
    async getFavorites ({ state, commit, rootState }, request) {
      await axios
        .get(`${rootState.baseUrl}/api/Favorite/${request.currentPage}/${request.sortState}`)
        .then(response => {
          commit('updateFavorites', response.data.data);
          commit('updateTotalCount', response.data.totalCount);
          commit('updatePageSize', response.data.pageSize);
        });
    }
  }
};
