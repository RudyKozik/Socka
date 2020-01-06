<template>
    <div id="reg">
      <v-container fluid>
        <AppBar />
        <v-content>
          <v-row> 
            <v-col xs12 :lg="5" :sm="12" class="center">
              <Reg />
            </v-col>
            <v-col xs12 :lg="7" :sm="12" class="center">
              <v-img src="@/assets/runner.svg" aspect-ratio="2.2" contain></v-img>
            </v-col>
          </v-row>
        </v-content>
      </v-container>
    </div>
</template>

<script lang="ts">
import Vue from "vue";
import Reg from "@/components/Register.vue";
import AppBar from "@/components/AppBar.vue";

export default Vue.extend({
  components:{
    Reg,
    AppBar
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