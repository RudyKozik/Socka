import Vue from 'vue'
import Vuex from 'vuex'
import { IUserModule } from "./modules/UserModule";
import VuexPersistence from 'vuex-persist'
import Cookies from 'js-cookie'
import { IFeedModule } from './modules/FeedModule';

Vue.use(Vuex);

export interface IRootState {
  user: IUserModule
  feed: IFeedModule
}

const vuexCookie = new VuexPersistence<IRootState>({
  saveState: (key, state) =>
    Cookies.set(key, state, {
      expires: 365
    }),
  restoreState: (key) => Cookies.getJSON(key),
  modules:['User']
})

export default new Vuex.Store<IRootState>({
  plugins: [vuexCookie.plugin]
})

