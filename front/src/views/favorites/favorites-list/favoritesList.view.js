
export default {
  name: 'favorites-list',
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
