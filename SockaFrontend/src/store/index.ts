import Vue from 'vue'
import Vuex, { Payload } from 'vuex'
import { IUserModule } from "./modules/RegisterModule";
import VuexPersistence from 'vuex-persist'
import Cookies from 'js-cookie'
import { ILoginUserModule } from './modules/LoginModule';
import { IFeedModule } from './modules/FeedModule';

Vue.use(Vuex);

export interface IRootState {
  regUser: IUserModule
  logUser: ILoginUserModule
  feed: IFeedModule
}

const vuexCookie = new VuexPersistence<IRootState>({
  saveState: (key, state) =>
    Cookies.set(key, state, {
      expires: 365
    }),
  restoreState: (key) => Cookies.getJSON(key),
  modules:['loginUser']
})

export default new Vuex.Store<IRootState>({
  plugins: [vuexCookie.plugin]
})

