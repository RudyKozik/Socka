<template>
  <v-card
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
      <v-btn icon>
        <v-icon>mdi-heart</v-icon>
        <span>
        {{feed.likes}}
        </span>
      </v-btn>
      <v-btn icon>
        <v-icon>mdi-comment-processing</v-icon>
      </v-btn>
    </v-card-actions>
  </v-card>
</template>

<script lang="ts">
import Vue from 'vue'
import Component from 'vue-class-component';
import { FeedModule } from '../store/modules/FeedModule';

export default Vue.extend({
  props:["feed"]
})

</script>

<style scoped>

</style>