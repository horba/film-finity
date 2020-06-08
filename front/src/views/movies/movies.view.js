export default {
  name: 'ff-movies',
  methods: {
    getImgSrc (imgPath) {
      return this.$store.state.baseUrl + '/' + imgPath;
    }
  },
  computed: {
    getMoviesList () {
      return this.$store.getters.getMoviesList;
    }
  },
  created () {
    this.$store.dispatch('getMovies');
  }
};
