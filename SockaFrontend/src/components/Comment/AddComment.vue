<template>
  <div>
    <v-row>
      <v-col :md="9">
        <v-text-field
        class="txtField" 
        dense 
        color="main"
        v-model="content" 
        label="Napíš komentár..." 
        outlined>
        </v-text-field>
      </v-col>
      <v-col :md="3" >
        <v-btn
        height="40px"
        width="120px"
        depressed
        outlined
        color="main"
        @click="AddComment"
        class="btn">
          Poslať
        </v-btn>
      </v-col>
    </v-row>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import Component from 'vue-class-component'
import { FeedModule, ISendComment } from '@/store/modules/FeedModule';

@Component
export default class AddComment extends Vue{
  content: string = "";
  id: number = 0;
  
  public async AddComment(){
    let comment = await FeedModule.SendComment({content: this.content, idOfFeed: this.id} as ISendComment);
  }
}
</script>

<style scoped>
.btn {
  border-radius: 10px;
  font-family: "Sulphur Point", serif;
  font-style: normal;
  font-weight: bold;
  font-size: 14px;
  line-height: 28px;
}
.txtField{
  font-family: 'Sulphur Point', serif;
  border-radius: 10px;
}
</style>