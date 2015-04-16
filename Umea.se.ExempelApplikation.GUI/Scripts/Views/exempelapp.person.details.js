$(function () {
    prepareSelectpickers();
    prepareDatepickers();

    var data = $("#course-default").val();
    if (data != null && data.length > 0) {
        var dataarray = data.split(",");
        $('.selectpickercourse').val(dataarray);
        $('.selectpickercourse').selectpicker('render');
    }

    hideShowFromDiskriminator();
    if (window.scriptResources.EditMode != "true") {
        $("select").prop('disabled', true);
        $(".date-picker").prop('disabled', true);
        $('input[type=hidden]').prop('disabled', false);
    } 
});


function ValidateForm() {
    var ok = true;
    var modelError = $("#PersonError");
    modelError.addClass('hidden');
    if (!$("#detailsform").valid()) {
        modelError.removeClass('hidden');
        event.preventDefault();
        ok = false;
    }
    return ok;
};

var hideShowFromDiskriminator = function () {
    var modelError = $("#PersonError");
    var val = $("#DiscriminatorVal").val();
    var editMode = $("#EditMode").val();
    modelError.addClass('hidden');
    $("#DivInstructor").removeClass("input-validation-error");
    var divInstructor = $(".instructor");
    divInstructor.addClass("hidden");

    if ((val == null || val == "0") && editMode) {
        modelError.removeClass('hidden');
        $("#DivInstructor").addClass("input-validation-error");
    }
    if (val == "2") {
        divInstructor.removeClass("hidden");
    }
    else{
        divInstructor.addClass("hidden");
    }
}


