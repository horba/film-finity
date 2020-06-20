
export default {
  name: 'ff-serials',
  data () {
    return {
      baseUrl: this.$store.state.baseUrl
    };
  },
  computed: {
    getSerialsList () {
      return this.$store.state.serials.serials;
    }
  },
  created () {
    this.$store.dispatch('getSerials');
  }
};
