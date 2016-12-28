import Vue from 'vue'
import Router from 'vue-router'

import Hello from '../views/Hello.vue'
import Demo from '../views/Demo.vue'
import Eleme from '../views/Eleme.vue'
import App from '../App.vue'

Vue.use(Router)

const routes = [
  {path: '/', component: App},
  {path: '/hello', component: Hello},
  {path: '/demo', component: Demo},
  {path: '/element', component: Eleme}
]

export default new Router({
  mode: 'hash',
  routes
})
