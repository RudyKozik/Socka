<template>
  <div class="box">
    <form action="" method="post">
      <v-row class="center">
        <v-col :md="11">
          <v-textarea
          class="txtarea"
          counter
          outlined
          filled
          no-resize
          rows="6"
          dense>
          </v-textarea>
        </v-col>
      </v-row>
      <v-row class="center">
        <v-col :md="12" :sm="10">
          <v-btn 
          class="btn" 
          height="40px"
          width="150px"
          color="main">
          Uverejniť
          </v-btn>
        </v-col>
      </v-row>
    </form>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
export default Vue.extend({
  
})
</script>

<style lang="css" scoped>
.txtarea{
  font-family: 'Sulphur Point', serif;
}
.box{ 
  height: 250px;
  width: 500px;
  border: 1.5px solid black;
  border-radius: 10px;
  text-align: center;
}
.center{
  display: flex;
  align-items: center;
  justify-content: center;
}
.btn {
  border-radius: 10px;
  font-family: "Sulphur Point", serif;
  font-style: normal;
  font-weight: bold;
  font-size: 14px;
  line-height: 28px;
  margin-left: 250px; 
}
</style>