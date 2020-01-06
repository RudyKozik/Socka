import Vue from 'vue'
import VueRouter from 'vue-router'
import Welcome from '../views/WelcomePage.vue'
import Reg from '../views/RegPage.vue'
import Home from "../views/HomePage.vue";
import { LoginModule } from '@/store/modules/LoginModule';

Vue.use(VueRouter)

const routes = [
  {
    path: '/welcome',
    name: 'welcome',
    component: Welcome
  },
  {
    path: '/registration',
    name: 'reg',
    component: Reg
  },
  {
    path: '/',
    name: 'home',
    component: Home
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
