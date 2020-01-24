<template>
  <v-card class="box">
    <form action="" method="post">
      <v-row class="center">
        <v-col :md="11" :sm="11">
          <v-textarea
          class="txtarea"
          counter
          v-model="status"
          outlined
          filled
          color="main"
          no-resize
          rows="6"
          dense>
          </v-textarea>
        </v-col>
      </v-row>
      <v-row class="center">
        <v-col :md="12" :sm="10">
          <v-btn 
          @click="AddFeed()"
          class="btn" 
          height="40px"
          outlined
          width="150px"
          color="main">
          Uverejniť
          </v-btn>
        </v-col>
      </v-row>
    </form>
  </v-card>  
</template>

<script lang="ts">
import Vue from 'vue'
import Component from 'vue-class-component'
import { FeedModule, ISendFeed } from '@/store/modules/FeedModule';

@Component
export default class AddFeed extends Vue{
  status: string = "";
  
  public async AddFeed(){
    var date = new Date();
    var currentDateWithFormat = date.getDate() + "." + (date.getMonth() + 1) + " " +  date.getHours() + ":" + date.getMinutes();
    let feed = await FeedModule.SendFeed({statusToSend: this.status, dateToSend: currentDateWithFormat} as ISendFeed);
  }
}
</script>

<style lang="css" scoped>
.txtarea{
  font-family: 'Sulphur Point', serif;
}
.box{ 
  height: 250px;
  width: 600px;
  border-radius: 10px;
  text-align: center;
}
.center{
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
  margin-left: 350px;
}
</style>