//$(document).ready(function () {

//    //Set Globalize to the current culture
//    var currentCulture = $("meta[name='accept-language']").prop("content");
//    if (currentCulture) {
//        Globalize.culture(currentCulture);
//    }
//});

var prepareDatepickers = function () {
    var languageCode = $("meta[name='accept-language']").prop("content").split("-")[0];

    // We currently support Swedish and English with sv as default language
    if (languageCode !== 'sv' && languageCode !== 'en')
        languageCode = 'sv';

    $('.date-picker').datepicker({
        language: languageCode,
        format: 'yyyy-mm-dd',
        weekStart: 1,
        autoclose: true,
        todayHighlight: true,
        todayBtn: true
    });
};

var prepareSelectpickers = function () {

    $('.selectpicker').selectpicker({
        noneSelectedText: 'Välj...',
        noneResultsText: 'Inget matchar sökningen',
        countSelectedText: function(numSelected, numTotal) {
            return (numSelected == 1) ? "{0} objekt valt" : "{0} objekt valda";
        },
        maxOptionsText: function(numAll, numGroup) {
            var arr = [];

            arr[0] = (numAll == 1) ? 'Limit reached ({n} item max)' : 'Limit reached ({n} items max)';
            arr[1] = (numGroup == 1) ? 'Group limit reached ({n} item max)' : 'Group limit reached ({n} items max)';

            return arr;
        },
        selectAllText: 'Markera alla',
        deselectAllText: 'Avmarkera alla',
        multipleSeparator: ', '
    });
};