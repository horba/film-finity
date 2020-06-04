<template>
  <div id="app">
    <ff-menu/>
    <div class="main-content">
      <router-view></router-view>
    </div>
    <ff-footer/>
  </div>
</template>

<style src="@styles/common.css"></style>

<style src="@styles/variables.css"></style>

<script>
import { FfMenu, FfFooter } from '@layouts';

export default {
  name: 'app',
  components: {
    FfMenu, FfFooter
  },
  data () {
    return {};
  }
};
</script>

<style>
  body {
    margin: 0px;
    font-family: var(--txt-font);
  }
</style>
