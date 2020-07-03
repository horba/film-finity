
export default {
  name: 'favorites-view',
  computed: {
    getfavoritesList () {
      return this.$store.state.favorites.favorites;
    }
  },
  created () {
    this.$store.dispatch('getFavorites');
  }
};
