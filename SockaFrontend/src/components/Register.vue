<template>
  <v-app>
    <form action="" method="post">
        <v-row>
          <v-col :md="6">
            <v-text-field v-model="userName" label="Meno a priezvisko" outlined></v-text-field>
          </v-col>
          <v-col :md="6">
            <v-text-field v-model="email" label="Mail" outlined></v-text-field>
          </v-col>

          <v-col :md="6">
            <v-text-field type="password" v-model="password" label="Heslo" outlined></v-text-field>
          </v-col>

          <v-col :md="6">
            <v-text-field type="password" v-model="reRassword" label="Opakovať heslo" outlined></v-text-field>
          </v-col>

           <v-col :md="8">
            <v-btn class="btn" @click="register" outlined>Registrovať sa</v-btn>
          </v-col>
        </v-row>
     </form>
  </v-app>
</template>

<script lang="ts">
import Vue from 'vue'
export default Vue.extend({
  
})
</script>

