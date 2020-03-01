<template>
  <v-card class="box">
    <form action="" method="post">
      <v-row class="center">
        <v-col :md="10">
          <v-text-field
          class="first txtField"
          label="Názov turnaja"
          v-model="name"
          color="main"
          clearable
          outlined>           
          </v-text-field>
        </v-col>
      </v-row>
      <v-row class="center">
        <v-col :md="5">
          <span class="url">localhost:8080/tounament/{{name}}</span>        
        </v-col>
        <v-col :md="5">
          <v-text-field
          class="txtField"
          label="url"
          dense 
          v-model="url"
          color="main"
          clearable
          outlined>           
          </v-text-field>
        </v-col>
      </v-row>
      <v-row class="center">
        <v-col :md="10">
          <v-combobox
          class="txtField" 
          v-model="organizer" 
          label="Organizátor"
          color="main" 
          outlined>           
          </v-combobox>
        </v-col>
      </v-row>
      <v-row class="center">
        <v-col :md="10">
          <v-text-field
          class="txtField" 
          v-model="location" 
          label="Lokácia"
          color="main" 
          outlined>           
          </v-text-field>
        </v-col>
      </v-row>
      <v-row class="center" dense>
        <v-col :md="5">
          <v-menu
          :nudge-right="40"
          transition="scale-transition"
          offset-y
          min-width="290px">
          <template v-slot:activator="{ on }">
            <v-text-field
              v-model="startDate"
              class="txtField" 
              outlined
              dense 
              label="Začiatok"
              color="main" 
              v-on="on">
              </v-text-field>
          </template>
          <v-date-picker 
          color="main" 
          v-model="startDate"
          no-title 
          scrollable
          first-day-of-week="1"
          dark></v-date-picker>
          </v-menu>
        </v-col>
        <v-col :md="5">
          <v-menu
          :nudge-right="40"
          transition="scale-transition"
          offset-y
          min-width="290px">
          <template v-slot:activator="{ on }">
            <v-text-field
              v-model="endDate"
              class="txtField" 
              outlined
              dense 
              label="Koniec"
              color="main" 
              v-on="on">
              </v-text-field>
          </template>
          <v-date-picker 
          color="main" 
          v-model="endDate"
          no-title 
          scrollable
          first-day-of-week="1"
          dark></v-date-picker>
          </v-menu>
        </v-col>
      </v-row>
      <v-row class="center" dense>
        <v-col :md="10">
          <v-btn
          class="btn"
          height="40px"
          width="200px"
          color="main"
          depressed
          >Uverejniť</v-btn>
        </v-col>
      </v-row>
    </form>
  </v-card>
</template>

<script lang="ts">
import Vue from 'vue'
import Component from 'vue-class-component'

@Component({
  
})
export default class AddTournament extends Vue{
  name: string = "";
  organizer: string = "";
  location: string = "";
  startDate: string = "";
  endDate: string = "";
  url: string = "";
}
</script>

<style scoped>
.box {
  border-radius: 10px;
  text-align: center;
  width: 700px;
  height: 600px;
}
.center {
  display: flex;
  align-items: center;
  justify-content: center;
}
.btn {
  border-radius: 10px;
  font-family: "Sulphur Point", serif;
  font-style: normal;
  font-weight: bold;
  font-size: 14px;
  line-height: 28px;
}
.first {
  margin-top: 20px;
}
.txtField {
  font-family: "Sulphur Point", serif;
}
.url{
  margin-left: 40px;
  font-size: 20px;
  font-family: "Sulphur Point", serif;
  font-style: normal;
}
</style>