import axios from 'axios';

export async function postAsync(url, data, ) {
  return axios.post(url, data)
      .then((response) => {
        return response
      })
      .catch((error) => {
        throw error
      })
}

export async function putAsync(url, data) {
  return axios.put(url, data)
      .then((response) => {
        return response
      })
      .catch((error) => {
        throw error
      })
}

export async function getAsync(url) {
  return axios.get(url)
      .then((response) => {
        return response
      })
      .catch((error) => {
        throw error
      })
}

export async function deleteAsync(url) {
  return axios.delete(url)
      .then((response) => {
        return response
      })
      .catch((error) => {
        throw error
      })
}
