export default {
  name: 'ff-celebrities',
  data: function () {
    return {
      celebrities: [
        {
          FirstName: 'Vlad',
          LastName: 'Volkovskyi',
          src: require('@assets/images/actorImg.png'),
          CountViews: '1m',
          JobTitle: ['producer', 'actor']
        },
        {
          FirstName: 'Роберт',
          LastName: 'Дауни (младший)',
          src: require('@assets/images/actorImg.png'),
          CountViews: '1000k',
          JobTitle: ['producer', 'actor']
        },
        {
          FirstName: 'Роберт',
          LastName: 'Дауни (младший)',
          src: require('@assets/images/actorImg.png'),
          CountViews: '1000k',
          JobTitle: ['producer', 'actor']
        },
        {
          FirstName: 'Роберт',
          LastName: 'Дауни (младший)',
          src: require('@assets/images/actorImg.png'),
          CountViews: '1000k',
          JobTitle: ['producer', 'actor']
        },
        {
          FirstName: 'Актер',
          LastName: 'Известный',
          src: require('@assets/images/actorImg.png'),
          CountViews: '3.02m',
          JobTitle: ['producer', 'actor', 'writer']
        },
        {
          FirstName: 'Актер',
          LastName: 'Известный',
          src: require('@assets/images/actorImg.png'),
          CountViews: '32000k',
          JobTitle: ['producer', 'actor', 'writer']
        },
        {
          FirstName: 'Актер',
          LastName: 'Известный',
          src: require('@assets/images/actorImg.png'),
          CountViews: '3.5m',
          JobTitle: ['producer', 'actor', 'writer']
        },
        {
          FirstName: 'Актер',
          LastName: 'Известный',
          src: require('@assets/images/actorImg.png'),
          CountViews: '3.5m',
          JobTitle: ['producer', 'actor', 'writer']
        },
        {
          FirstName: 'Актер',
          LastName: 'Известный',
          src: require('@assets/images/actorImg.png'),
          CountViews: '3.5m',
          JobTitle: ['producer', 'actor', 'writer']
        }
      ]
    };
  },
  filters: {
    modifyJobTitles: function (titles) {
      return titles.join(', ');
    }
  }
};
