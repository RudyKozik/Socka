<template>
    <div class="box">
      <v-row>
        <v-col>
          <span>{{team.name}}</span>
        </v-col>
      </v-row>
    </div>
</template>

<script lang="ts">
import Vue from 'vue'
export default Vue.extend({
    props:["team"]
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