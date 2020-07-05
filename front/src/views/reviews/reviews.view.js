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
  created () {
    this.$store.dispatch('getReviews');
    this.reviews = this.$store.state.reviews.reviews;
  },
  computed: {
    getReviewsList () {
      return this.$store.state.reviews.reviews;
    }
  },
  methods: {
    onClick () {
      this.isRowView = !this.isRowView;
    }
  },
  name: 'ff-review'
};
