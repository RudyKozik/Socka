import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import vuetify from './plugins/vuetify';
import * as firebase from 'firebase';


Vue.config.productionTip = false

new Vue({
  router,
  store,
  vuetify,
  render: h => h(App)
}).$mount('#app')

var config = {
  apiKey: "AIzaSyDu36_qFlriJ_RlnQ5us1T6UtFXvP1fk7M",
  authDomain: "ultimateweb-8eddb.firebaseapp.com",
  databaseURL: "https://ultimateweb-8eddb.firebaseio.com",
  projectId: "ultimateweb-8eddb",
  storageBucket: "ultimateweb-8eddb.appspot.com",
  messagingSenderId: "1079437673135",
  appId: "1:1079437673135:web:2814eb771bc70be8010a5a",
  measurementId: "G-FKBBY64K2Z"
}
firebase.initializeApp(config)
