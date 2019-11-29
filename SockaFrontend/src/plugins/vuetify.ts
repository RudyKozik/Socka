import Vue from 'vue';
import Vuetify from 'vuetify/lib';

Vue.use(Vuetify);

export default new Vuetify({
  icons: {
    iconfont: 'mdi',
  },
  theme: {
    themes: {
      light: {
        primary: '#FF8D01',
        secondary: '#b0bec5',
        main: '#FF8D01',
      },
    },
  },
});
