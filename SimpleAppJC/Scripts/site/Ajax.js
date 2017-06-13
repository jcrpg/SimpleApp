//Send request to web service
var sendRequest = function (url, verb, data, successCallback, errorCallback, options) {

    var requestOptions = options || {};
    requestOptions.type = verb;
    requestOptions.success = successCallback;
    requestOptions.error = errorCallback;

    if (!url || !verb) {
        errorCallback(401, "Missing URL and HTTP verb");
    }
    if (data) {
        requestOptions.data = data;
    }
    $.ajax(url, requestOptions);
}

//Registering success & error call backs
var setDefaultCallbacks = function (successCallback, errorCallback) {

    $.ajaxSetup({
        complete: function(jqXHR, status) {
            if (jqXHR.status >= 200 && jqXHR.status < 300) {
                successCallback(jqXHR.responseJSON);
            } else {
                errorCallback(jqXHR.status, jqXHR.statusText);
            }
        }
    });
}

//header for all subsequent Ajax call
var setAjaxHeaders = function (requestHeaders) {

    $.ajaxSetup({ headers: requestHeaders });
}