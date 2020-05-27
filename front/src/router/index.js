import Vue from 'vue';
import VueRouter from 'vue-router';
import { Home, Movies, Serials, Cartoons, News, Actors } from '@views';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home,
    children: [
      {
        path: 'movies',
        component: Movies
      },
      {
        path: 'serials',
        component: Serials
      },
      {
        path: 'cartoons',
        component: Cartoons
      },
      {
        path: 'news',
        component: News
      },
      {
        path: 'actors',
        component: Actors
      }
    ]
  }
],

      router = new VueRouter({
        mode: 'history',
        base: process.env.BASE_URL,
        routes
      });

export default router;
