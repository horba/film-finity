export default {
  name: 'ff-movies',
  filters: {
    withoutFirstElement (titles) {
      return Array.isArray(titles) && titles.length ? titles.slice(1, -1) : [];
    }
  },
  methods: {
    getImgSrc (imgPath) {
      return `${this.$store.state.baseUrl}/${imgPath}`;
    },
    goMovie (id) {
      this.$router.push('/movies/m/' + id);
    }
  },
  computed: {
    getMoviesList () {
      return this.$store.state.movies.movies;
    }
  },
  created () {
    this.$store.dispatch('getMovies');
  }
};
