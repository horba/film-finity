
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
    },
    actor (celebrity) {
      let res = false;
      for (let index = 0; index < celebrity.jobTitles.length; index++) {
        if (celebrity.jobTitles[index].jobName === 'актер') {
          res = true;
        }
      }
      return res;
    }
  }
};
