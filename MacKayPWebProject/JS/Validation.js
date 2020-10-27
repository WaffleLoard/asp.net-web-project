function validateInputs() {

    var width = document.getElementById("widthTextBox").value;
    var height = document.getElementById("heightTextBox").value;
    var numBombs = document.getElementById("numBombsTextBox").value;
    
    document.getElementById("warningBox").innerHTML = "";

    if (width == "" || height == "" || numBombs == "") {
        document.getElementById("warningBox").innerHTML += "All Fields are Required! ";
    }
    if (width > 100) {
        document.getElementById("warningBox").innerHTML += "Width Cannot be Greater Than 100!";
    }
    if (height > 100) {
        document.getElementById("warningBox").innerHTML += "Height Cannot be Greater Than 100!";
    }
    if (numBombs > 100) {
        document.getElementById("warningBox").innerHTML += "The Number Of Bombs Cannot be Greater Than 100!";
    }

    if (isNaN(width)) {
        document.getElementById("warningBox").innerHTML += "Error " + width + " Is Not Valid! ";
    }
    if (isNaN(height)) {
        document.getElementById("warningBox").innerHTML += "Error " + height + " Is Not Valid! ";
    }
    if (isNaN(numBombs)) {
        document.getElementById("warningBox").innerHTML += "Error " + numBombs + " Is Not Valid! ";
    }
}

function validateInputs2() {
    
}