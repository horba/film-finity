export default {
  name: 'ff-news',
  data: function () {
    return {
      newsList: []
    };
  },
  created () {
    this.$store.dispatch('getNews');
    this.newsList = this.$store.state.news;
  },
  filters: {
    StringifyCategoriesByName (sourceListOfCategories) {
      return sourceListOfCategories.map(element => element.name).join(', ');
    },
    getArrayOfCategoiresName (sourceListOfCategories) {
      return sourceListOfCategories.map(a => a.name);
    }
  },
  methods: {
    getImgSrc (imgPath) {
      return this.$store.state.baseUrl + '/' + imgPath;
    }
  }
};
