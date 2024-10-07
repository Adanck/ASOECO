

window.addEventListener('DOMContentLoaded', event => {

    pasasrImagenes();
});


let contador = 0;

function pasasrImagenes() {
    setInterval(pasador, 6000);
}

function pasador() {
    let socios = document.querySelectorAll('[name="filterImg"]');
    socios = Array.from(socios);
    socios[contador].click();
    contador++;
    if (contador >= socios.length) {
        contador = 0;
    }
}