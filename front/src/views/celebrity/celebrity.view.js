export default {
  name: 'celebrity',
  filters: {
    modifyJobTitles (titles) {
      return titles.map(element => ' ' + element.jobName).join();
    }
  },
  computed: {
    celebrity () {
      return this.$store.getters.getCelebrity;
    }
  },
  created () {
    this.$store.dispatch('Celebrity', this.$route.params.id);
  },
  methods: {
    getImgSrc () {
      const path = '/StaticFiles/images/biography/';
      return this.$store.state.baseUrl + path + this.$route.params.id + '.jpg';
    }
  }
};
