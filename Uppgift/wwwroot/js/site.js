//räknapoäng


function raknaPoang() {
    let poang = 0;

    const frågor = [
        "Hardricksvatten",
        "Harmatfor3dagar",
        "harficklampa",
        "harradio"
    ];

    frågor.forEach(function (fraga) {
        const svar = document.querySelector(
            'input[name="' + fraga + '"]:checked'
        );

        if (svar && svar.value === "true") {
            poang++;
        }
    });

    const resultat = document.getElementById("poangResultat");

    resultat.className = "alert alert-success mt-3";
    resultat.innerText = "Du fick " + poang + " av 4 poäng!";
}