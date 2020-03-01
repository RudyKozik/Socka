<template>
  <div id="addTurnament">
    <v-container fluid>
      <AppBar />
      <v-content>
        <v-row>
          <v-col class="center">
            <Profile />
          </v-col>
        </v-row>
      </v-content>
    </v-container>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import Component from 'vue-class-component'
import Profile from "../components/Profile.vue";
import AppBar from "../components/Layouts/AppBar.vue";
import { UserModule } from '@/store/modules/UserModule';

@Component({
  components:{
    Profile,
    AppBar
  }
})
export default class ProfilePage extends Vue{

}
</script>

<style scoped>
.center{
  display: flex;
  align-items: center;
  justify-content: center;
}
</style>