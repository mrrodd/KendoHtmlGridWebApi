$(function () {
    $("#Grid").kendoGrid({
        dataSource: {
            type: "aspnetmvc-ajax",              // Required for the Filters, Groups and Sorts to work with HTML/JS Grid
            transport: {
                read: {
                    url: "/api/customer",
                    type: "GET"
                }
            },
            schema: {
                data: "Data",                   // service returns data in this format... {"Data":[{"CustomerId":12,"FirstName":"Roberto","LastName":"Almeida","Company":"Riotur","Address":"Praça Pio X, 119","City":"Rio de Janeiro","State":"RJ","Country":null,"PostalCode":"20040-020","Phone":"+55 (21) 2271-7000","Fax":null,"Email":"roberto.almeida@riotur.gov.br","SupportRepId":0}...
                total: "Total",
                model: {
                    id: "CustomerId",
                    fields: {
                        FirstName: { type: "string" },
                        LastName: { type: "string" },
                        Address: { type: "string" },
                        City: { type: "string" },
                        State: { type: "string" }
                    }
                }
            },
            sort: [{ field: "LastName", dir: "asc" }],
            pageSize: 10,
            serverPaging: true,
            serverFiltering: true,
            serverSorting: true
        },
        columns: [
            { field: "FirstName", title: "First Name", filterable: true },
            { field: "LastName", title: "Last Name", filterable: true },
            { field: "Address", filterable: true },
            { field: "City", filterable: true },
            { field: "State", filterable: false }
        ],
        pageable: true,
        sortable: true,
        filterable: true
    });
});
