<template>
    <div>
         <v-app-bar app>
      <v-toolbar-title class="headline">
        <span>Ulti</span>
        <span class="font-weight-light">Web</span>
      </v-toolbar-title>
      <v-spacer></v-spacer>
        <v-toolbar-items>

        </v-toolbar-items>
    </v-app-bar>

    <v-content>
        <Reg  />
    </v-content>
    </div>
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