<template>
  <div id="app">
    <div>
      <router-link to="/">Home</router-link>
    </div>
    <router-view />
  </div>
</template>

<style src="@styles/common.css"></style>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>

<script>
export default {
  name: 'app',
  data () {
    return {};
  }
};
</script>
