<template>
  <v-app id="opening">
    <v-container fluid>
      <v-app-bar app flat color="background">
        <v-toolbar-title class="headline">
          <span class="font-weight-light">Ultimate</span>
          <span>Web</span>
        </v-toolbar-title>
        <v-spacer></v-spacer>
        <v-toolbar-items>
            <Login />       
        </v-toolbar-items>        
      </v-app-bar>
      <v-content>  
        <v-row>
          <v-col :md="4" :sm="12">
            <h1 class="introA">Všetko čo potrebuješ</h1>
            <h1 class="introB">na jednom mieste.</h1> 
            <router-link class="link" :to="{name: 'reg'}">
              <v-btn 
                height="40px" 
                width="200px" 
                color="main"
                depressed 
                class="btn">
                Zaregistuj sa
              </v-btn>
            </router-link>
          </v-col>
          <v-col :md="8" :sm="12" class="center">
            <v-img src="@/assets/frisbee-guy.svg" aspect-ratio="1.7" contain ></v-img>
          </v-col>
        </v-row>
      </v-content>
    </v-container>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import Login from "@/components/Login.vue";


export default Vue.extend({
  components:{
    Login
  }
  
})
</script>

<style lang="scss" scoped>
.introA{
  position: absolute;
  top: 35%;
  left: 10%;
  font-style: normal;
  font-weight: normal;
  font-size: 48px;
  line-height: 56px;
}
.introB{
  position: absolute;
  top: 42%;
  left: 10%;
  font-style: normal;
  font-weight: bold;
  font-size: 48px;
  line-height: 56px;
}
.link{
  text-decoration: none;
}
.btn{
  position: absolute;
  border-radius: 10px;
  top: 55%;
  left: 10%;
  font-style: normal;
  font-weight: bolder;
  font-size: 14px;
  line-height: 28px;
}
.center{
   display: flex;
   align-items: center;
   justify-content: center;
   height: 85vh;
}
</style>

 