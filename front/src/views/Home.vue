<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png">
    <hello-world msg="Welcome to Your Vue.js App from HelloWorld"/>
    <hello-world-one-file
      msg="Welcome to Your Vue.js App from HelloWorld one file component (OFC)"
    ></hello-world-one-file>
    <actors-template/>
  </div>
</template>

<script>
// @ is an alias to /src
import { HelloWorld, ActorsTemplate, HelloWorldOneFile } from '@components';

export default {
  name: 'Home',
  components: {
    HelloWorld,
    HelloWorldOneFile,
    ActorsTemplate
  }
};
</script>
