import Vue from 'vue'
import Router from 'vue-router'
import CatMash from '@/components/CatMash'
import Leaderboard from '@/components/Leaderboard'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'CatMash',
      component: CatMash
    },
    {
      path:'/leaderboard',
      name: 'leaderboard',
      component: Leaderboard
    }
  ]
})
