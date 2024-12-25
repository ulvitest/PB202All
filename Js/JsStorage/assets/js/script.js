//let img=document.querySelector("img");
// console.log(img.hasAttribute("src"));
// console.log(img.getAttribute("src"));
// img.setAttribute("src","ipsum.jpg")
//let list=document.getElementById("list");
// console.log(list.children);
// console.log(list.parentNode);
// console.log(list.firstElementChild);
// console.log(list.lastElementChild);
// console.log(list.firstElementChild.firstElementChild);
// console.log(list.lastElementChild.previousElementSibling);

//settimeout setinterval
// setTimeout(function(){
// console.log("salam");

// },4000)
// setInterval(function(){
// console.log("Salam");
// },1000)

// let date=new Date();
// console.log(date.getHours());
// console.log(date.getMinutes());
// console.log(date.getSeconds());

// function  getDate() {
//    let div=document.getElementById("time");
//    div.style.textAlign="center"
//    div.style.marginTop="100px"
//    let date=new Date();
//    let hour=date.getHours()>=10?date.getHours():"0"+date.getHours();
//    let minute=date.getMinutes()>=10?date.getMinutes():"0"+date.getMinutes();
//    let second=date.getSeconds()>=10?date.getSeconds():"0"+date.getSeconds();
//    div.innerHTML=`<b>${hour}:${minute}: ${second}</b>`;
// }
// setInterval(getDate,1000)
//math

//localStorage,sessionStorage,cookie
// sessionStorage.clear();
// sessionStorage.setItem("name","Nihad");
// sessionStorage.setItem("group","PB202");
// sessionStorage.removeItem("name");
// console.log(sessionStorage.getItem("name"));
// console.log(sessionStorage.getItem("group"));
// localStorage.setItem("group","pb202");
//console.log(localStorage.getItem("group"));

// document.cookie = "username=John Doe;";

let buttons=document.querySelectorAll(".btn");
buttons.forEach(button=>{
    button.onclick=function(ev){
        ev.preventDefault();
        let productId=this.parentElement.getAttribute("data-id");
        let stringPrice=this.previousElementSibling.innerText;
        let productPrice=stringPrice.substring(stringPrice.indexOf(":")+1,stringPrice.length-1);
        let basket=localStorage.getItem("basket");
        if (basket==null) 
            localStorage.setItem("basket",JSON.stringify([])); 

        let basketProducts=JSON.parse(localStorage.getItem("basket"));
        let existProduct= basketProducts.find(p=>p.id==productId);
        if (existProduct==undefined) {
            let product={
                id:productId,
                image:this.parentElement.previousElementSibling.getAttribute("src"),
                price:Number(productPrice),
                name:this.parentElement.firstElementChild.innerText,
                count:1
            }
            basketProducts.push(product);
        }else{
           existProduct.count++;

        }
        localStorage.setItem("basket",JSON.stringify(basketProducts));
        setBasketCount();
    }
    
})

function setBasketCount(){
    let basket=localStorage.getItem("basket");
    if (basket==null) 
        return;
    let count= JSON.parse(basket).reduce((prev,next)=>prev+next.count,0);
    document.getElementById("basketCount").innerText=count; 
   
    
}
setBasketCount()
















