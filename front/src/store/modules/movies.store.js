import axios from 'axios';
export default {
  state: () => ({
    movies: []
  }),
  mutations: {
    initMovies (state, serverData) {
      state.movies = serverData;
    }
  },
  getters: {
    getMoviesList (state) {
      return state.movies;
    }
  },
  actions: {
    getMovies ({ state, commit, rootState }) {
      axios
        .get(`${rootState.baseUrl}/api/Movie/Movies`)
        .then(response => { commit('initMovies', response.data); });
    }
  }
};
