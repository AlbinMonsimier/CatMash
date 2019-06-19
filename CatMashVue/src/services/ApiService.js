import { getAsync, postAsync } from "../helpers/apiHelper";
const endpoint = "https://catmashapi20190618085606.azurewebsites.net/catMain";
import Axios from 'axios';

Axios.defaults.baseURL = endpoint;

    export async function GetCat() {    
        let response = await getAsync(endpoint);
        console.log(response);
        return response.data
    }

    export async function VoteCat(catid) {
        const response = await postAsync(`${endpoint}/${catid}/vote`, catid);
    }

    export async function GetLeaderBoard() {
        const response = await getAsync(`${endpoint}/leaderboard`);
        return response.data;
    }

    export async function GetCatsJSON() {
        const response = await getAsync(`${endpoint}/catsJSON`);
        return response.data;
    }
