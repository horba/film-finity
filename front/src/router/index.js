import { Cartoons, FfCelebrities, Movies, News, Serials, Reviews } from '@views';

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
  }
],

      router = new VueRouter({
        mode: 'history',
        base: process.env.BASE_URL,
        routes
      });

export default router;
