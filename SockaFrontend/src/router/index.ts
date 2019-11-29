import Vue from 'vue'
import VueRouter from 'vue-router'
import Opening from '../views/Opening.vue'
import Reg from '../views/Reg.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'opening',
    component: Opening
  },
  {
    path: '/reg',
    name: 'reg',
    component: Reg
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
