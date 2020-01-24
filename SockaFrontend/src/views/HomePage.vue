<template>
  <div id="home">
    <v-container fluid>
      <AppBar />
      <v-content>
        <v-row>
          <v-col class="center">
            <AddFeed />
          </v-col>
        </v-row>
        <v-row > 
          <v-col :md="12" class="center">
            <Feeds v-on="GetAll()" :feeds="feeds" :comments="comments" />
          </v-col>
        </v-row>  
      </v-content>
    </v-container>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import AppBar from "@/components/Layouts/AppBar.vue";
import AddFeed from '@/components/Feed/AddFeed.vue'
import Feeds from "@/components/Feed/Feeds.vue";
import { FeedModule } from '../store/modules/FeedModule';
import Component from 'vue-class-component';
import { AxiosResponse } from 'axios';

@Component({
  components:{
    AppBar,
    Feeds,
    AddFeed
  }
})
export default class HomePage extends Vue{
  feeds: any[] = []
  comments: any[] = []

  public async GetAll(){
    let result = await FeedModule.GetAll();
    let comments = await FeedModule.GetComments();
    FeedModule.SetComment(comments);
    FeedModule.SetFeed(result);
    this.feeds = FeedModule.feed;
    this.comments = FeedModule.comment;
  }
}
</script>

<style lang="css" scoped>
.center{
  display: flex;
  align-items: center;
  justify-content: center;
}
</style>
