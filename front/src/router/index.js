import Vue from 'vue';
import VueRouter from 'vue-router';
import { Movies, Serials, Cartoons, News, Actors } from '@views';

Vue.use(VueRouter);

const routes = [
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
    path: '/actors',
    component: Actors
  }
],

      router = new VueRouter({
        mode: 'history',
        base: process.env.BASE_URL,
        routes
      });

export default router;
