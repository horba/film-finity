export default {
  data: function () {
    return {
      rate: 4.0,
      rateGeneral: 0.5
    };
  },
  props: {
    reviews: Array
  },
  methods: {
    getImgSrc () {
      return 'https://localhost:5001/StaticFiles/images/20.jpg';
    }
  },
  name: 'ff-review'
};
