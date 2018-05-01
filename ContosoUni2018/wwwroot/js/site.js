$(function () {
    //wait for DOM (document   )to be loaded(ready function)

    //DataTables
    $("#tablesorted").DataTable({//as soon as you add .DataTable it hooks up the table
        "columnDefs": [//columns definitions
            {"orderable": false, "targets": -1 },//stop sorting on the last column
        ],          // the numbers are for the dropdown options in the background
        "lengthMenu":[ [5,10,25,50,-1], [5,10,25,50,"ALL"] ]//drop down for how many entries the user sees
    });
});