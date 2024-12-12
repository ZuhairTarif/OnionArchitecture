module.exports = {
  '/api': {
    target: process.env["services__apiservice__http_0"],
    secure: false,
    pathRewrite: {
      '^/api': ""
    }

  }
}
