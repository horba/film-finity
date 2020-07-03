import axios from 'axios';
export default {
  state: {
    movies: []
  },
  mutations: {
    initMovies (state, serverData) {
      state.movies = serverData;
    }
  },
  actions: {
    getMovies ({ commit, rootState }) {
      axios
        .get(`${rootState.baseUrl}/api/movies`)
        .then(response => { commit('initMovies', response.data); });
    }
  }
};
