<template>
  <div>
    <div :key="comment.id" v-for="comment in filteredComments" >
      <Comment :comment="comment" />
    </div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import Comment from "@/components/Comment/Comment.vue";
import Component from 'vue-class-component';
import { FeedModule } from '../../store/modules/FeedModule';

@Component({
  components:{
    Comment
  },
  props:["filteredComments"]
})
export default class Comments extends Vue{
  
}
</script>