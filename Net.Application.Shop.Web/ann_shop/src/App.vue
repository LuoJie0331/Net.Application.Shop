<template>
  <div id="app">
    <div>
      <!--<span>MintUI</span>-->
      <router-view></router-view>
    </div>
    <!--<mt-tabbar v-model="selected">
      <mt-tab-item id="tab1">
        tab1
      </mt-tab-item>
      <mt-tab-item id="tab2">
        tab2
      </mt-tab-item>
      <mt-tab-item id="tab3">
        tab3
      </mt-tab-item>
      <mt-tab-item id="tab4">
        tab4
      </mt-tab-item>
    </mt-tabbar>-->
  </div>
</template>

<script>
import Hello from './components/hello'

export default {
  name: 'app',
  components: {
    Hello
  }
}
</script>

<style>
#app {
  /*font-family: 'Avenir', Helvetica, Arial, sans-serif;*/
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  font-family: "Microsoft YaHei",微软雅黑,"MicrosoftJhengHei",华文细黑,STHeiti,MingLiu;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: black;
  /*margin-top: 60px;*/
}
body{
  margin: 0px;
}
img{
  width: 100%;
}
.horizontal{
  overflow: hidden;
}
.horizontal div{
  float: left;
}
.page{
  background-color: #f4f4f4;
}
</style>
