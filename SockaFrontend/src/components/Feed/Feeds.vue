<template>
  <div>
    <div :key="feed.id" v-for="feed in feeds">
      <Feed :feed="feed" :comments="comments" />
    </div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import Feed from "@/components/Feed/Feed.vue";
import Component from 'vue-class-component';

@Component({
  components:{
      Feed
    },
  props:["feeds", "comments"]
})
export default class Feeds extends Vue{
  
}
</script>