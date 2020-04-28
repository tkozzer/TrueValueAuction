function GetItemId(id) {
    console.log(id);
    __doPostBack('btnDeleteItem', id);
}

var alert = document.getElementById('alert');
if (alert !== null) {
    console.log("alertLiteral not empty");
    setTimeout(() => document.querySelector('#alert').remove(), 5000)
};