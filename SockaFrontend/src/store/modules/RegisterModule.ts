import {Module, VuexModule, Action, Mutation, getModule, MutationAction } from 'vuex-module-decorators' 
import firebase from "firebase";
import Vue from "vue";
import store from "@/store/index";

export interface IUserModule {
  User: firebase.auth.UserCredential | null
}

export interface ICreateUserRequest {
  email: string;
  password: string;
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
}

export const RegisterModule = getModule(User);