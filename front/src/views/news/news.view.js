export default {
  name: 'ff-news',
  computed: {
    getNewsList () {
      return this.$store.state.news.news;
    }
  },
  created () {
    this.$store.dispatch('getNews');
  }
};
