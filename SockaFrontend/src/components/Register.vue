<template>
    <div class="box">
      <form action="" method="post">
        <v-row class="center">
          <v-col :md="10" :sm="10">
            <v-text-field 
              class="first" 
              v-model="userName" 
              label="Meno a priezvisko" 
              single-line 
              outlined>
            </v-text-field>
          </v-col>
        </v-row>
        <v-row class="center">
          <v-col :md="10" :sm="10">
            <v-text-field 
              v-model="email" 
              label="Mail" 
              single-line 
              outlined>
            </v-text-field>
          </v-col>
        </v-row> 
        <v-row class="center">
          <v-col :md="10" :sm="10"> 
            <v-text-field 
              type="password" 
              v-model="password" 
              label="Heslo" 
              single-line 
              outlined 
              hint="Uistite sa, že je to najmenej 8 znakov vrátane čísla a velkého písmena.">
            </v-text-field>
          </v-col>
        </v-row>
        <v-row class="center">
          <v-col :md="12" :sm="12">
            <v-btn 
              class="btn" 
              height="40px" 
              width="200px" 
              color="main" 
              depressed>
              Registrácia
            </v-btn>
          </v-col>
        </v-row>        
     </form>
    </div>
</template>

<script lang="ts">
import Vue from 'vue'

export default Vue.extend({
  data: () => ({
    return(){

    }
  }),
})
</script>

<style lang="scss" scoped>
.box{
  border: 2px solid black;
  border-radius: 10px;
  text-align: center;
  width: 500px;
	height: 550px;
}
.btn{
  border-radius: 10px;
  font-style: normal;
  font-weight: bolder;
  font-size: 14px;
  line-height: 28px;
  margin-top: 50px;
  
}
.center{
   display: flex;
   align-items: center;
   justify-content: center;
}
.first{
  margin-top: 40px;
}
</style>

