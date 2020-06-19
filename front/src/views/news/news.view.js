export default {
  name: 'ff-news',
  data: function () {
    return {
      newsList: [
        {
          id: 1,
          title: 'Сиквел «Чудо-женщины» перенесли из-за коронавируса',
          content: 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis ea veritati.',
          countViews: 233,
          previewImage: 'https://localhost:5001/StaticFiles/images/News/1.jfif',
          publishTime: '2020-06-18T21:20:30.6683052',
          author: {
            id: 1,
            firstName: 'Мария',
            lastName: 'Колосова'
          },
          categories: [
            {
              id: 1,
              name: 'Variety'
            }
          ]
        }
      ]
    };
  }
};
