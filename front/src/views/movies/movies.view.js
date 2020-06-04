export default {
  name: 'ff-movies',
  filters: {
    modifyActorsList (titles) {
      return titles.map(element => ' ' + element.actorName).join();
    }
  },
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
