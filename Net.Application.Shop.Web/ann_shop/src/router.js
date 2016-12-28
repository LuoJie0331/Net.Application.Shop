import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

const routes = [
  {path: '/', component: require('./views/index.vue')},
  {path: '/hello', component: require('./views/hello.vue')},
  {path: '/detail/:id', component: require('./views/detail.vue')},
  {path: '/user', component: require('./views/user.vue')},
  {path: '/order', component: require('./views/order.vue')},
]

export default new Router({
  mode: 'hash',
  routes
})