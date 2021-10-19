function buy(name) {
    debugger;
    // find me the element that matches this conditions (i.e a tbody child element of another element with id='cart')
    let cart = document.querySelector('#cart tbody');
    // appends a row to the tbody element
    let newItem = cart.insertRow();

    let itemName = newItem.insertCell(0);
    itemName.innerHTML = name;

    let elementId = '#' + name.replace(' ', '');
    
    let itemPrice = newItem.insertCell(1);
    itemPrice.innerHTML = document.querySelector(elementId + ' .price').innerHTML;

    let itemQuantity = newItem.insertCell(2);
    itemQuantity.innerHTML = document.querySelector(elementId + ' td .quantity').value;

    document.querySelector(elementId + ' td .quantity').value = '';
}