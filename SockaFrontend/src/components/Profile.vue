<template>
  <v-card v-on="GetUser()" class="box">
    <v-row class="center">
      <v-col class="column" md="4">
        <v-avatar color="indigo" size="150">
          <img
          src="https://previews.123rf.com/images/triken/triken1608/triken160800029/61320775-male-avatar-profile-picture-default-user-avatar-guest-avatar-simply-human-head-vector-illustration-i.jpg"
          >
        </v-avatar>
        <br>
        <span class="font-weight-bold name">{{user[0].name}} {{user[0].surname}}</span>
      </v-col>
      <v-col md="4">
        <p>Dominantná ruka</p>
        <p>Výška</p>
        <p>Číslo</p>
        <p>Hrám od roku</p>
      </v-col>
      <v-col md="4">
        <p class="font-weight-bold">Pravá</p>
        <p class="font-weight-bold">183</p>
        <p class="font-weight-bold">88</p>
        <p class="font-weight-bold">2006</p>
      </v-col>
    </v-row>
    <v-row>
      <v-card-title class="headline font-weight-bold">
      Tímy
      </v-card-title>
    </v-row>
    <v-row class="center"> 
      <v-col md="9">
      </v-col>
    </v-row>
  </v-card>
</template>

<script lang="ts">
import Vue from 'vue'
import Component from 'vue-class-component'
import { UserModule } from '../store/modules/UserModule'

@Component({

})
export default class Profile extends Vue{
  user: any[] = []

public async GetUser(){
    let result = await UserModule.GetUser();
    UserModule.SetActualUser(result);
    this.user = UserModule.actualUser;
  }
}
</script>

<style scoped>
.box {
  border-radius: 10px;
  width: 1000px;
  height: 600px;
}
.center {
  display: flex;
  align-items: center;
  justify-content: center;
}
.column{
  text-align: center;
}
.border{
  border: 2px dashed black;
}
.btn {
  border-radius: 10px;
  font-family: "Sulphur Point", serif;
  font-style: normal;
  font-weight: bold;
  font-size: 14px;
  line-height: 28px;
}
.name{
  font-family: 'Sulphur Point', serif;
  font-style: normal;
  font-weight: normal;
  font-size: 32px;
  line-height: 40px;
}
.nadpis{
  font-family: 'Sulphur Point', serif;
  font-style: normal;
  font-weight: bold;
  font-size: 48px;
  line-height: 56px;
}
.team{
  width: 250px;
  height: 250px;
}
</style>