console.log("shjd")

document.addEventListener("DOMContentLoaded", function () {
    var productDetails = document.querySelector(".product-details");
    var detailItems = document.querySelectorAll(".detail-item");
    var productImages = document.querySelectorAll(".product-image img");
    var h1 = document.querySelector("h1");
    var pageTitle = document.querySelector("title");
    var colorChangeInterval;

    productDetails.classList.add("show");

    detailItems.forEach(function (item, index) {
        setTimeout(function () {
            item.classList.add("show");
        }, index * 200);
    });

    productImages.forEach(function (image) {
        image.addEventListener("mouseover", function () {
            this.style.transform = "scale(1.1)";
        });
        image.addEventListener("mouseout", function () {
            this.style.transform = "scale(1)";
        });
    });

    h1.classList.add("fade-in");

    startColorChangeAnimation();

    function startColorChangeAnimation() {
        colorChangeInterval = setInterval(changePageTitleColor, 500);
    }

    function stopColorChangeAnimation() {
        clearInterval(colorChangeInterval);
    }

    function changePageTitleColor() {
        var randomColor = getRandomColor();
        pageTitle.style.color = randomColor;
    }

    function getRandomColor() {
        var letters = "0123456789ABCDEF";
        var color = "#";
        for (var i = 0; i < 6; i++) {
            color += letters[Math.floor(Math.random() * 16)];
        }
        return color;
    }
    window.addEventListener("beforeunload", function () {
        stopColorChangeAnimation();
    });
});