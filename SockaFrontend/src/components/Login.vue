<template>
    <v-app>
      <form action="" method="post">
        <v-row>
          <v-col>
            <v-text-field class="bRad" dense v-model="userName" label="UserName" outlined></v-text-field>
          </v-col>

          <v-col>
            <v-text-field class="bRad" dense type="password" v-model="password" label="Password" outlined></v-text-field>
          </v-col>

           <v-col>
            <v-btn class="btn" height="40px" @click="Send" depressed color="main">Login</v-btn>
          </v-col>
        </v-row>
     </form>
    </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";
import axios from "axios";
import LoginResponse from "@/api/LoginResponse";


@Component
export default class Login extends Vue {
  userName: string = ""
  password: string = ""
  

  public async Send(): Promise<string> {
    let userInfo = await axios.post("https://localhost:5001/User", {
      name: this.userName,
      password: this.password
    });
    return userInfo.data;
  }

  /*public async login(){
    let token = await this.callLogin(this.userName, this.password);
    console.log(token); 
    this.$router.push({ name: "about"});
  }*/

  /*private async callLogin(email: string, password: string): Promise<string>{
    try {
      // let result = await axios.post("https://localhost:5001/WeatherForecast/",{email: email ,password: password});
      // let response = result.data as LoginResponse;
      let result = await axios.get(`https://localhost:5001/WeatherForecast/${email}`);
      return result.data;
    } catch (error) {
      console.log(error);
      return error;
    }
    
  }*/
}
</script>

<style lang="scss" scoped>
.btn{
  width: 150px;
  font-style: normal;
  font-weight: bolder;
  font-size: 14px;
  line-height: 28px;
  border-radius: 10px;
}
.bRad{
  border-radius: 10px;
}
</style>