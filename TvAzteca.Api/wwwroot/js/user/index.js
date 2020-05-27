$(function () {

    const columns = [
        {
            title: "Nombre",
            data: "name"
        },
        {
            title: "Apellido",
            data: "lastname",
        },

        {
            title: "Cumpleaños",
            data: "birthday",
        }
    ];

    const url = "/Api/Usuarios/";
    const method = "GET";

    const table = $('table').DataTable({
        dom: "rtip",
        ajax: {
            method: method,
            url: url
        },
        columns: columns,
        language: { url: "/lib/datatables/js/Spanish.json" }

    });


});