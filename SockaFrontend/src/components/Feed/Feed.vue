<template>
  <v-card
  class="feed"
  light
  width="600">
    <v-card-text 
    class="headline font-weight-bold">
      {{feed.status}}
    </v-card-text>
    <v-divider></v-divider>
    <v-card-actions>
      <v-card-text>
        {{feed.author}}
      </v-card-text>
      <v-card-text>
        {{feed.date}}
      </v-card-text>
      <v-spacer></v-spacer>
      <v-btn 
      icon
      @click="SendLike()">
        <v-icon>mdi-heart</v-icon>
      </v-btn>
      <span>
        {{feed.likes}}
      </span>
      <v-btn icon>
        <v-icon>mdi-comment-processing</v-icon>
      </v-btn>
    </v-card-actions>
    <v-divider></v-divider>
    <v-card-text>
      <AddComment />
      <Comments :comments="comments" />
    </v-card-text>
  </v-card>
</template>

<script lang="ts">
import Vue from 'vue'
import Component from 'vue-class-component';
import { FeedModule, ISendLike } from '@/store/modules/FeedModule';
import Comments from "@/components/Comment/Comments.vue"
import  AddComment  from "@/components/Comment/AddComment.vue";

@Component({
  components:{
    Comments,
    AddComment
  },
  props:["feed", "comments"]
})
export default class Feed extends Vue{
  id: number = 0;
  like: number = 1;

  public async SendLike(){
    this.id = this.$props.feed.id;
    let result = await FeedModule.SendLike({idOfFeed: this.id, like: this.like } as ISendLike);
  }
}

</script>

<style scoped>
.feed{
  margin-bottom: 25px;
}
</style>