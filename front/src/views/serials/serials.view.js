
export default {
  name: 'serials-view',
  computed: {
    getSerialsList () {
      return this.$store.state.serials.serials;
    }
  },
  created () {
    this.$store.dispatch('getSerials');
  }
};
