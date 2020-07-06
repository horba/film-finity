
export default {
  name: 'favorites-list',
  data () {
    return {
      currentPage: 1
    };
  },
  computed: {
    getfavoritesList () {
      return this.$store.state.favorites.favorites;
    },
    getTotalCount () {
      return this.$store.state.favorites.totalCount;
    },
    getPageSize () {
      return this.$store.state.favorites.pageSize;
    }
  },
  created () {
    this.$store.dispatch('getFavorites', this.currentPage);
  },
  methods: {
    handleCurrentChange (val) {
      this.currentPage = val;
      this.$store.dispatch('getFavorites', this.currentPage);
    }

  }
};
