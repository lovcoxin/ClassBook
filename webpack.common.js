const path = require('path');

module.exports = {
  entry: {
    app: './scripts/app.scripts',
  },
  output: {
    path: path.resolve(__dirname, 'dist'),
    clean: true,
    filename: './scripts/app.scripts',
  },
};
