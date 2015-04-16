
/* Set the defaults for DataTables initialisation */
$.extend(true, $.fn.dataTable.defaults, {
    "sDom": "<'row'<'col-xs-6'i><'col-xs-6'f>r>t<'row'<'col-xs-6'><'col-xs-6'p>>",
    "sPaginationType": "bootstrap",
    "oLanguage": {
        "sLengthMenu": "_MENU_ records per page"
    }
});

/* Default class modification */
$.extend($.fn.dataTableExt.oStdClasses, {
    "sWrapper": "dataTables_wrapper form-inline"
});

/* API method to get paging information */
$.fn.dataTableExt.oApi.fnPagingInfo = function (oSettings) {
    return {
        "iStart": oSettings._iDisplayStart,
        "iEnd": oSettings.fnDisplayEnd(),
        "iLength": oSettings._iDisplayLength,
        "iTotal": oSettings.fnRecordsTotal(),
        "iFilteredTotal": oSettings.fnRecordsDisplay(),
        "iPage": oSettings._iDisplayLength === -1 ?
			0 : Math.ceil(oSettings._iDisplayStart / oSettings._iDisplayLength),
        "iTotalPages": oSettings._iDisplayLength === -1 ?
			0 : Math.ceil(oSettings.fnRecordsDisplay() / oSettings._iDisplayLength)
    };
};

/* Bootstrap style pagination control */
$.extend($.fn.dataTableExt.oPagination, {
    "bootstrap": {
        "fnInit": function (oSettings, nPaging, fnDraw) {
            var oLang = oSettings.oLanguage.oPaginate;
            var fnClickHandler = function (e) {
                e.preventDefault();
                if (oSettings.oApi._fnPageChange(oSettings, e.data.action)) {
                    fnDraw(oSettings);
                }
            };

            $(nPaging).append(
				'<ul class="pagination pagination-sm">' +
					'<li class="prev disabled"><a href="#">' + oLang.sPrevious + '</a></li>' +
					'<li class="next disabled"><a href="#">' + oLang.sNext + '</span> </a></li>' +
				'</ul>'
			);
            var els = $('a', nPaging);
            $(els[0]).bind('click.DT', { action: "previous" }, fnClickHandler);
            $(els[1]).bind('click.DT', { action: "next" }, fnClickHandler);
        },

        "fnUpdate": function (oSettings, fnDraw) {
            var iListLength = 5;
            var oPaging = oSettings.oInstance.fnPagingInfo();
            var an = oSettings.aanFeatures.p;
            var i, ien, j, sClass, iStart, iEnd, iHalf = Math.floor(iListLength / 2);

            if (oPaging.iTotalPages < iListLength) {
                iStart = 1;
                iEnd = oPaging.iTotalPages;
            }
            else if (oPaging.iPage <= iHalf) {
                iStart = 1;
                iEnd = iListLength;
            } else if (oPaging.iPage >= (oPaging.iTotalPages - iHalf)) {
                iStart = oPaging.iTotalPages - iListLength + 1;
                iEnd = oPaging.iTotalPages;
            } else {
                iStart = oPaging.iPage - iHalf + 1;
                iEnd = iStart + iListLength - 1;
            }

            for (i = 0, ien = an.length ; i < ien ; i++) {
                // Remove the middle elements
                $('li:gt(0)', an[i]).filter(':not(:last)').remove();

                // Add the new list items and their event handlers
                for (j = iStart ; j <= iEnd ; j++) {
                    sClass = (j == oPaging.iPage + 1) ? 'class="active"' : '';
                    $('<li ' + sClass + '><a href="#">' + j + '</a></li>')
						.insertBefore($('li:last', an[i])[0])
						.bind('click', function (e) {
						    e.preventDefault();
						    oSettings._iDisplayStart = (parseInt($('a', this).text(), 10) - 1) * oPaging.iLength;
						    fnDraw(oSettings);
						});
                }

                // Add / remove disabled classes from the static elements
                if (oPaging.iPage === 0) {
                    $('li:first', an[i]).addClass('disabled');
                } else {
                    $('li:first', an[i]).removeClass('disabled');
                }

                if (oPaging.iPage === oPaging.iTotalPages - 1 || oPaging.iTotalPages === 0) {
                    $('li:last', an[i]).addClass('disabled');
                } else {
                    $('li:last', an[i]).removeClass('disabled');
                }
            }
        }
    }
});

/* Customizations */

var prepareDataTable = function (id, ajaxOptions) {
    var options = {
        "sDom": "<'row'<'col-xs-6'i><'col-xs-6'f>r>t<'row'<'col-xs-6'><'col-xs-6'p>>",
        "sPaginationType": "bootstrap",
        "bLengthChange": false,
        "bAutoWidth": true,
        "bDeferRender": true,
        "bSortClasses": false,
        "bStateSave": true,
        "iCookieDuration": 1800, // 30 min
        "iDisplayLength": 20,
        "oLanguage": {
            "sInfo": "Visar sida _PAGE_ av _PAGES_",
            "sInfoEmpty": "Inga poster tillgängliga",
            "oPaginate": {
                "sNext": "Nästa",
                "sPrevious": "Föregående",
            },
            "sInfoFiltered": "(filtrerad från _MAX_ antal poster)",
            "sZeroRecords": "Sökningen gav inget resultat",
            "sSearch": "Filter"
        }
    };

    if (ajaxOptions !== null && ajaxOptions !== undefined)
        jQuery.extend(options, ajaxOptions);

    var table = $('#' + id).dataTable(options);

    return table;
};

Number.prototype.padLeft = function (n, str) {
    var zeroes = [];
    var length = n;
    while (length--) {
        zeroes[length] = '0';
    }

    return (this < 0 ? '-' : '') +
        (zeroes.join('') + this).slice(-n);

};

var dateFormatISO = function (date) {
    return date.getFullYear() + '-' + (date.getMonth() + 1).padLeft(2, '0') + '-' + date.getDate().padLeft(2, '0');
};



//$('#personinformation').dataTable( {
//    "language": {
//        "lengthMenu": "Visa _MENU_ poster per sida",
//        "zeroRecords": "Sökningen gav inget resultat",
//        "info": "Visar sida _PAGE_ av _PAGES_",
//        "infoEmpty": "Inga poster tillgängliga",
//        "infoFiltered": "(filtrerad från _MAX_ antal poster)",
//        "sSearch": "Filter",
//        "oPaginate": {
//            "sNext": "Nästa",
//            "sPrevious": "Föregående",
//        },
//    }
//});
