export default {
  name: 'ff-news',
  data: function () {
    return {
      newsList: [
        {
          id: 1,
          title: 'Сиквел «Чудо-женщины» перенесли из-за коронавируса',
          content: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis ea veritat'
          + 'asasaasdasdadaisajs djams alsas dsad a dad adasasd asd adsada sadasd asdas dasd ad'
          + 'asasaasdasdadaisajs djams alsas dsad a dad adasasd asd adsada sadasd asdas vlad ad',
          countViews: 233,
          previewImage: 'https://localhost:5001/StaticFiles/images/News/1.jfif',
          publishTime: '18.06.2020 20:30',
          countCommentaries: 5,
          author: {
            id: 1,
            firstName: 'Мария',
            lastName: 'Колосова'
          },
          categories: [
            {
              id: 1,
              name: 'Variety'
            },
            {
              id: 2,
              name: 'Film News'
            }
          ]
        }
      ]
    };
  },
  filters: {
    modifyCategories (categories) {
      return categories.map(element => ' ' + element.name).join();
    }
  }
};
