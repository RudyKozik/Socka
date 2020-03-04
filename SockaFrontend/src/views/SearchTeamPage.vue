<template>
  <div id="searchTeamPage">
    <v-container fluid>
      <AppBar />
      <v-content>
        <v-row>
          <v-col class="center">
            <v-card class="box">
              <form action="" method="post">  
                <v-row>
                  <v-col :md="9" :sm="8">
                    <v-text-field
                    class="txtField" 
                    dense 
                    color="main"
                    v-model="name" 
                    label="Pridať tím" 
                    outlined>
                    </v-text-field>
                  </v-col>
                  <v-col :md="3" :sm="3">
                    <v-btn
                    height="40px"
                    width="120px"
                    depressed
                    outlined
                    @click="Add()"
                    color="main"
                    class="btn">
                      Poslať
                    </v-btn>
                  </v-col>
                </v-row>
              </form>
            </v-card>
          </v-col>
        </v-row>
        <v-row>
          <v-col class="center">           
              <Teams v-on="Get()" :teams="teams" />
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
import axios from "axios";
import Teams from "../components/Teams.vue";
import { EventModule } from '../store/modules/EventModule';

@Component({
  components:{
    AddEvent,
    AppBar,
    Teams
  }
})
export default class SearchTeamPage extends Vue{
  name: string = ""
  teams: string[] = []

  public async Add(){
    let result = await axios.post("https://localhost:5001/Event/api/v1/AddTeam",{
      name: this.name
    });
    return result;
  }

  public async Get(){
    let result = await EventModule.GetAll();
    EventModule.SetTeam(result);
    this.teams = EventModule.team;
  }
}
</script>

<style scoped>
.center{
  display: flex;
  align-items: center;
  justify-content: center;
  text-align: center;
}
.box {
  border-radius: 10px;
  width: 600px;
  height: 550px;
}
.btn {
  border-radius: 10px;
  font-family: "Sulphur Point", serif;
  font-style: normal;
  font-weight: bold;
  font-size: 14px;
  line-height: 28px;
}
</style>