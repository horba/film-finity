import { FfReviewsBlocks, FfReviewsRows } from '@components/reviews';
export default {
  data: function () {
    return {
      isRowView: true
    };
  },
  components: {
    FfReviewsBlocks, FfReviewsRows
  },
  computed: {
    getReviewsList () {
      return this.$store.state.reviews.reviews.data;
    },
    getTotalElements () {
      return this.$store.state.reviews.reviews.totalCount;
    },
    getPageSize () {
      return this.$store.state.reviews.reviews.pageSize;
    },
    getCurrentPageNumber () {
      return this.$store.state.reviews.PageNumber;
    }
  },
  beforeCreate () {
    this.$store.dispatch('getReviews', { PageSize: 2 });
  },
  methods: {
    onClick () {
      this.isRowView = !this.isRowView;
    },
    nextPageClicked () {
      this.$store.commit('incrementCurrentPage');
      this.$refs.reviews.pageChanged();
    },
    previousPageClicked () {
      this.$store.commit('decrementCurrentPage');
      this.$refs.reviews.pageChanged();
    }
  },
  name: 'ff-review'
};