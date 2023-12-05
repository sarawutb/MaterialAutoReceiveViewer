function CreateDataTable(ElementId) {
  console.log("CreateDataTable");
  $(document).ready(function () {
    try {
      new DataTable("#" + ElementId, {
        responsive: true,
      });
    } catch {
      console.log("Create DataTable Error! : element : " + ElementId);
    }
  });
}

function copyToClipboard(elementId) {
  var text = document.getElementById(elementId).value;
  var tempInput = document.createElement("input");
  tempInput.value = text;
  document.body.appendChild(tempInput);
  tempInput.select();
  tempInput.setSelectionRange(0, 99999);
  document.execCommand("copy");
  document.body.removeChild(tempInput);
  ToastMsg("Copy Clipboard!");
}

function ToastMsg(Msg) {
  Toastify({
    text: Msg,
    className: "info",
    style: {
      background: "linear-gradient(to right, #E91E63, #f96868)",
    },
  }).showToast();
}
