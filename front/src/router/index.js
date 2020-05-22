import Vue from 'vue';
import VueRouter from 'vue-router';
import { User } from '@views';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'User',
    component: User
  }
],

      router = new VueRouter({
        mode: 'history',
        base: process.env.BASE_URL,
        routes
      });

export default router;
