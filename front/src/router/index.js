import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '@views/Home.vue';
import { FfCelebrities } from '@views';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/celebrities',
    name: 'Celebrities',
    component: FfCelebrities
  }
],

      router = new VueRouter({
        mode: 'history',
        base: process.env.BASE_URL,
        routes
      });

export default router;
