$(function () {
    setFocusToFirstField();

    prepareDataTable("personinformation", {
        "iDisplayLength": 12
    });

    // Visa resultattabellen så sent som möjligt för att undvika "flicker" då DataTables-plugin:et lägger på paging, mm
    $("#resultPanel").show();
});

var setFocusToFirstField = function () {
    $("#FirstName").focus();
};

var clearForm = function () {
    $("#FirstName").val("");
    $('#noResults').hide();
    $("#resultPanel").hide();
    setFocusToFirstField();
};

var removePerson = function (id) {
    alert("Ej implementerat än, id=" + id);
}