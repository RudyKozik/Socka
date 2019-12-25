<template>
  <div class="form">
    <form action="" method="post">
        <v-row>
          <v-col>
            <v-text-field 
              class="txtField" 
              dense 
              v-model="mail" 
              label="mail" 
              outlined>
            </v-text-field>
          </v-col>
          <v-col>
            <v-text-field 
              class="txtField" 
              dense 
              type="password" 
              v-model="password" 
              label="Password" 
              outlined>
            </v-text-field>
          </v-col>
          <v-col>
            <v-btn 
              class="btn" 
              height="40px" 
              width= "200px"
              @click="Login" 
              depressed 
              color="main">
                Prihlásiť sa
            </v-btn>
          </v-col>
        </v-row>
    </form>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";
import axios from "axios";
import LoginResponse from "@/api/LoginResponse";
import firebase from "firebase"


@Component
export default class Login extends Vue {
  mail: string = "";
  password: string = "";

  public async Login() {

    var login = await firebase.auth().signInWithEmailAndPassword(this.mail, this.password);
    if (login) {
      this.$router.push({name: "home" });
    }
  }
}
</script>

<style lang="scss" scoped>
.btn{
  font-family: 'Sulphur Point', serif;
  font-style: normal;
  font-weight: bold;
  font-size: 16px;
  line-height: 28px;
  border-radius: 10px;
}
.txtField{
  font-family: 'Sulphur Point', serif;
  border-radius: 10px;
}
</style>