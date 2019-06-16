// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("document").ready(function() {
    var uri = window.location.pathname;

   var uriParameter = uri.split('/')[1];
   
    switch (uriParameter) {

        case  "about" :
            $('#about-link').addClass('active');
            break;

        case  "books" :
            $('#books-link').addClass('active');
            break;


        case  "partners" :
            $('#partners-link').addClass('active');
            break;
        
        case  "blog" :
            $('#blog-link').addClass('active');
            break;
    }
});