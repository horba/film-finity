<template>
  <div id="app">
    <div>
      <router-link to="/">Home</router-link>
    </div>
    <router-view />
  </div>
</template>

<script>
export default {
  name: 'app',
  data () {
    return {};
  }
};
</script>

<style></style>
