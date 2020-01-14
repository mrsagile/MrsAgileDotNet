$(document).ready(function () {
  //  $("#aboutDetailSectionModal").modal('show');
});

var GetModelId = function (id) {
    return "#aboutDetailSectionModal_" + id;
};

var openAboutDialog = function (id) {
    let Modelid = GetModelId(id);
    $(Modelid).modal('show');
};

var closeAboutDialog = function (id) {
    let Modelid = GetModelId(id);
    $(Modelid).modal('hide');
};
