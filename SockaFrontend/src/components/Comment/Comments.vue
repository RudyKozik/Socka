<template>
  <div>
    <div :key="comment.id" v-for="comment in comments" >
      <Comment :comment="comment" />
    </div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import Comment from "@/components/Comment/Comment.vue";
import Component from 'vue-class-component';

@Component({
  components:{
    Comment
  },
  props: ["comments"]
})
export default class Comments extends Vue{
  
}
</script>