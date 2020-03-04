<template>
  <v-card
  class="feed"
  light
  width="700">
    <v-card-text 
    class="headline font-weight-bold">
      {{feed.status}}
    </v-card-text>
    <v-divider></v-divider>
    <v-card-actions>
      <v-card-text>
        {{feed.author}}
      </v-card-text>
      <v-card-text>
        {{feed.date}}
      </v-card-text>
      <v-btn 
      icon
      @click="SendLike()">
        <v-icon>mdi-heart</v-icon>
      </v-btn>
      <span>
        {{feed.likes}}
      </span>
      <v-menu offset-y>
        <template v-slot:activator="{ on }">
          <v-btn
          v-on="on"
          icon>
            <v-icon>mdi-dots-horizontal</v-icon>
          </v-btn>
        </template>
        <v-list>
          <v-list-item>
            <v-list-item-title>
              <v-row>
                <v-col>
                  <v-btn
                  class="btn" 
                  color="transparent"
                  @click="Delete()"
                  depressed>
                  <v-icon>mdi-delete</v-icon>
                  </v-btn>
                </v-col>
              </v-row>                 
            </v-list-item-title>
          </v-list-item>
        </v-list>
      </v-menu>
    </v-card-actions>
    <v-divider></v-divider>
    <v-card-text>
      <div class="addComment">
        <v-row>
          <v-col :md="9">
            <v-text-field
            class="txtField" 
            dense 
            color="main"
            v-model="content" 
            label="Napíš komentár..." 
            outlined>
            </v-text-field>
          </v-col>
          <v-col :md="3" >
            <v-btn
            height="40px"
            width="120px"
            depressed
            outlined
            color="main"
            @click="AddComment"
            class="btn">
              Poslať
            </v-btn>
          </v-col>
        </v-row>
      </div>
      <Comments :filteredComments="filteredComments" />
    </v-card-text>
  </v-card>
</template>

<script lang="ts">
import Vue from 'vue'
import Component from 'vue-class-component';
import { FeedModule, ISendLike, ISendComment  } from '@/store/modules/FeedModule';
import Comments from "@/components/Comment/Comments.vue"
import axios from 'axios';

@Component({
  components:{
    Comments
  },
  props:["feed","filteredComments"] 
})
export default class Feed extends Vue{
  id: string = "";
  like: number = 1;
  content: string = "";

  public async Delete(){
    let result = await axios.delete("https://localhost:5001/Feed/api/v1/delete", {data: {id: this.id}});
  }

  public async SendLike(){
    this.id = this.$props.feed.id;
    let result = await FeedModule.SendLike({idOfFeed: this.id, like: this.like } as ISendLike);
  }

  public async AddComment(){
    this.id = this.$props.feed.id;
    let comment = await FeedModule.SendComment({id: this.id,content: this.content, } as ISendComment);
  }
}

</script>

<style scoped>
.feed{
  margin-bottom: 25px;
}
.btn {
  border-radius: 10px;
  font-family: "Sulphur Point", serif;
  font-style: normal;
  font-weight: bold;
  font-size: 14px;
  line-height: 28px;
}
.txtField{
  font-family: 'Sulphur Point', serif;
  border-radius: 10px;
}
</style>