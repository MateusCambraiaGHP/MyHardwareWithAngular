const productIndex = function () {
  //constants

  const render = function () {
    $('.header-main').show();
    $('.header-login').hide();

    //$('.js-login-action').click(function () {
    //  let data = $('#login-form').serializeArray().reduce(function (a, x) { a[x.name] = x.value; return a; }, {});
    //  $.ajax({
    //    url: window.location.href + 'Login' + '/ValidatePassword',
    //    type: 'POST',
    //    data: data,
    //    success: function (result) {
    //      window.location.replace('https://localhost:44384/Product');
    //    },
    //    error: function (xhr, status, exception) {
    //      App.showErrors(xhr);
    //    },
    //    complete: function () {
    //    }
    //  });
    //});

  };

  return {
    init: function () {
      render();
    }
  }
}();


const productForm = function () {
  //constants

  const render = function () {
    $('.header-main').show();
    $('.header-login').hide();

    //$('.js-login-action').click(function () {
    //  let data = $('#login-form').serializeArray().reduce(function (a, x) { a[x.name] = x.value; return a; }, {});
    //  $.ajax({
    //    url: window.location.href + 'Login' + '/ValidatePassword',
    //    type: 'POST',
    //    data: data,
    //    success: function (result) {
    //      window.location.replace('https://localhost:44384/Product');
    //    },
    //    error: function (xhr, status, exception) {
    //      App.showErrors(xhr);
    //    },
    //    complete: function () {
    //    }
    //  });
    //});

  };

  return {
    init: function () {
      render();
    }
  }
}();