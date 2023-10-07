let dpicn = document.querySelector(".dpicn");
let dropdown = document.querySelector(".dropdown");
let coinModal = document.getElementById("coinModal");
let coinBtn = document.getElementById("coinBtn");

dpicn.addEventListener("click", () => {
    dropdown.classList.toggle("dropdown-open");
})

//When coin is clicked, open modal
coinBtn.addEventListener("click", () => {
    coinModal.style.display = "block";
})

//close modal if it is open and user clicks anywhere outside it
window.addEventListener("click", (event) => {
    if (event.target == coinModal) {
        coinModal.style.display = "none";
    }
})