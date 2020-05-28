
export default {
  name: 'ff-celebrities',
  filters: {
    modifyJobTitles (titles) {
      return titles.map(element => ' ' + element.jobName).join();
    }
  },
  methods: {
    getImgSrc (imgPath) {
      return this.$store.state.baseUrl + '/' + imgPath;
    }
  },
  computed: {
    getCelebritiesList () {
      return this.$store.getters.getCelebritiesList;
    }
  },
  created () {
    this.$store.dispatch('getCelebrities');
  }
};
