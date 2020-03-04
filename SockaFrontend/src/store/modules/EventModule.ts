import {Module, VuexModule, Action, Mutation, getModule } from 'vuex-module-decorators' 
import store from "@/store/index";
import axios, { AxiosResponse } from 'axios';


export interface IEventModule {
  event: string;
  team: string[];
}

export interface ISendEventRequest {
  name: string;
  organizer: string;
  location: string;
  startDate: string;
  endDate: string;
  url: string;
}


@Module({ dynamic: true, store, name: 'event' })
class Event extends VuexModule implements IEventModule {
  event: string = ""
  team: string[] = []

  @Mutation
  SetTeam(teams: AxiosResponse){
    let result = teams;
    for (let i = 0; i < result.data.length ; i++) {
      this.team[i] = result.data[i];
      console.log(this.team[i]);
    }
  }

  @Action({rawError: true})
  async SendEvent(request: ISendEventRequest): Promise<AxiosResponse>{
    let result = await axios.post("https://localhost:5001/Event/api/v1/addEvent", {
      name: request.name,
      organizer: request.organizer,
      location: request.location,
      startDate: request.startDate,
      endDate: request.endDate,
      url: request.url
    });
    return result;
  }

  @Action({rawError: true})
  async GetAll(): Promise<AxiosResponse> {
    let result = await axios.get("https://localhost:5001/Event/api/v1/GetTeam"); 
    return result;
  }
}

export const EventModule = getModule(Event);