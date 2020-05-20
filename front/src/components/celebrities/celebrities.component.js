export default {
  name: 'ff-celebrities',
  data: function () {
    return {
      celebrities: [
        {
          FirstName: 'Vlad',
          LastName: 'Volkovskyi',
          src: require('@components/celebrities/actorImg.png'),
          CountViews: '1m',
          JobTitle: ['producer', 'actor']
        },
        {
          FirstName: 'Роберт',
          LastName: 'Дауни (младший)',
          src: require('@components/celebrities/actorImg.png'),
          CountViews: '1000k',
          JobTitle: ['producer', 'actor']
        },
        {
          FirstName: 'Роберт',
          LastName: 'Дауни (младший)',
          src: require('@components/celebrities/actorImg.png'),
          CountViews: '1000k',
          JobTitle: ['producer', 'actor']
        },
        {
          FirstName: 'Роберт',
          LastName: 'Дауни (младший)',
          src: require('@components/celebrities/actorImg.png'),
          CountViews: '1000k',
          JobTitle: ['producer', 'actor']
        },
        {
          FirstName: 'Актер',
          LastName: 'Известный',
          src: require('@components/celebrities/actorImg.png'),
          CountViews: '3.02m',
          JobTitle: ['producer', 'actor', 'writer']
        },
        {
          FirstName: 'Актер',
          LastName: 'Известный',
          src: require('@components/celebrities/actorImg.png'),
          CountViews: '3.5m',
          JobTitle: ['producer', 'actor', 'writer']
        },
        {
          FirstName: 'Актер',
          LastName: 'Известный',
          src: require('@components/celebrities/actorImg.png'),
          CountViews: '3.5m',
          JobTitle: ['producer', 'actor', 'writer']
        },
        {
          FirstName: 'Актер',
          LastName: 'Известный',
          src: require('@components/celebrities/actorImg.png'),
          CountViews: '3.5m',
          JobTitle: ['producer', 'actor', 'writer']
        },
        {
          FirstName: 'Актер',
          LastName: 'Известный',
          src: require('@components/celebrities/actorImg.png'),
          CountViews: '3.5m',
          JobTitle: ['producer', 'actor', 'writer']
        }
      ]
    };
  },
  methods: {
    modifyElements () {
      this.celebrities.forEach(elem => { elem.JobTitle = elem.JobTitle.join(', '); });
    }
  },
  created () {
    this.modifyElements();
    const rowsCount = Math.floor(this.celebrities.length / 4), row4Columns = [];
    for (let spliceCount = 0; spliceCount < rowsCount; spliceCount++) {
      row4Columns.push(this.celebrities.splice(0, 4));
    }
    if (this.celebrities.length) {
      row4Columns.push(this.celebrities);
    }
    this.celebrities = row4Columns.sort(
      function (fstArr, secArr) {
        return secArr.length - fstArr.length;
      }
    );
  }
};
