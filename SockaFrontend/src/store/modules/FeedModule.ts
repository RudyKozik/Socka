import {Module, VuexModule, Action, Mutation, getModule } from 'vuex-module-decorators' 
import store from "@/store/index";
import axios, { AxiosResponse } from 'axios';
import { LoginModule } from './LoginModule';

export interface IFeedModule {
  feed: AxiosResponse | null
}

export interface ISendFeed {
  status: string;
  likes: number;
  author: string;
  date: string;
}

@Module({ dynamic: true, store, name: 'feed' })
class Feed extends VuexModule implements IFeedModule {
  feed: AxiosResponse | null = null;

  @Mutation
  SetFeed(feed: AxiosResponse){
    this.feed = feed;
  }

  @Action({rawError: true})
  async SendFeed(request: ISendFeed): Promise<AxiosResponse>{
    request.likes = 0;
    request.author = LoginModule.user?.user?.email!;
    console.log(request.author);
    let result = await axios.post("https://localhost:5001/Feed", {
      status: request.status,
      likes: request.likes,
      author: request.author,
      date: request.date
    });
    return result;
  }
}

export const FeedModule = getModule(Feed);