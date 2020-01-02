<template>
  <div class="form">
    <form action="" method="post">
        <v-row>
          <v-col>
            <v-text-field 
              class="txtField" 
              dense 
              v-model="email" 
              label="email" 
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
import firebase from "firebase"
import { LoginModule, ILoginUserRequest } from "@/store/modules/LoginModule";

@Component
export default class Login extends Vue {
  email: string = "";
  password: string = "";

  public async Login() {

    let login = await LoginModule.Login({ email: this.email, password: this.password} as ILoginUserRequest);
    LoginModule.SetUser(login); 
    if(login){
      this.$router.push({ name: "home" });
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