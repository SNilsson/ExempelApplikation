
var countryChanged = function () {
    var countryId = $("#CountryVal").val();
    if (countryId > 0) {
        var urlParams = "?countryId=" + countryId;
        var url = '/Hemort/GetHomes' + urlParams;
    } else {
        url = '/Hemort/GetAllHomes';
    }

    $.ajax({
            type: 'POST',
            url: url,
            success: function(result) {
                $("#hemortPanel").html(result);
            },
            error: function(xhr) {
            }
        });
};

