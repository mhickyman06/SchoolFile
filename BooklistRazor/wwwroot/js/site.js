// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
document.querySelectorAll(".topstrip")
$(document).ready(function () {
    var imageFile = ["img1.jpg", "img2.jpg", "img3.jpg", "img4.jpg", "img5.jpg", "img6.jpg", "img7.jpg", "img8.jpg"];
    var currentIndex = 0;
    setInterval(function () {
        if (currentIndex == imageFile.length) {
            currentIndex = 0;
        }
        $(".topstrip").fadeOut(10).css('background-image', 'url("./Img/'+imageFile[currentIndex++]+'")').fadeIn(10);
    }, 5000);
});