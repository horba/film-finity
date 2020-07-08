<template>
  <div id="app">
    <ff-menu/>
    <div class="main-content">
      <FfSideBar v-if="isLoggedIn"/>
      <router-view></router-view>
    </div>
    <ff-footer/>
  </div>
</template>

<style src="@styles/common.css"></style>

<style src="@styles/variables.css"></style>

<script>
import { FfMenu, FfFooter, FfSideBar } from '@layouts';
import '@filters';

export default {
  name: 'app',
  components: {
    FfMenu,
    FfFooter,
    FfSideBar
  },
  data () {
    return {};
  },
  computed: {
    isLoggedIn: function () {
      return this.$store.getters.isLoggedIn;
    }
  },
  created: function () {
    this.$http.interceptors.response.use(undefined, function (err) {
      return new Promise(function (resolve, reject) {
        if (err.status === 401 && err.config && !err.config.__isRetryRequest) {
          this.$store.dispatch('logout');
        }
        throw err;
      });
    });
  }
};
</script>

<style>
  body {
    margin: 0px;
    font-family: var(--txt-font);
  }
  .main-content {
    display: flex;
  }
</style>
