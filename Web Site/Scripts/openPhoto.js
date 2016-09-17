ShowPopup = function (photoId) {
    window.open("/File?id=" + photoId, "PopupWindow", 'width=600px,height=400px,top=150,left=250');
}

function displayNextImage() {
    x = (x === images.length - 1) ? 0 : x + 1;
    document.getElementById("img").src = images[x];
}

function displayPreviousImage() {
    x = (x <= 0) ? images.length - 1 : x - 1;
    document.getElementById("img").src = images[x];
}

function startTimer() {
    setInterval(displayNextImage, 6000);
}

var images = [], x = -1;
images[0] = "/Content/Images/cars.jpg";
images[1] = "/Content/Images/pets.jpg";
images[2] = "/Content/Images/excursions.jpg";
