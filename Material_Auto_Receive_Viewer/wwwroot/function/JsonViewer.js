var jsonObj = {};
var jsonViewer = new JSONViewer();

function ViewerJSON(InputId,OutputId) {
	var Input = document.getElementById(InputId)
	$(document).ready(function () {
		setJSON(Input);
		jsonViewer.showJSON(jsonObj);
		document.querySelector("#" + OutputId).appendChild(jsonViewer.getContainer());
    });
}

function setJSON(Input) {
	if (Input != null) {
		try {
			jsonObj = JSON.parse(Input.value);
		}
		catch (err) {
			console.log(err);
		}
	}
};