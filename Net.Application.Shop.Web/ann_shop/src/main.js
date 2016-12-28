import Vue from 'vue'
import Router from 'vue-router'
// import Resource from 'vue-resource'

import router from './router.js'
import Http from './util/http.js'

import App from './App'
import Mint from 'mint-ui';
import 'mint-ui/lib/style.css'

Vue.use(Mint);
Vue.use(Http)

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  template: '<App/>',
  components: { App },
  render: h => h(App)
})
