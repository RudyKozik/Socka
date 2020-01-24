<template>
  <v-app-bar app flat color="secondary">
        <v-spacer></v-spacer>
          <v-toolbar-items class="center">
            <v-btn
            text
            height="25px"
            width="80px"
            color="black"
            class="btn">
            Menu
            </v-btn>
          </v-toolbar-items>
        <v-spacer></v-spacer>
          <v-toolbar-title class="headline">
            <span class="font-weight-light">Ultimate</span>
            <span>Web</span>
          </v-toolbar-title>
        <v-spacer></v-spacer>
          <v-toolbar-items class="center">
            <v-btn
            text
            class="btn" 
            height="20px" 
            width= "80px"
            color="black"
            >
            User
            </v-btn>
          </v-toolbar-items>
        <v-spacer></v-spacer>
      </v-app-bar>
</template>

<script lang="ts">
import Vue from 'vue'
import Component from 'vue-class-component'
import LoginModule from "@/store/modules/LoginModule.vue"

@Component
export default class AppBar extends Vue{
  userName: string = "";
}
</script>

<style scoped>
.btn{
  font-family: 'Sulphur Point', serif;
  font-style: normal;
  font-weight: bold;
  font-size: 18px;
  line-height: 28px;
  border-radius: 10px;
}
</style>
