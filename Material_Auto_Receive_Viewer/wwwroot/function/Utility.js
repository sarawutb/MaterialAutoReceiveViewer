function CreateDataTable(ElementId) {
    console.log("CreateDataTable");
    $(document).ready(function () {
        try {
            new DataTable('#' + ElementId, {
                responsive: true
            });
        } catch {
            console.log("Create DataTable Error! : element : " + ElementId);
        }
    });
}