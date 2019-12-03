<template>
  <v-app id="app">
    <router-view class="background"></router-view>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";


export default Vue.extend({
  name: "App",
  components: {
  
  },
  data: () => ({
    //
  }),
});
</script>

<style lang="scss">
#app{
  margin: 0px;
  padding: 0px;
  box-sizing: border-box;
}
</style>


