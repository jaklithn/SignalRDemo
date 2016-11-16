function applyMenuCss() {
	$(".nav li a").each(function () {
		var pageTitle = $("title").text();
		var linkText = $(this).text();
		if (linkText === pageTitle) {
			$(this).closest("li").addClass("active");
		}
	});
}

function displayMessage(name, message) {
    $("#divChat").append("<div><strong>" + name + ":</strong>&nbsp;&nbsp;" + message + "</div>");
}

function displayNotification(message, header, type) {
	if (message) {
		toastr.options.timeOut = 5 * 60 * 1000;
		toastr.options.extendedTimeOut = 60 * 60 * 1000;
		toastr.options.hideDuration = 400;
		toastr.options.escapeHtml = false;
		toastr.options.preventDuplicates = false;
		toastr.options.closeButton = true;
		switch (type.toLowerCase()) {
			case "success":
			    toastr.options.progressBar = true;
			    toastr.options.timeOut = 10 * 1000;
			    toastr.success(message, header);
				break;
			case "warning":
			    toastr.options.progressBar = false;
			    toastr.warning(message, header);
				break;
			case "error":
			    toastr.options.progressBar = false;
			    toastr.error(message, header);
				break;
			default:
			    toastr.options.progressBar = true;
			    toastr.options.timeOut = 20 * 1000;
			    toastr.info(message, header);
				break;
		}
	}
}

function stateToText(state) {
	switch (state) {
		case $.signalR.connectionState.connecting:
			return "Connecting";
		case $.signalR.connectionState.connected:
			return "Connected";
		case $.signalR.connectionState.disconnected:
			return "Disconnected";
		case $.signalR.connectionState.reconnecting:
			return "Reconnecting";
		default:
			return "Unknown";
	}
}

function displayState(newState) {
    var state = stateToText(newState);

    console.debug("WebSocket " + state);

    var divState = $("#divStatus");
    divState.html(state);
    divState.removeClass();
    if (state === "Connected") {
        divState.addClass("bg-success");
    } else {
        divState.addClass("bg-danger");
    }
}

