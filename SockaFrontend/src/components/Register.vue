<template>
  <div class="box">
    <form action method="post">
      <v-row class="center">
        <v-col :md="5" :sm="2">
          <v-text-field
            class="first txtField"
            v-model="name"
            label="Meno"
            @mouseout="userCheck"
            clearable
            outlined>
          </v-text-field>
        </v-col>
        <v-col :md="5" :sm="2">
          <v-text-field 
            class="first txtField" 
            v-model="lastName" 
            label="Priezvisko" 
            clearable 
            outlined>
          </v-text-field>
        </v-col>
      </v-row>
      <v-row class="center">
        <v-col :md="10" :sm="5">
          <v-text-field 
            class="txtField"
            v-model="mail" 
            label="Mail" 
            outlined>
          </v-text-field>
        </v-col>
      </v-row>
      <v-row class="center">
        <v-col :md="10" :sm="5">
          <v-text-field
            class="txtField"
            type="password"
            v-model="password"
            label="Heslo"
            outlined
            hint="Uistite sa, že je to najmenej 8 znakov vrátane čísla a velkého písmena.">
            </v-text-field>
        </v-col>
      </v-row>
      <v-row class="center">
        <v-col :md="12" :sm="10">
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
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class Registration extends Vue {
  name: string = "";
  lastName: string = "";
  mail: string = "";
  password: string = "";

  public userCheck() {
    if (!this.name) {
      console.error("error");
    }
  }
}
</script>

<style lang="scss" scoped>
.box {
  border: 2px solid black;
  border-radius: 10px;
  text-align: center;
  width: 500px;
  height: 550px;
}
.btn {
  border-radius: 10px;
  font-family: 'Sulphur Point', serif;
  font-style: normal;
  font-weight: bold;
  font-size: 14px;
  line-height: 28px;
  margin-top: 50px;
}
.center {
  display: flex;
  align-items: center;
  justify-content: center;
}
.first {
  margin-top: 40px;
}
.txtField{
  font-family: 'Sulphur Point', serif;
}
</style>

