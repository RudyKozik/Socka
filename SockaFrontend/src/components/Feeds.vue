<template>
  <div>
    <div :key="feed.id" v-for="feed in feeds">
      <Feed :feed="feed" />
    </div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import Feed from "@/components/Feed.vue";
export default Vue.extend({
    components:{
      Feed
    },
    props:["feeds"]
})
</script>