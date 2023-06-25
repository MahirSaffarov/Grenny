document.addEventListener("DOMContentLoaded", function () {
    var animatedInputs = document.querySelectorAll(".animated-input");

    animatedInputs.forEach(function (input) {
        input.addEventListener("focus", function () {
            this.classList.add("input-focus");
        });
        input.addEventListener("blur", function () {
            this.classList.remove("input-focus");
        });
    });
});

const fileInput = document.getElementById('upload');
const fileLabel = document.querySelector('.file-label');
const fileText = document.querySelector('.file-text');
const gridItems = document.querySelectorAll('.grid-item');

fileInput.addEventListener('change', function () {
    const fileName = this.files[0].name;
    fileText.textContent = fileName;
});

gridItems.forEach(item => {
    item.addEventListener('click', () => {
        item.classList.add('clicked');
        if (!item.classList.contains('background')) {
            item.classList.add('background');
        } else {
            item.classList.remove('background');
        }
        setTimeout(() => {
            item.classList.remove('clicked');
        }, 500);
    });
});

