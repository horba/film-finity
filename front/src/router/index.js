import Vue from 'vue';
import VueRouter from 'vue-router';
<<<<<<< HEAD
import Home from '@views/Home.vue';
import { FfCelebrities } from '@views';
=======
import { Movies, Serials, Cartoons, News, Actors } from '@views';
>>>>>>> dev

Vue.use(VueRouter);

const routes = [
  {
<<<<<<< HEAD
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/celebrities',
    name: 'Celebrities',
    component: FfCelebrities
=======
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
>>>>>>> dev
  }
],

      router = new VueRouter({
        mode: 'history',
        base: process.env.BASE_URL,
        routes
      });

export default router;
