export default {
  props: {
    reviews: Array
  },
  methods: {
    getAverageFromArray (floats) {
      return (floats.reduce((a, b) => a + b) / floats.length).toFixed();
    },
    pageChanged () {
      this.$store.dispatch('getReviews', {
        PageSize: 4
      });
    },
    sortContent (value) {
      this.$store.commit('initSortOrder', value);
      this.$store.dispatch('getReviews', {
        PageSize: 4,
        SortOrder: value
      });
    },
    FindReviewPage (substring) {
      this.$store.dispatch('getReviewPage', {
        PageSize: 4,
        TitleName: substring
      });
    }
  },
  created () {
    this.pageChanged();
  },
  name: 'ff-review'
};
