export default {
  props: {
    reviews: Array
  },
  methods: {
    getAverageFromArray (floats) {
      return floats.reduce((a, b) => a + b) / floats.length;
    }
  },
  name: 'ff-review'
};
