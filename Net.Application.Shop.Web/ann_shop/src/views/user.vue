<template>
  <div class="page-navbar">
    <mt-navbar class="page-part" v-model="selected">
      <mt-tab-item id="1">购物车</mt-tab-item>
      <mt-tab-item id="2">购物记录</mt-tab-item>
      <mt-tab-item id="3">我的红包</mt-tab-item>
      <mt-tab-item id="4">我的推广</mt-tab-item>
    </mt-navbar>
    <mt-tab-container v-model="selected">
      <mt-tab-container-item id="1">
        <Cart></Cart>
      </mt-tab-container-item>
      <mt-tab-container-item id="2">
        <mt-cell v-for="n in 4" :title="'测试 ' + n" />
      </mt-tab-container-item>
      <mt-tab-container-item id="3">
        <mt-cell v-for="n in 6" :title="'选项 ' + n" />
      </mt-tab-container-item>
      <mt-tab-container-item id="3">
        <mt-cell v-for="n in 6" :title="'选项 ' + n" />
      </mt-tab-container-item>
    </mt-tab-container>
  </div>
</template>

<style>
</style>

<script>
  import Cart from './Cart.vue'
  export default {
    name: 'user-nav',
    data() {
      return {
        selected: '1'
      };
    },
    components: {
      Cart
    }
  };
</script>
