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
        background: '#F8F8F8',
        secondary: '#FCC701',
        main: '#FF8D01',
      },
    },
  },
  
});
