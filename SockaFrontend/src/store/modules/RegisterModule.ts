import {Module, VuexModule, Action, Mutation, getModule } from 'vuex-module-decorators' 
import firebase from "firebase";
import axios, { AxiosResponse } from "axios";
import store from "@/store/index";

export interface IUserModule {
  user: firebase.auth.UserCredential | null
}

export interface ICreateUserRequest {
  email: string;
  password: string;
}

export interface ISendUser {
  id: string;
  name: string;
  surname: string;
  email: string;
}

@Module({ dynamic: true, store, name: 'regUser' })
class Register extends VuexModule implements IUserModule {
  user: firebase.auth.UserCredential | null = null;
  
  @Mutation
  SetUser(authUser: firebase.auth.UserCredential){
    this.user = authUser;
  }
  
  @Action({rawError: true})
  async Register( request: ICreateUserRequest): Promise<firebase.auth.UserCredential> {
    let authUser = await firebase.auth().createUserWithEmailAndPassword(request.email, request.password);
    return authUser;
  } 
  
  @Action({rawError: true})
  async SendUser( request: ISendUser): Promise<AxiosResponse>{
    request.id = this.user?.user?.uid!;
  let result = await axios.post("https://localhost:5001/User", {
      id: request.id,
      name: request.name,
      surname: request.surname,
      mail: request.email
    });
    return result;
  }
}

export const RegisterModule = getModule(Register);