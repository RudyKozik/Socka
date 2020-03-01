import Vue from 'vue'
import VueRouter from 'vue-router'
import Welcome from '../views/WelcomePage.vue'
import Reg from '../views/RegPage.vue'
import Home from "../views/HomePage.vue";
import AddTournament from "../views/AddTournamentPage.vue";
import Profile from "../views/ProfilePage.vue";
import { vuexCookie } from '@/store';


Vue.use(VueRouter)

const router = new VueRouter({  
  mode: 'history',
  base: process.env.BASE_URL, 
  routes: [
    {
      path: '/vitajte',
      name: 'welcome',
      component: Welcome
    },
    {
      path: '/registracia',
      name: 'reg',
      component: Reg
    },
    {
      path: '/',
      name: 'home',
      component: Home,
      beforeEnter: ((to, from, next) =>{
        if(vuexCookie.key == null)
        {
          next({
            name: "welcome"
          })
        } else{
          next()
        }
      })
    },
    {
      path: '/pridatTurnaj',
      name: 'addTournament',
      component: AddTournament
    },
    {
      path: '/profil',
      name: 'profile',
      component: Profile
    }
  ]
})  


export default router
