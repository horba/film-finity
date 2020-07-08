import axios from 'axios';

export default {
  state: () => ({
    movieDetails: []
  }),
  getters: {},
  mutations: {
    updateMovie (state, movieDetails) {
      state.movieDetails = movieDetails;
    }
  },
  actions: {
    async getMovieDetails ({ state, commit, rootState }) {
      await axios
        .get(`${rootState.baseUrl}/api/movies/7`)
        .then(response => { commit('updateMovie', response.data); });
    }
  }
};
