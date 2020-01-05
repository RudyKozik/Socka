<template>
  <div id="home">
    <v-container fluid>
      <v-app-bar app flat color="secondary">
        <v-spacer></v-spacer>
          <v-toolbar-items class="center">
            <v-btn
            depressed>
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
            depressed>
              User
            </v-btn>
          </v-toolbar-items>
        <v-spacer></v-spacer>
      </v-app-bar>

      <v-content>
        <v-row>
          <v-col class="center">
            <AddFeed />
          </v-col>
        </v-row>
      </v-content>
    </v-container>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import AddFeed from '@/components/AddFeed.vue'

export default Vue.extend({
  components:{
    AddFeed
  }
})
</script>

<style lang="css" scoped>
.center{
  display: flex;
  align-items: center;
  justify-content: center;
}
</style>
