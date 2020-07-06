import api from '@apiService';

export default {
  state: () => ({
    news: []
  }),
  mutations: {
    initNews (state, serverData) {
      state.news = serverData;
    }
  },
  actions: {
    getNews ({ state, commit, rootState }) {
      api
        .get('/News/News')
        .then(response => { commit('initNews', response.data); });
    }
  }
};
