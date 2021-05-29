
const searchInput = document.querySelector("#search");

let allList = document.querySelectorAll(".main");
let x = document.querySelectorAll(".x");

searchInput.addEventListener('keyup' , search);

function search() {

    for (let index = 0; index < allList.length; index++) {
        let currentValue = searchInput.value.toUpperCase();
        let listItemValue = x[index].innerHTML.toUpperCase();

        if ((listItemValue).indexOf(currentValue) > -1){
            allList[index].style.display = "block"
        }else{
            allList[index].style.display = "none"
        }
    };
    
}