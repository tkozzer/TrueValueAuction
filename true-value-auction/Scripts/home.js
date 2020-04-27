var alert = document.getElementById('alert');
console.log(alert);
if (document.getElementById('alert') !== null) {
    console.log("alertLiteral not empty");
    setTimeout(() => document.querySelector('.alert').remove(), 5000)
};

function GetItemId(id) {
    console.log(id);
    __doPostBack('bidClick', id);
}

