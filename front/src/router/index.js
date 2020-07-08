import { Cartoons, FfCelebrities, Movies, News, Serials, Favorites, Reviews } from '@views';
import store from '@store';

import Vue from 'vue';
import VueRouter from 'vue-router';

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
  },
  {
    path: '/favorites',
    component: Favorites,
    meta: {
      requiresAuth: true
    }
  },
  {
    path: '/reviews',
    component: Reviews,
    meta: {
      requiresAuth: true
    }
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
