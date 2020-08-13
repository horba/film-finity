// import movieDetailsStore from "../../store/modules/movie-details.store";

/* eslint-disable max-len */
export default {
  name: 'ff-movie-details',
  data () {
    return {
    };
  },
  computed: {
    getMovie () {
      return this.$store.state.movieDetails.movieDetails;
    }
  },
  created () {
    this.$store.dispatch('getMovieDetails');
  },
  methods: {
    getImgSrc (imgPath) {
      return `${this.$store.state.baseUrl}/${imgPath}`;
    }
  }
};
