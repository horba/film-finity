const path = require('path');

module.exports = {
  chainWebpack: config => {
    config.resolve.alias
      .set('@components', path.resolve('src/components/'))
      .set('@layouts', path.resolve('src/layouts/'))
      .set('@views', path.resolve('src/views/'))
      .set('@router', path.resolve('src/router/'))
      .set('@store', path.resolve('src/store/'))
      .set('@filters', path.resolve('src/filters/'))
      .set('@styles', path.resolve('src/styles/'))
      .set('@assets', path.resolve('src/assets/'));
  }
};
