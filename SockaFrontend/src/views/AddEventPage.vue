<template>
  <div id="addEvent">
    <v-container fluid>
      <AppBar />
      <v-content>
        <v-row>
          <v-col class="center">
            <AddEvent />
          </v-col>
        </v-row>
      </v-content>
    </v-container>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import Component from 'vue-class-component'
import AddEvent from "../components/Tournaments/AddEvent.vue";
import AppBar from "../components/Layouts/AppBar.vue";

@Component({
  components:{
    AddEvent,
    AppBar
  }
})
export default class AddEventPage extends Vue{
  
}
</script>

<style scoped>
.center{
  display: flex;
  align-items: center;
  justify-content: center;
}
</style>