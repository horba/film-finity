import store from '@store';

export default function imageServerPath (imgPath) {
  return store.state.baseUrl + '/' + imgPath;
};
