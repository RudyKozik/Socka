import {Module, VuexModule, Action, Mutation, getModule } from 'vuex-module-decorators' 
import firebase from "firebase";
import store from "@/store/index";

export interface ILoginUserModule {
    user: firebase.auth.UserCredential | null
}

export interface ILoginUserRequest {
    email: string;
    password: string;
}

@Module({ dynamic: true, store, name: 'loginUser' })
class Login extends VuexModule implements ILoginUserModule {
    user: firebase.auth.UserCredential | null = null;

  @Mutation
  SetUser(authUser: firebase.auth.UserCredential){
    this.user = authUser;
  }
  
  @Action({rawError: true})
  async Login( request: ILoginUserRequest): Promise<firebase.auth.UserCredential> {
    let authUser = await firebase.auth().signInWithEmailAndPassword(request.email, request.password);
    return authUser;
  } 
}

export const LoginModule = getModule(Login);