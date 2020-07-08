
import { Cartoons, FfCelebrities, Movies, News, Serials, Reviews, Favorites } from '@views';
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
    path: '/reviews',
    component: Reviews
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
