export default {
  name: 'ff-movies',
  filters: {
    firstElement (titles) {
      return titles[0].fullName + ',';
    },
    withoutFirstElement (titles) {
      const resultTitles = [];
      for (let i = 0; i < titles.length - 1; i++) { resultTitles[i] = titles[i + 1]; }
      return resultTitles;
    }
  },
  methods: {
    getImgSrc (imgPath) {
      return `${this.$store.state.baseUrl}/${imgPath}`;
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
