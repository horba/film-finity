export default {
  props: {
    reviews: Array
  },
  methods: {
    getAverageFromArray (floats) {
      return floats.reduce((a, b) => a + b) / floats.length;
    },
    pageChanged () {
      this.$store.dispatch('getReviews', {
        PageSize: 4
      });
    }
  },
  created () {
    this.pageChanged();
  },
  name: 'ff-review'
};
