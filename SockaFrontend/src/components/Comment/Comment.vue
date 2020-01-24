<template>
    <div class="box">
      <v-row>
        <v-col>
          <span>{{comment.author}}</span>
        </v-col>
        <v-col>
          <span>{{comment.content}}</span>
        </v-col>
      </v-row>
    </div>
</template>

<script lang="ts">
import Vue from 'vue'
export default Vue.extend({
    props:["comment"]
})
</script>

<style scoped>
.box{
  border-radius: 20px;
  padding: 5px;
  display: inline-block;
  background-color: gainsboro;
}
</style>