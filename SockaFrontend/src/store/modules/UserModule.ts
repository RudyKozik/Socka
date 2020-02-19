import {Module, VuexModule, Action, Mutation, getModule } from 'vuex-module-decorators' 
import firebase from "firebase";
import axios, { AxiosResponse } from "axios";
import store, { IRootState } from "@/store/index";
import VuexPersistence from 'vuex-persist';

export interface IUserModule {
  user: firebase.auth.UserCredential | null
}

export interface ICreateUserRequest {
  email: string;
  password: string;
}

export interface ILoginUserRequest {
  email: string;
  password: string;
}

export interface ISendUser {
  id: string;
  name: string;
  surname: string;
  email: string;
}

@Module({ dynamic: true, store, name: 'user' })
class User extends VuexModule implements IUserModule {
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
  async Login( request: ILoginUserRequest): Promise<firebase.auth.UserCredential> {
    let authUser = await firebase.auth().signInWithEmailAndPassword(request.email, request.password);
    let token = firebase.auth().currentUser?.getIdToken(true); 
    return authUser;
  } 
  
  @Action({rawError: true})
  async SendUser( request: ISendUser): Promise<AxiosResponse>{
    request.id = this.user?.user?.uid!;
  let result = await axios.post("https://localhost:5001/User/api/v1/users", {
      id: request.id,
      name: request.name,
      surname: request.surname,
      mail: request.email
    });
    return result;
  }

  @Action({rawError: true})
  async Refresh(): Promise<string> {
    let token = await firebase.auth().currentUser?.getIdToken(true); 
    return token!;
  }
}

export const UserModule = getModule(User);