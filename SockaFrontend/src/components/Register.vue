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
          v-model="lastName"
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
            @click="Register"
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

@Component
export default class Registration extends Vue {
  mail: string = "";
  password: string = "";
  name: string = "";
  lastName: string = "";

  public Register() {
    let user = firebase
      .auth()
      .createUserWithEmailAndPassword(this.mail, this.password)
      .then(
        async data => {
          console.log(data);
          this.$router.push({ name: "home" });
          await axios.post("https://localhost:5001/User", {
            name: this.name,
            lastName: this.lastName,
            mail: this.mail,
            password: this.password
          });
          return data.user;
        },
        err => {
          alert(err.message);
        }
      );
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

