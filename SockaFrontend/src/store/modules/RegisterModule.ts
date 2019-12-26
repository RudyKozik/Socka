import {Module, VuexModule, Action, Mutation, getModule, MutationAction } from 'vuex-module-decorators' 
import firebase from "firebase";
import axios, { AxiosResponse } from "axios";
import store from "@/store/index";

export interface IUserModule {
  User: firebase.auth.UserCredential | null
}

export interface ICreateUserRequest {
  email: string;
  password: string;
}

export interface ISendUser{
  name: string;
  surname: string;
  email: string;
}

@Module({ dynamic: true, store, name: 'user' })
class User extends VuexModule implements IUserModule {
  User: firebase.auth.UserCredential | null = null;
  
  @Mutation
  SetUser(authUser: firebase.auth.UserCredential){
    this.User = authUser;
  }
  
  @Action({rawError: true})
  async Register( request: ICreateUserRequest): Promise<firebase.auth.UserCredential> {
    let authUser = await firebase.auth().createUserWithEmailAndPassword(request.email, request.password);
    return authUser;
  } 

  @Action({rawError: true})
  async SendUser( request: ISendUser): Promise<AxiosResponse>{
    console.log(request.name);
    console.log(request.surname);
    console.log(request.email);
  let result = await axios.post("https://localhost:5001/User", {
      name: request.name,
      surname: request.surname,
      mail: request.email
    });
    return result;
  }
}

export const RegisterModule = getModule(User);