
import { FavoritesTile, FavoritesList } from '@views/favorites';
export default {
  name: 'favorites-view',
  components: {
    FavoritesTile, FavoritesList
  },
  data () {
    return {
      FavoritesTileVisible: true,
      FavoritesListVisible: false,
      sortState: 0,
      currentPage: 1,
      options: [{
        value: '0',
        label: this.$t('favorite.value0')
      }, {
        value: '1',
        label: this.$t('favorite.value1')
      }, {
        value: '2',
        label: this.$t('favorite.value2')
      }, {
        value: '3',
        label: this.$t('favorite.value3')
      }, {
        value: '4',
        label: this.$t('favorite.value4')
      }, {
        value: '5',
        label: this.$t('favorite.value5')
      }],
      value: this.$t('favorite.value6')
    };
  },
  computed: {
    getTotalCount () {
      return this.$store.state.favorites.totalCount;
    },
    getPageSize () {
      return this.$store.state.favorites.pageSize;
    }
  },
  created () {
    this.$store.dispatch('getFavorites', {
      currentPage: this.currentPage,
      sortState: this.sortState
    });
  },
  methods: {
    getContentPage (val) {
      this.currentPage = val;
      this.$store.dispatch('getFavorites', {
        currentPage: this.currentPage,
        sortState: this.sortState
      });
    },
    sortingContent (val) {
      this.sortState = val;
      this.$store.dispatch('getFavorites', {
        currentPage: this.currentPage,
        sortState: this.sortState
      });
    }
  }
};
