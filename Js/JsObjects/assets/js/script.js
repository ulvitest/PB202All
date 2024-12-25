//js dom
// console.log(document);
// let div=document.getElementById("test");
// div.style.width="100px";
// div.style.height="100px";
// div.style.backgroundColor="red";
// console.log(div);
//  let list=document.getElementsByTagName("li");
//  for (let i = 0; i < list.length; i++) {
//     const element = list[i];
//     element.style.listStyleType="none"
//  }
// let list=document.getElementsByClassName("list");
// console.log(list);
//console.log(document.querySelector(".list"));
// console.log(document.querySelectorAll(".list"));
// console.log(document.querySelectorAll("ul li"));

//let button=document.getElementById("btn");
// button.onclick=function(){
//     // let text=document.getElementById("text");
//     // text.style.color="white";
//     // text.style.background="red"
//     alert("first");
// }
// button.addEventListener("click",function(){
//     alert("salam")
// })
// button.addEventListener("click",function(){
//     alert("sagol")
// })
// let icon=document.querySelector(".icon");
// let sideBar=document.querySelector(".sideBar");
// icon.onclick=function(){
  
//     // sideBar.className="test";
//     sideBar.classList.add("test");
// }
// let hamburgerMenu=document.querySelector(".hamburger");
// hamburgerMenu.onclick=function(){
// sideBar.classList.remove("test");
// }

// let addBtn=document.querySelector(".btn");
// let input=document.querySelector(".form-control")
// let list=document.querySelector(".list-group");
// addBtn.onclick=function(){
//     let inputValue=input.value.trim();
//      if(inputValue.length){
//         let li=document.createElement("li");
//         li.innerText=inputValue;
//         li.classList.add("list-group-item")
//         let icon=document.createElement("i");
//         icon.style.cursor="pointer"
//         icon.classList.add("fa-solid","fa-xmark");
//         icon.onclick=function(){
//             li.remove();
//         }

//         li.append(icon)
//         li.style.display="flex";
//         li.style.justifyContent="space-between";
//         list.append(li);
//         input.value="";
        
//      }else{
//         console.log("bosh qoyma");
        
//      }
// }


// document.getElementById("test").innerText="<h1>Hacixan</h1>";
document.getElementById("test").innerHTML="<h1>Hacixan</h1>";













 
































// function Sum(){

// }
// Sum();

// let sum=()=>{

// }
// sum();
// function SumOfEven(arr,cb){
//     let sum=0;
//     for (let i = 0; i < arr.length; i++) {
//         const element = arr[i];
//         if (cb(element)) 
//             sum+=element; 
//     }
//     return sum
// }
// console.log(SumOfEven([23,44,1,8],num=>num%2==0));
// console.log(SumOfEven([23,44,1,8],num=>num%2!=0));
//js objects
// const user1={
//     name:"lorem",
//     surname:"ipsumov",
//     age:20,
//     "address of student":"Baki",
//     getAge:function(){
//         return this.age
//     },
//     getFullName:function(){
//         return `${this.name} ${user1.surname}`
//     },
//     getAddress:()=>{
//       console.log(user1["address of student"]);
      
//     }
// }
// console.log(user1.getAge());
// console.log(user1.getFullName());
// console.log(user1.getAddress());
// console.log(window);




// const user2={
//     name:"doler",
//     surname:"ipsumov",
//     age:22,
//     "address of student":"Sumqayit"
// }
// const user3=user1;
// user3.name="Ziya"
// console.log(user1);
// const user3=Object.assign({point:20},user1);
// user3.name="Ziya"
// console.log(user3);
// const user3={...user1};
// user3.name="";
// console.log(user1);
// let str=JSON.stringify(user1);
// console.log(JSON.parse(str));
// const user3=JSON.parse(JSON.stringify(user1));
// user3.name="";
// console.log(user1);

// function Person(name,age){
//     this.name=name;
//     this.age=age;
//     this.getAge=function(){
//         return this.age
//     }
// };
// const user5=new Person("test",22);
// console.log(user5.getAge());

// let array=[11,33,11,56,78];
// console.log(array.reduce((prev,value,index,arr)=>prev+value,10));

