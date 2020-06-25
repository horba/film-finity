export default {
  name: 'ff-news',
  data: function () {
    return {
      newsList: []
    };
  },
  created () {
    this.$store.dispatch('getNews');
    this.newsList = this.$store.state.news.news;
  }
};
