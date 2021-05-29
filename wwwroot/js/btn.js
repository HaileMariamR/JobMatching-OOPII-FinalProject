const accept = document.querySelector("#accept");
const reject = document.querySelector("#reject");

accept.addEventListener('click' , (e)=>{

    accept.innerHTML = "Accepted"

})


reject.addEventListener('click' , (e)=>{

    reject.innerHTML = "rejected"

})