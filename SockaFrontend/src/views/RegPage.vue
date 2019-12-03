<template>
    <v-app id="reg">
      <v-container fluid>
       <v-app-bar app flat color="background">
        <v-toolbar-title class="headline">
          <span class="font-weight-light">Ultimate</span>
          <span>Web</span>
        </v-toolbar-title>
        <v-spacer></v-spacer>
          <v-toolbar-items class="center">
            <router-link class="link" :to="{name: 'opening'}">
              <v-btn 
              icon
              x-large
              color="black"
              class="btn"> 
                <v-icon class="icon">mdi-arrow-left-thick</v-icon>
              </v-btn>
            </router-link> 
          </v-toolbar-items>
        </v-app-bar>

        <v-content>
          <v-row> 
            <v-col :md="5" :sm="12" class="center">
              <Reg />
            </v-col>
            <v-col :md="7" :sm="12" class="center">
              <v-img src="@/assets/runner.svg" aspect-ratio="2.2" contain></v-img>
            </v-col>
          </v-row>
        </v-content>
      </v-container>
    </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import Reg from "@/components/Register.vue";

export default Vue.extend({
  components:{
   Reg
  }
  
})
</script>


<style lang="scss" scoped>
.link{
  text-decoration: none;
}
.a{
border: 1px solid black;
}
.center{
   display: flex;
   align-items: center;
   justify-content: center;
   height: 85vh;
}
</style>