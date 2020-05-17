import Vue from 'vue';
import VueRouter from 'vue-router';
import { Authorize, UnregisteredUser, RegisteredUser, Admin, Moderator, TextManager } from '@views';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'UnregisteredUser',
    component: UnregisteredUser
  },
  {
    path: '/authorize',
    name: 'Authorize',
    component: Authorize
  },
  {
    path: '/registeredUser',
    name: 'RegisteredUser',
    component: RegisteredUser
  },
  {
    path: '/admin',
    name: 'Admin',
    component: Admin
  },
  {
    path: '/moderator',
    name: 'Moderator',
    component: Moderator
  },
  {
    path: '/contentManager',
    name: 'ContentManager',
    component: TextManager
  }
],

      router = new VueRouter({
        mode: 'history',
        base: process.env.BASE_URL,
        routes
      });

export default router;
