$(document).ready(function(){
$("button").click(function(){
let inputValue=$("input").val();
// let siteUrl=`https://jsonplaceholder.typicode.com/photos/${inputValue}`;
let siteUrl=`https://dummyjson.com/products`;
$.ajax({
    method:"get",
    url:siteUrl,
    // success:function(data){
    // //    datas.slice(0,20).forEach(data => {
    // //     let card=
    // //     `
    // //     <div class="card" style="width: 18rem;">
    // //         <img class="card-img-top" src="${data.url}" alt="Card image cap">
    // //         <div class="card-body">
    // //             <h5 class="card-title">${data.title}</h5>
    // //             <p class="card-text">${data.thumbnailUrl}</p>
    // //             <a href="#" class="btn btn-primary">Go somewhere</a>
    // //         </div>
    // //         </div>
        
    // //     `
    // //     $(".row").append(card);
    // //    });
    // let card=
    //     `
    //     <div class="card" style="width: 18rem;">
    //         <img class="card-img-top" src="${data.url}" alt="Card image cap">
    //         <div class="card-body">
    //             <h5 class="card-title">${data.title}</h5>
    //             <p class="card-text">${data.thumbnailUrl}</p>
    //             <a href="#" class="btn btn-primary">Go somewhere</a>
    //         </div>
    //         </div>
        
    //     `
    //     $(".row").append(card);
      

    // },
    success:function(data){
     data.products.slice(0,20).forEach(p => {
        let card=
        `
        <div class="card" style="width: 18rem;">
           <img class="card-img-top" src="${p.images[0]}" alt="Card image cap">
           <div class="card-body">
               <h5 class="card-title">${p.title.substring(0,10)}</h5>
               <p class="card-text">${p.description.substring(0,30)}</p>
               <a href="#" class="btn btn-primary">Go somewhere</a>
           </div>
           </div>
        `
        $(".row").append(card);
     });
    },
    error:function(error){
        console.log(error);
        
    }

})
});





























//  let list=document.querySelectorAll("ul li");
//  for (let i = 0; i < list.length; i++) {
//     list[i].onclick=function(){
//         alert(this.innerText);
//     }
//  }
// $("ul li").click(function(){
//     alert($(this).text());
// })


// $(document).on("click","ul li",function(){
//     alert($(this).text());
// });
// let newLi=$("<li>");
// newLi.text("lorem4");
// newLi.css({
//     color:"red",
// });
// $("ul").append(newLi);
// $("ul li").mouseenter(function(){
//     alert($(this).text());
// })
// $("div").scroll(function(){
//     alert("")
// });
//     $("button").click(function(){
//      document.getElementById("div1").innerHTML="salam";
//   });

});

