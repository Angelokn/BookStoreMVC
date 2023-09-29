var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/user/getall' },
        "columns": [
            { data: 'name', "width": "15%" },
            { data: 'email', "width": "15%" },
            { data: 'phoneNumber', "width": "15%" },
            { data: 'company.name', "width": "15%" },
            { data: 'role', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="p-1 w-70 btn-group" role="group">
                                <a href="/admin/company/upsert?id=${data}" class="btn btn-primary mx-2 rounded">
                                    <i class="bi bi-pencil-square"></i> Update
                                </a>
                            </div>`
                }, 
                "width": "25%"
            }
        ]
    });
}