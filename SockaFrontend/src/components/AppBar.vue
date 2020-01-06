<template>
  <v-app-bar app flat color="background">
    <v-toolbar-title class="headline">
      <span class="font-weight-light">Ultimate</span>
      <span>Web</span>
    </v-toolbar-title>
    <v-spacer></v-spacer>
    <v-toolbar-items class="center">
      <router-link class="link" :to="{name: 'welcome'}">
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
</template>