
import { FavoritesTile, FavoritesList } from '@views/favorites';
export default {
  name: 'favorites-view',
  components: {
    FavoritesTile, FavoritesList
  },
  data () {
    return {
      FavoritesTileVisible: true,
      FavoritesListVisible: false
    };
  }
};
