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

var bid = document.getElementById("txtBid");

document.getElementById("btnPlaceBid").addEventListener("click", () => {
    if (bid.value === '') {
        showAlert("Please enter a bid", "alertViewItem", null);
    } else if (!isNumeric(bid.value)) {
        showAlert("Please enter a number for your bid amount", "alertViewItem", null)
    } else {
        __doPostBack("btnPlaceBid", bid.value);
    }
})


function isNumeric(num) {
    return !isNaN(num)
}

function showAlert(message, id, className) {
    if (id === 'alertViewItem') {
        const div = document.createElement('div');
        div.className = 'alert alert-danger';
        div.id = id;
        div.appendChild(document.createTextNode(message));
        const container = document.querySelector('#container1');
        const placeholder = document.querySelector('#placeholder');
        container.insertBefore(div, placeholder);

        //Vanish in 5 seconds
        setTimeout(() => document.querySelector('#alertViewItem').remove(), 5000);
    }
}