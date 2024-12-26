// let input =document.getElementById("input");
// input.onchange=function(){
//     console.log(input.value);
// }
// input.onkeyup=function(){
//     console.log(input.value); 
// }
// input.onkeydown=function(){
//     console.log(input.value);
    
// }
// input.onfocus=function(){
//     console.log("inputa fokus olundu...");
// }
// input.onblur=function(){
//     console.log("inputa blur olundu..."); 
// }
// document.getElementById("cars").onchange=function(){
//     console.log(this.value);
    
// }
// document.getElementById("form").onsubmit=function(e){
//     e.preventDefault();
//     let input =document.getElementById("input");
//     if(input.value.length>10||input.value.length<5){
//         // Swal.fire({
//         //     icon: "error",
//         //     title: "Oops...",
//         //     text: "Something went wrong!",
//         //     footer: '<a href="#">Why do I have this issue?</a>'
//         //   });
//         toastr.warning('I do not think that word means what you think it means.', 'Inconceivable!')
//     }
    
// }
// let dragElement=document.querySelector(".dragElement");
let dragElements=document.querySelectorAll(".dragElement");
let area=document.querySelector(".area");
// let id;
dragElements.forEach(dragElement=>{
    dragElement.ondragstart=function(ev){
        ev.dataTransfer.setData("id",this.id);
    }
})
// dragElement.addEventListener("dragstart",function(){
//    id=this.id;
//    console.log(id);
   
// });
// dragElement.addEventListener("drag",function(){
//     console.log("drag start");
// });
// dragElement.addEventListener("dragend",function(){
//     console.log("drag end");
// });
// area.ondragenter=function(){
//     console.log("element daxil oldu..");
// }
// area.ondragleave=function(){
//     console.log("element leave oldu..");
// }
area.ondragover=function(ev){
 ev.preventDefault();
}
area.ondrop=function(ev){
    ev.preventDefault();
    let files=ev.dataTransfer.files;
   Upload(files);
    
    
    // area.style.padding="10px";
    // area.style.overflow="scroll";
    // this.append(document.getElementById( ev.dataTransfer.getData("id")));
}

let icon=document.querySelector(".fa-upload");
let fileInput=document.querySelector("input");
icon.onclick=function(){
    this.nextElementSibling.click();
}
fileInput.onchange=function(ev){
    let files=ev.target.files;
    Upload(files);
    
}
function Upload(files){
    for (let i = 0; i < files.length; i++) {
        let file=files[i];
        let fileReader=new FileReader();
        fileReader.onloadend=function(ev){
            let tr=`
             <tr>
              <td>
               <img width="150" height="150" src="${ev.target.result}" alt="">
                    </td>
                    <td>${file.name}</td>
                    <td>${file.size}</td>
                    <td>${file.type}</td>
                  </tr>
             `
          document.querySelector(".table").lastElementChild.innerHTML+=tr;
        }
        fileReader.readAsDataURL(file);
        
    }
}