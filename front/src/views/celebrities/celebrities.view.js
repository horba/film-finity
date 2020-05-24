import axios from 'axios';
export default {
  name: 'ff-celebrities',
  data: function () {
    return {
      celebrities: [],
      baseUrl: 'https://localhost:5001'
    };
  },
  filters: {
    modifyJobTitles (titles) {
      return titles.map(element => ' ' + element.jobName).join();
    }
  },
  methods: {
    getimgSrc (imgPath) {
      const context = this;
      return `${context.baseUrl}/${imgPath}`;
    }
  },
  created () {
    axios
      .get(`${this.baseUrl}/api/Celebrity/Celebrities`)
      .then(response => { this.celebrities = response.data; });
  }
};
