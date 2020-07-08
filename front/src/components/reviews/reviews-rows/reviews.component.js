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
        PageSize: 2
      });
    },
    sortContent (value) {
      this.$store.commit('initSortOrder', value);
      this.$store.dispatch('getReviews', {
        PageSize: 2,
        SortOrder: value
      });
    },
    FindReviewPage (substring) {
      this.$store.dispatch('getReviewPage', {
        PageSize: 2,
        TitleName: substring
      });
    }
  },
  name: 'ff-review'
};
