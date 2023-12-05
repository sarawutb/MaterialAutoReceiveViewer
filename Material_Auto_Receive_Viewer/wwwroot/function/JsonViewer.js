var jsonObj = {};

function ViewerJSON(InputId, OutputId) {
    var jsonViewer = new JSONViewer();
    var Input = document.getElementById(InputId)
    if (Input != null) {
        $(document).ready(function () {
            setJSON(Input);
            jsonViewer.showJSON(jsonObj);
            document.querySelector("#" + OutputId).appendChild(jsonViewer.getContainer());
        });
        console.log(OutputId);
    }
}

function setJSON(Input) {
    try {
        jsonObj = JSON.parse(Input.value);
    }
    catch (err) {
        console.log(err);
    }
};