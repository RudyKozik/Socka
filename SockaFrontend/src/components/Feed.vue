<template>
  <v-card
    light
    width="500">
    <v-card-text class="headline font-weight-bold">
      {{feed}}
    </v-card-text>
    <v-divider></v-divider>
    <v-card-actions>
      <v-spacer></v-spacer>
      <v-btn icon>
        <v-icon>mdi-heart</v-icon>
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

@Component
export default class Feed extends Vue{
  feed: string = "";
}

</script>

<style scoped>

</style>