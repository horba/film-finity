import axios from 'axios';
export default {
  state: () => ({
    reviews: Object,
    PageNumber: 1
  }),
  mutations: {
    initReviews (state, serverData) {
      state.reviews = serverData;
      state.PageNumber = state.reviews.pageNumber;
    },
    incrementCurrentPage (state) {
      state.PageNumber++;
    },
    decrementCurrentPage (state) {
      state.PageNumber--;
    }
  },
  actions: {
    getReviews ({ state, commit, rootState }, pagedRequest) {
      axios({
        method: 'post',
        url: `${rootState.baseUrl}/api/Reviews/Reviews`,
        data: {
          UserId: 1,
          PageNumber: state.PageNumber,
          PageSize: pagedRequest.PageSize
        }
      })
        .then(response => { commit('initReviews', response.data); });
    }
  }
};
