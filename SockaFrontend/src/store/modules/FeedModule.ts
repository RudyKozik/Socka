import {Module, VuexModule, Action, Mutation, getModule } from 'vuex-module-decorators' 
import store from "@/store/index";

export interface IFeedModule {
  feed: string
}

@Module({ dynamic: true, store, name: 'feed' })
class Feed extends VuexModule implements IFeedModule {
  feed: string = "";

  @Mutation
  SetFeed(feed: string){
    this.feed = feed;
    console.log(this.feed);
  }
  

}

export const FeedModule = getModule(Feed);