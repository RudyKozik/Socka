import {Module, VuexModule, Action, Mutation, getModule } from 'vuex-module-decorators' 
import store from "@/store/index";
import axios, { AxiosResponse } from 'axios';
import { UserModule } from './UserModule';


export interface IFeedModule {
  feed: any[] 
  comment: any[]
}

export interface ISendFeed {
  statusToSend: string;
  likesToSend: number;
  authorToSend: string;
  dateToSend: string;
}

export interface ISendLike {
  idOfFeed: string;
  like: number;
}

export interface ISendComment {
  author: string;
  id: string;
  content: string;
}

@Module({ dynamic: true, store, name: 'feed' })
class Feed extends VuexModule implements IFeedModule {
  feed: any[] = []
  comment: any[] = []

  @Mutation
  SetFeed(feeds: AxiosResponse){
    let feed = feeds;
    for (let i = 0; i < feed.data.length ; i++) {
      this.feed[i] = feed.data[i];
    }
  }

  @Mutation
  SetComment(comments: AxiosResponse){
    let comment = comments;
    for (let i = 0; i < comment.data.length ; i++) {
      this.comment[i] = comment.data[i];
    }
  }

  @Action({rawError: true})
  async SendFeed(request: ISendFeed): Promise<AxiosResponse>{
    request.likesToSend = 0;
    request.authorToSend = UserModule.user?.user?.email!;
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
    let result = await axios.get("https://localhost:5001/Feed/api/v1/getAll"); 
    return result;
  }

  @Action({rawError: true})
  async GetComments(): Promise<AxiosResponse> {
    let result = await axios.get("https://localhost:5001/Feed/api/v1/getComments");
    return result;
  }

  @Action({rawError: true})
  async SendLike(request: ISendLike): Promise<AxiosResponse>{
    let result = await axios.post("https://localhost:5001/Feed/api/v1/addLike", {
      id: request.idOfFeed,
      like: request.like
    });
    return result;
  }

  @Action({rawError: true})
  async SendComment(request: ISendComment): Promise<AxiosResponse>{
    request.author = UserModule.user?.user?.email!;
    let result = await axios.post("https://localhost:5001/Feed/api/v1/addComment",{
      content: request.content,
      author: request.author,
      feedId: this.feed[0].id
    });
    return result;
  }
}

export const FeedModule = getModule(Feed);