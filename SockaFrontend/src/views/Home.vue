<template>
<v-container fluid > 
  <v-app id="home">
    <v-app-bar app>
      <v-toolbar-title class="headline">
        <span>Ulti</span>
        <span class="font-weight-light">Web</span>
      </v-toolbar-title>
      <v-spacer></v-spacer>
        <v-toolbar-items>
           <Login  />
        </v-toolbar-items>
    </v-app-bar>

    <v-content >     
      <v-row align="center">
        <v-col :md="6" :sm="12" >
          <p class="intro">Všetko čo potrebuješ na jednom mieste.</p>   
          <router-link :to="{name: 'reg'}">
           <v-btn color="secondary" class="btn">Registuj sa</v-btn>
          </router-link>
        </v-col>
        <v-col :md="6" :sm="12" justify-self="center">
          <v-img src="../assets/Kisame.png" height="500" width="300" contain></v-img>
         </v-col>
      </v-row>
    </v-content>

    <v-footer>
      
    </v-footer>
  </v-app>
</v-container>
</template>

<script lang="ts">
import Vue from "vue";
import Login from "@/components/Login";

export default Vue.extend({
  components:{
    Login
  }
  
})
</script>

<style lang="scss" scoped>

</style>

 