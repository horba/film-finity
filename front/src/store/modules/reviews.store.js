import axios from 'axios';
export default {
  state: () => ({
    reviews: Object,
    PageNumber: 1,
    SortOrder: 0
  }),
  mutations: {
    initReviews (state, serverData) {
      state.reviews = serverData;
      state.PageNumber = state.reviews.pageNumber;
    },
    initSortOrder (state, data) {
      state.SortOrder = Number(data);
    },
    initPageNumber (state, serverData) {
      state.PageNumber = Number(serverData);
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
          SortOrder: pagedRequest.SortOrder ? Number(pagedRequest.SortOrder) : 0,
          PageNumber: Number(state.PageNumber),
          PageSize: pagedRequest.PageSize
        }
      })
        .then(response => { commit('initReviews', response.data); });
    },
    getReviewPage ({ state, commit, rootState }, pagedRequest) {
      axios({
        method: 'post',
        url: `${rootState.baseUrl}/api/Reviews/FindReview`,
        data: {
          UserId: 1,
          SortOrder: state.SortOrder,
          PageSize: pagedRequest.PageSize,
          TitleName: pagedRequest.TitleName
        }
      })
        .then(response => { commit('initPageNumber', response.data); })
        .then(() => {
          this.dispatch('getReviews', {
            PageSize: pagedRequest.PageSize,
            SortOrder: state.SortOrder
          });
        });
    }
  }
};
