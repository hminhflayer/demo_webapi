const uri = 'RandomCat';
let todos = [];

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

function _displayItems(data) {
    var image = document.getElementById('image');

    data.forEach(item => {
        image.setAttribute("src", item.url);
        image.setAttribute("width", item.width);
        image.setAttribute("height", item.height);
    }
}