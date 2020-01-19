import {Module, VuexModule, Action, Mutation, getModule } from 'vuex-module-decorators' 
import store from "@/store/index";
import axios, { AxiosResponse } from 'axios';
import { LoginModule } from './LoginModule';

export interface IFeedModule {
  feed: (string | number)[] 
}

export interface ISendFeed {
  statusToSend: string;
  likesToSend: number;
  authorToSend: string;
  dateToSend: string;
}

export interface ISendLike {
  idOfFeed: number;
  like: number;
}

@Module({ dynamic: true, store, name: 'feed' })
class Feed extends VuexModule implements IFeedModule {
  feed: any[] = []

  @Mutation
  SetFeed(feeds: AxiosResponse){
    let feed = feeds;
    for (let i = 0; i < feed.data.length ; i++) {
      this.feed[i] = feed.data[i];
    }
  }

  @Action({rawError: true})
  async SendFeed(request: ISendFeed): Promise<AxiosResponse>{
    request.likesToSend = 0;
    request.authorToSend = LoginModule.user?.user?.email!;
    let result = await axios.post("https://localhost:5001/Feed/api/v1/create", {
      status: request.statusToSend,
      likes: request.likesToSend,
      author: request.authorToSend,
      date: request.dateToSend
    });
    return result;
  }

  @Action({rawError: true})
  async GetAll(): Promise<AxiosResponse> {
    let result = await axios.get("https://localhost:5001/Feed/api/v1/getAll")
    return result;
  }

  @Action({rawError: true})
  async SendLike(request: ISendLike): Promise<AxiosResponse>{
    this.feed[0].likes = this.feed[0].likes + request.like;
    let result = await axios.post("https://localhost:5001/Feed/api/v1/addLike", {
      id: this.feed[0].id,
      like: this.feed[0].likes
    });
    return result;
  }
}

export const FeedModule = getModule(Feed);