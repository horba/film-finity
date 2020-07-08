import axios from 'axios';
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
      axios
        .get(`${rootState.baseUrl}/api/News/News`)
        .then(response => { commit('initNews', response.data); });
    }
  }
};
