import Vue from 'vue'
import App from './App'
import router from './router/index'

import Element from 'element-ui'
import 'element-ui/lib/theme-default/index.css'

Vue.use(Element)

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  template: '<App/>',
  components: { App },
  render: h => h(App)
})
