<template>
  <div class="box">
    <form action method="post">
      <v-row class="center">
        <v-col :md="5" :sm="2">
          <v-text-field 
          class="first txtField" 
          label="Meno" 
          v-model="name" 
          clearable
          outlined>
          </v-text-field>
        </v-col>
        <v-col :md="5" :sm="2">
          <v-text-field
            class="first txtField"
            label="Priezvisko"
            v-model="surname"
            clearable
            outlined
          ></v-text-field>
        </v-col>
      </v-row>
      <v-row class="center">
        <v-col :md="10" :sm="5">
          <v-text-field 
          class="txtField" 
          v-model="email" 
          label="Mail" 
          outlined>
          </v-text-field>
        </v-col>
      </v-row>
      <v-row class="center">
        <v-col :md="10" :sm="5">
          <v-text-field
            class="txtField"
            v-model="password"
            label="Heslo"
            outlined
            type="password"
            hint="Uistite sa, že je to najmenej 8 znakov vrátane čísla a velkého písmena."
          ></v-text-field>
        </v-col>
      </v-row>
      <v-row class="center">
        <v-col :md="12" :sm="10">
          <v-btn
            class="btn"
            height="40px"
            width="200px"
            color="main"
            @click="Register()"
            depressed
          >Registrácia</v-btn>
        </v-col>
      </v-row>
    </form>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";
import firebase from "firebase";
import axios from "axios";
import { RegisterModule, ICreateUserRequest, ISendUser } from "@/store/modules/RegisterModule";

@Component
export default class Registration extends Vue {
  email: string = "";
  password: string = "";
  name: string = "";
  surname: string = "";

  public async Register() {
    let user = await RegisterModule.Register({ email: this.email, password: this.password} as ICreateUserRequest);
    RegisterModule.SetUser(user); 
    if(user){
      let send = await RegisterModule.SendUser({name: this.name, surname: this.surname, email: this.email} as ISendUser);
      if(send){
        this.$router.push({ name: "welcome" });
      }
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
  font-family: "Sulphur Point", serif;
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
.txtField {
  font-family: "Sulphur Point", serif;
}
</style>

