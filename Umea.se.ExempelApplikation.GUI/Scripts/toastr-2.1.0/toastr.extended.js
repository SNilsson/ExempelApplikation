/*
 * Toastr.extended
 * Metoden för att visa meddelanden på det sätt som vi vill med fadeIn/fadeOut osv
 */
$(function () {
    if (window.$messages === undefined)
        window.$messages = {};

    toastr.options = {
        "closeButton": false,
        "debug": false,
        "positionClass": "toast-top-right",
        "onclick": null,
        "showDuration": "100",
        "hideDuration": "100",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    };

    if (window.$messages.notificationType !== undefined && window.$messages.notificationMessage !== undefined) {
        toastr[window.$messages.notificationType](window.$messages.notificationMessage, window.$messages.notificationTitle);
    }
});