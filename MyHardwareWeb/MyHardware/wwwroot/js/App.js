const App = function () {
  //constants

  const render = function () {


  };
  
  const showErrors = function (xhr) {
    let errors = xhr.responseJSON.errors;
    $.each(errors, (key, value) => {
      if ($(`#${key}`).length) {
        let $el = $(`#${key}`);
        let parent = $el.parent();
        let htmlParent = parent.html();
        htmlParent += `<small class="text-danger">${value[0]}</small>`
        parent.html(htmlParent);
        console.log($el);
        $(`#${key}`).addClass('is-invalid');
      }
    });
  }

  return {
    init: function () {
      render();
    },
    showErrors: function (xhr) {
      showErrors(xhr);
    }
  }
}();
