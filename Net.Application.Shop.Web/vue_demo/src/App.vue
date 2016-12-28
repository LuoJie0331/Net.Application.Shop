<template>
  <div id="app">
    <router-link to="/hello">
      Hello
    </router-link>
    <router-link to="/demo">
      Demo
    </router-link>
    <router-link to="/element">
      Element
    </router-link>
    <router-view></router-view>
    <!--<hello></hello>-->
    <!--<demo></demo>-->
  </div>
</template>

<script>
// import Hello from './components/Hello'
// import Demo from './components/Demo'

export default {
  name: 'app',
  components: {
    // Hello,
    // Demo
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
