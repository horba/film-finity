
export default {
  name: 'ff-serials',
  computed: {
    getSerialsList () {
      return this.$store.getters.getSerialsList;
    }
  },
  created () {
    this.$store.dispatch('getSerials');
  },
  methods: {
    getImgSrc (imgPath) {
      return this.$store.state.baseUrl + '/' + imgPath;
    }
  },
  filters: {
    spaceBetweenElement (titles) {
      return titles.map(element => ' ' + element.firstName + ' ' + element.lastName).join();
    }
  }
};
