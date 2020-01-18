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
            <Feeds v-on="GetAll()" :feeds="feeds" />
          </v-col>
        </v-row>  
      </v-content>
    </v-container>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import AppBar from "@/components/AppBar.vue";
import AddFeed from '@/components/AddFeed.vue'
import Feeds from "@/components/Feeds.vue";
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

  public async GetAll(){
    let result = await FeedModule.GetAll();
    FeedModule.SetFeed(result);
    this.feeds = FeedModule.feed;
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
