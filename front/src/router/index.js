import { Cartoons, Favorites, FfCelebrities, MovieDetails, Movies, News, Serials } from '@views';

import Vue from 'vue';
import VueRouter from 'vue-router';
import store from '@store';

Vue.use(VueRouter);

const routes = [
  {
    path: '/celebrities',
    component: FfCelebrities
  },
  {
    path: '/movies',
    component: Movies
  },
  {
    path: '/movies/m/:id',
    component: MovieDetails
  },
  {
    path: '/serials',
    component: Serials
  },
  {
    path: '/cartoons',
    component: Cartoons
  },
  {
    path: '/news',
    component: News
    // if you want to secure view
    //  meta: {
    //   requiresAuth: true
    // }
  },
  {
    path: '/favorites',
    component: Favorites
  }
],

      router = new VueRouter({
        mode: 'history',
        base: process.env.BASE_URL,
        routes
      });
router.beforeEach((to, from, next) => {
  if (to.matched.some(record => record.meta.requiresAuth)) {
    if (store.getters.isLoggedIn) {
      next();
      return;
    }
    store.state.auth.isLoginVisible = true;
    next('/');
  } else {
    next();
  }
});
export default router;
