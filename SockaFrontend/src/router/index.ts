import Vue from 'vue'
import VueRouter from 'vue-router'
import Welcome from '../views/WelcomePage.vue'
import Reg from '../views/RegPage.vue'
import Home from "../views/HomePage.vue";
import { UserModule } from '@/store/modules/UserModule';
import store from '@/store';


Vue.use(VueRouter)

const router = new VueRouter({  
  mode: 'history',
  base: process.env.BASE_URL, 
  routes: [
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
      component: Home,
      beforeEnter: ((to, from, next) =>{
        if(UserModule.user == null)
        {
          next({
            name: "welcome"
          })
        } else{
          next()
        }
      })
    }
  ]
})  


export default router
