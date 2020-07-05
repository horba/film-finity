import axios from 'axios';
export default {
  state: () => ({
    reviews: []
  }),
  mutations: {
    initReviews (state, serverData) {
      state.reviews = serverData;
    }
  },
  actions: {
    getReviews ({ state, commit, rootState }) {
      axios
        .get(`${rootState.baseUrl}/api/Reviews/Reviews`, {
          params: {
            UserId: 1
          }
        })
        .then(response => { commit('initReviews', response.data); });
    }
  }
};
