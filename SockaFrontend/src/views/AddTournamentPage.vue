<template>
  <div id="addTurnament">
    <v-container fluid>
      <AppBar />
      <v-content>
        <v-row>
          <v-col class="center">
            <AddTournament />
          </v-col>
        </v-row>
      </v-content>
    </v-container>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import Component from 'vue-class-component'
import AddTournament from "../components/Tournaments/AddTournament.vue";
import AppBar from "../components/Layouts/AppBar.vue";

@Component({
  components:{
    AddTournament,
    AppBar
  }
})
export default class AddTournamentPage extends Vue{
  
}
</script>

<style scoped>
.center{
  display: flex;
  align-items: center;
  justify-content: center;
}
</style>