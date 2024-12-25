let basket=localStorage.getItem("basket");
let table =document.querySelector(".table");
if(basket==null){
 table.innerHTML='<a href="./index.html">go to home page</a>'
}else{
    let products=JSON.parse(basket);
    products.forEach(p => {
        let tr=document.createElement("tr");

        let imageTh=document.createElement("td");
        let tdImage=document.createElement("img");
        tdImage.setAttribute("src",p.image);
        tdImage.style.width="200px";
        tdImage.style.height="200px";
        imageTh.append(tdImage);

        let tdName=document.createElement("td")
        tdName.innerText=p.name;

        let tdCount=document.createElement("td")
        tdCount.innerText=p.count;

        let tdPrice=document.createElement("td")
        tdPrice.innerText=p.price;

        let tdIcon=document.createElement("td")
        tdIcon.innerText="x";
        tdIcon.style.cursor="pointer";
        tdIcon.onclick=function(){
            removeById(p.id);
            this.parentElement.remove();
        }

        tr.append(imageTh,tdName,tdCount,tdPrice,tdIcon)

        table.lastElementChild.append(tr);
        
    });
}

function setBasketCount(){
    let basket=localStorage.getItem("basket");
    if (basket==null) 
        return;
    let count= JSON.parse(basket).reduce((prev,next)=>prev+next.count,0);
    document.getElementById("basketCount").innerText=count; 
   
}
setBasketCount();

function removeById(id){
    let basket=localStorage.getItem("basket");
    if (basket==null) 
        return;
    let products= JSON.parse(basket);
    let totalPrice=products.reduce((prev,next)=>prev+next.price*next.count,0)
    products=products.filter(p=>p.id!=id);
    localStorage.setItem("basket",JSON.stringify(products));
    setBasketCount();
    
    
}
