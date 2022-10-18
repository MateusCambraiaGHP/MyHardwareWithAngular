const loginForm = function () {
  //constants

  const render = function () {
    $('.header-main').hide();
    $('.header-login').show();
    $('.alert-danger').hide();

    $('.js-login-action').click(function () {
      let data =  $('#login-form').serializeArray().reduce(function (a, x) { a[x.name] = x.value; return a; }, {});
      $.ajax({
        url: window.location.href + 'Login' + '/ValidatePassword',
        type: 'POST',
        data: data,
        success: function (result) {
            window.location.replace('https://localhost:44384/Supplier');
        },
        error: function (xhr, status, exception) {
          App.showErrors(xhr);
        },
        complete: function () {
        }
      });
    });

    $('.js-register-action').click(function (e) {
      e.preventDefault();
      let data;
      $.ajax({
        url: window.location.href + 'Login' + '/GetRegisterDialog',
        type: 'GET',
        data: data,
        success: function (result) {
          console.log(result);
          $(result).appendTo('body').modal('show');
          $('#myModal').on('shown.bs.modal', function () {
            $('#myInput').trigger('focus')
          });
        },
        error: function (xhr, status, exception) {
        },
        complete: function () {
        }
      });
    });

  };

  return {
    init: function () {
      render();
    }
  }
}();