<template>
  <v-app-bar app flat color="secondary">
        <v-spacer></v-spacer>
          <v-toolbar-items class="center">
            <v-menu offset-y>
              <template v-slot:activator="{ on }">
                <v-btn
                class="btn" 
                height="20px" 
                width= "80px"
                v-on="on"
                color="transparent"
                depressed
                >
                Menu
                </v-btn>
              </template>
              <v-list>
                <v-list-item>
                  <v-list-item-title>
                    <v-row>
                      <v-col>
                        <a class="navigation" href="http://Localhost:8080">Domov</a>
                      </v-col>
                    </v-row>
                    <v-row>
                      <v-col>
                        <a class="navigation" href="http://localhost:8080/addTournament">Turnaje</a>
                      </v-col>
                    </v-row>                              
                  </v-list-item-title>
                </v-list-item>
              </v-list>
            </v-menu>
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
            <a class="navigation" href="http://">Účet</a>    
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
.navigation{
  text-decoration: none;
  color: black;
  font-family: 'Sulphur Point', serif;
  font-style: normal;
  font-weight: bold;
  font-size: 18px;
}
</style>
