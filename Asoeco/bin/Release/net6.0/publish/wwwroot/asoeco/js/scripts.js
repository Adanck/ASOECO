

window.addEventListener('DOMContentLoaded', event => {

    //// Navbar shrink function
    //var navbarShrink = function () {
    //    const navbarCollapsible = document.body.querySelector('#mainNav');
    //    if (!navbarCollapsible) {
    //        return;
    //    }
    //    if (window.scrollY === 0) {
    //        navbarCollapsible.classList.remove('navbar-shrink')
    //    } else {
    //        navbarCollapsible.classList.add('navbar-shrink')
    //    }

    //};

    //// Shrink the navbar 
    //navbarShrink();

    //// Shrink the navbar when page is scrolled
    //document.addEventListener('scroll', navbarShrink);

    //// Activate Bootstrap scrollspy on the main nav element
    //const mainNav = document.body.querySelector('#mainNav');
    //if (mainNav) {
    //    new bootstrap.ScrollSpy(document.body, {
    //        target: '#mainNav',
    //        offset: 72,
    //    });
    //};

    //// Collapse responsive navbar when toggler is visible
    //const navbarToggler = document.body.querySelector('.navbar-toggler');
    //const responsiveNavItems = [].slice.call(
    //    document.querySelectorAll('#navbarResponsive .nav-link')
    //);
    //responsiveNavItems.map(function (responsiveNavItem) {
    //    responsiveNavItem.addEventListener('click', () => {
    //        if (window.getComputedStyle(navbarToggler).display !== 'none') {
    //            navbarToggler.click();
    //        }
    //    });
    //});

    pasasrImagenes();
});


let identificadorIntervaloDeTiempo;
let contador = 0;

function pasasrImagenes() {
    debugger
    identificadorIntervaloDeTiempo = setInterval(pasador, 1000);
}

function pasador() {
    debugger;
    let socios = document.querySelectorAll('[name="filterImg"]');
    debugger
    socios = Array.from(socios);
    contador = socios.length;
    debugger
    socios[contador].click();
    contador++;
    if (contador > socios.length) {
        contador = 0;     
    }
}