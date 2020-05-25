import axios from 'axios';
export default {
  name: 'ff-celebrities',
  data: function () {
    return {
      celebrities: [],
      baseUrl: 'https://localhost:5001',
      fit: 'cover'
    };
  },
  filters: {
    modifyJobTitles (titles) {
      return titles.map(element => ' ' + element.jobName).join();
    }
  },
  methods: {
    getimgSrc (imgPath) {
      return `${this.baseUrl}/${imgPath}`;
    }
  },
  created () {
    axios
      .get(`${this.baseUrl}/api/Celebrity/Celebrities`)
      .then(response => { this.celebrities = response.data; });
  }
};