// array.forEach((value)=>{
// console.log(value);
// });
// let newArr=array.map((value)=>value*2);
// console.log(newArr);
// let newArr=[];
// for (let i = 0; i < array.length; i++) {
//     const element = array[i];
//     newArr.push(element*2)
    
// }
// console.log(newArr);
// let newArr=array.filter((value)=>value!=11)
// console.log(newArr);
// let users=[
//     {
//       "_id": "676a987a93dad96b7f247f66",
//       "index": 0,
//       "guid": "becfe83a-6783-4d9e-8f4d-fd995dde9dc4",
//       "isActive": true,
//       "balance": "$2,180.83",
//       "picture": "http://placehold.it/32x32",
//       "age": 27,
//       "eyeColor": "blue",
//       "name": "Cornelia Hardin",
//       "gender": "female",
//       "company": "OLUCORE",
//       "email": "corneliahardin@olucore.com",
//       "phone": "+1 (867) 558-3877",
//       "address": "909 Newkirk Avenue, Fredericktown, Arkansas, 9102",
//       "about": "Aute tempor ut tempor pariatur ex nulla anim quis exercitation anim tempor culpa. Ipsum Lorem aliquip sunt incididunt qui minim aliquip cillum id consequat irure ex magna velit. Sint nostrud do adipisicing velit ut veniam do esse qui.\r\n",
//       "registered": "2014-09-25T06:32:39 -05:00",
//       "latitude": 68.834284,
//       "longitude": 15.330754,
//       "tags": [
//         "laborum",
//         "sit",
//         "culpa",
//         "amet",
//         "quis",
//         "laborum",
//         "occaecat"
//       ],
//       "friends": [
//         {
//           "id": 0,
//           "name": "Victoria Mosley"
//         },
//         {
//           "id": 1,
//           "name": "Ella Maxwell"
//         },
//         {
//           "id": 2,
//           "name": "Sparks Valencia"
//         }
//       ],
//       "greeting": "Hello, Cornelia Hardin! You have 9 unread messages.",
//       "favoriteFruit": "strawberry"
//     },
//     {
//       "_id": "676a987a520747cab64c69a4",
//       "index": 1,
//       "guid": "acf04e0f-65d9-467d-a45b-50e0b30895b8",
//       "isActive": true,
//       "balance": "$2,836.80",
//       "picture": "http://placehold.it/32x32",
//       "age": 26,
//       "eyeColor": "brown",
//       "name": "Brittney Preston",
//       "gender": "female",
//       "company": "INSURESYS",
//       "email": "brittneypreston@insuresys.com",
//       "phone": "+1 (999) 544-3612",
//       "address": "986 Amber Street, Ellerslie, South Dakota, 748",
//       "about": "Eu culpa minim dolor sunt deserunt ut ut. Occaecat magna incididunt non mollit id occaecat tempor elit incididunt sunt sint aute eiusmod incididunt. Fugiat esse est labore id. Enim est adipisicing est deserunt in dolor minim do nisi voluptate. Adipisicing nulla ullamco veniam voluptate enim reprehenderit aliquip id ipsum occaecat. Aute id laboris voluptate sit qui aliquip anim.\r\n",
//       "registered": "2015-02-01T01:48:40 -04:00",
//       "latitude": -78.168174,
//       "longitude": 149.72837,
//       "tags": [
//         "mollit",
//         "sit",
//         "ex",
//         "tempor",
//         "anim",
//         "ea",
//         "nostrud"
//       ],
//       "friends": [
//         {
//           "id": 0,
//           "name": "Hodges Mercado"
//         },
//         {
//           "id": 1,
//           "name": "Cathryn Shepherd"
//         },
//         {
//           "id": 2,
//           "name": "Ball Paul"
//         }
//       ],
//       "greeting": "Hello, Brittney Preston! You have 9 unread messages.",
//       "favoriteFruit": "apple"
//     },
//     {
//       "_id": "676a987a35b51c4a0663b163",
//       "index": 2,
//       "guid": "288b4662-a61d-4a15-b7bc-03fb38139e81",
//       "isActive": true,
//       "balance": "$1,340.44",
//       "picture": "http://placehold.it/32x32",
//       "age": 29,
//       "eyeColor": "brown",
//       "name": "Lucile Kerr",
//       "gender": "female",
//       "company": "TERRAGEN",
//       "email": "lucilekerr@terragen.com",
//       "phone": "+1 (963) 575-3715",
//       "address": "465 Union Avenue, Marysville, Arizona, 4677",
//       "about": "Aute sint id non duis non ullamco fugiat ad eu sint aliqua. In nostrud cillum consectetur aliquip pariatur eiusmod deserunt et sint duis aliqua eiusmod laborum amet. Proident quis esse laboris laboris labore et deserunt non fugiat culpa aute. Velit ex nostrud eu aliqua ullamco nulla.\r\n",
//       "registered": "2019-12-15T01:19:57 -04:00",
//       "latitude": -66.549575,
//       "longitude": 48.940274,
//       "tags": [
//         "ea",
//         "ut",
//         "sint",
//         "reprehenderit",
//         "ex",
//         "sint",
//         "sunt"
//       ],
//       "friends": [
//         {
//           "id": 0,
//           "name": "Helena Sellers"
//         },
//         {
//           "id": 1,
//           "name": "Cecelia Harvey"
//         },
//         {
//           "id": 2,
//           "name": "Cox Mathews"
//         }
//       ],
//       "greeting": "Hello, Lucile Kerr! You have 1 unread messages.",
//       "favoriteFruit": "strawberry"
//     },
//     {
//       "_id": "676a987a5142d91dbf283588",
//       "index": 3,
//       "guid": "a6867d8d-8459-4132-866d-c096b92a5066",
//       "isActive": true,
//       "balance": "$3,030.76",
//       "picture": "http://placehold.it/32x32",
//       "age": 40,
//       "eyeColor": "green",
//       "name": "Angelita Rojas",
//       "gender": "female",
//       "company": "CAPSCREEN",
//       "email": "angelitarojas@capscreen.com",
//       "phone": "+1 (997) 465-3493",
//       "address": "662 Nova Court, Tyro, American Samoa, 3567",
//       "about": "Deserunt eiusmod sunt id tempor minim consequat dolor amet ullamco cupidatat. Qui nulla Lorem mollit duis anim quis in incididunt. Deserunt cupidatat do labore esse id velit ea laboris elit amet laborum laboris. Eu adipisicing ipsum nisi veniam proident dolore qui amet ipsum cupidatat fugiat non. Non tempor enim occaecat dolor nulla ullamco Lorem culpa tempor.\r\n",
//       "registered": "2023-06-08T11:37:36 -04:00",
//       "latitude": -19.131075,
//       "longitude": -84.672019,
//       "tags": [
//         "officia",
//         "cupidatat",
//         "excepteur",
//         "ea",
//         "adipisicing",
//         "ex",
//         "do"
//       ],
//       "friends": [
//         {
//           "id": 0,
//           "name": "Flores Dale"
//         },
//         {
//           "id": 1,
//           "name": "Middleton Martinez"
//         },
//         {
//           "id": 2,
//           "name": "Delia Bradley"
//         }
//       ],
//       "greeting": "Hello, Angelita Rojas! You have 7 unread messages.",
//       "favoriteFruit": "apple"
//     },
//     {
//       "_id": "676a987ac4892d97ad337d35",
//       "index": 4,
//       "guid": "b1bac239-3b75-45e2-8521-d0559156f592",
//       "isActive": true,
//       "balance": "$2,020.53",
//       "picture": "http://placehold.it/32x32",
//       "age": 22,
//       "eyeColor": "green",
//       "name": "Riddle Jimenez",
//       "gender": "male",
//       "company": "QUAREX",
//       "email": "riddlejimenez@quarex.com",
//       "phone": "+1 (866) 477-3020",
//       "address": "194 Hudson Avenue, Lithium, New York, 8856",
//       "about": "Culpa anim in magna nostrud excepteur ipsum non ea id ipsum consequat. Irure sint Lorem incididunt sit amet sit voluptate id nulla sit ad excepteur. Exercitation cupidatat reprehenderit eiusmod culpa ad.\r\n",
//       "registered": "2016-07-15T01:15:47 -04:00",
//       "latitude": -44.306651,
//       "longitude": -134.653608,
//       "tags": [
//         "cillum",
//         "qui",
//         "mollit",
//         "proident",
//         "veniam",
//         "aliqua",
//         "incididunt"
//       ],
//       "friends": [
//         {
//           "id": 0,
//           "name": "Castaneda Copeland"
//         },
//         {
//           "id": 1,
//           "name": "Pam Odonnell"
//         },
//         {
//           "id": 2,
//           "name": "Pauline Knowles"
//         }
//       ],
//       "greeting": "Hello, Riddle Jimenez! You have 8 unread messages.",
//       "favoriteFruit": "banana"
//     },
//     {
//       "_id": "676a987aef5e3add3ebb67e7",
//       "index": 5,
//       "guid": "588e9246-42ab-404e-a49c-f8d4c992321d",
//       "isActive": false,
//       "balance": "$1,437.13",
//       "picture": "http://placehold.it/32x32",
//       "age": 2,
//       "eyeColor": "green",
//       "name": "Sherrie Pittman",
//       "gender": "female",
//       "company": "XIIX",
//       "email": "sherriepittman@xiix.com",
//       "phone": "+1 (898) 454-2135",
//       "address": "252 Hooper Street, Aberdeen, Federated States Of Micronesia, 411",
//       "about": "Voluptate incididunt magna quis aliquip irure nostrud irure officia dolor sunt nisi in cupidatat qui. Minim ullamco nulla proident anim aliquip reprehenderit anim culpa commodo voluptate exercitation ullamco. Quis eiusmod incididunt reprehenderit ad ad Lorem enim. Proident ipsum excepteur irure aliquip nostrud labore cupidatat ad. Cillum aliqua pariatur reprehenderit anim nostrud anim ipsum dolor.\r\n",
//       "registered": "2022-07-14T12:52:26 -04:00",
//       "latitude": 33.488027,
//       "longitude": 144.804636,
//       "tags": [
//         "esse",
//         "labore",
//         "Lorem",
//         "aliqua",
//         "voluptate",
//         "incididunt",
//         "laborum"
//       ],
//       "friends": [
//         {
//           "id": 0,
//           "name": "Schroeder Moody"
//         },
//         {
//           "id": 1,
//           "name": "Rosella Parrish"
//         },
//         {
//           "id": 2,
//           "name": "Potter Day"
//         }
//       ],
//       "greeting": "Hello, Sherrie Pittman! You have 4 unread messages.",
//       "favoriteFruit": "apple"
//     }
//   ]
//   let sumOfAges=users
//   .filter((user)=>user.eyeColor=="green")
//   .map((user)=>{user.age+=10;return user})
//   .reduce((prev,next)=>prev+next.age,0);
// console.log(sumOfAges);

//   let newArr=users.filter((value)=>value.eyeColor=="green");
//   console.log(newArr);
//   console.log(users.every((value)=>value.isActive==true));
 // console.log(users.some((value)=>value.isActive==true));
//  console.log(array.findIndex((value)=>value==11));
// console.log(users.reduce((prev,next)=>prev+next.age,0));


// Object.freeze(user1)
// user1.email="lorem@gmail.com"
// delete user1.name;
// console.log(user1);
// Object.defineProperty(user1,"phone",{value:"123456",writable:true})
// user1.phone="123"
// console.log(user1);
// console.log(Object.keys(user1));//["name","surname",...]
// console.log(Object.values(user1));
// console.log(Object.entries(user1));//[["name","lorem"],[],[]]



















// console.log(user1.name);
// console.log(user1["address of student"]);
// let users=[user1,user2];
// for (let i = 0; i < users.length; i++) {
//     const element = users[i];
//     if (element.age>21) {
//         console.log(element.name);
//     }
    
// }
// let name=user1.name
// let age=user1.age
// const {name,...test}=user1;
// console.log(test);




