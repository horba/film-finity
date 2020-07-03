import { FfReviewsBlocks, FfReviewsRows } from '@components/reviews';
export default {
  data: function () {
    return {
      rate: 4.0,
      rateGeneral: 0.5,
      isRowView: true
    };
  },
  components: {
    FfReviewsBlocks, FfReviewsRows
  },
  methods: {
    getImgSrc () {
      return 'https://localhost:5001/StaticFiles/images/20.jpg';
    },
    onClick () {
      this.isRowView = !this.isRowView;
    }
  },
  name: 'ff-review'
};
