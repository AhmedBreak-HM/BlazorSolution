// var toastr;
ShowToastr = (type, message) => {
    window.confirm(' are you sure');
    if (type === 'success') {
        toastr.success(message, 'HotelApp', { timeout: 2000 });
    }
    if (type === 'error') {
        toastr.error(message, 'HotelApp', { timeout: 2000 });
    }
}
function displayToastr(type, mesg) {
    switch (type) {
        case "success":
            toastr.success(mesg, "Blazor WASM");
            break;
        case "info":
            toastr.info(mesg, "Blazor WASM");
            break;
        case "warning":
            toastr.warning(mesg, "Blazor WASM");
            break;
        case "error":
            toastr.error(mesg, "Blazor WASM");
            break;
        default:
            toastr.info(mesg, "Blazor WASM");
            break;
    }
}
