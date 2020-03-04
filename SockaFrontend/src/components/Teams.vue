<template>
  <div>
    <div :key="team.id" v-for="team in teams" >
      <Team :team="team" />
    </div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import Team from "@/components/Team.vue";
import Component from 'vue-class-component';

@Component({
  components:{
    Team
  },
  props:["teams"]
})
export default class Comments extends Vue{
  
}
</script>