
export default {
  name: 'favorites-tile',
  data () {
    return {
    };
  },
  computed: {
    getfavoritesList () {
      return this.$store.state.favorites.favorites;
    }
  }
};
