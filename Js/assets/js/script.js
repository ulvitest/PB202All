// console.log("salam");
//alert("salam");
//prompt("enter number :")
// console.log(document.write("hello"));

//var let const
// var num=12;
// let surname="lorem";
// const age=30;
// var address=null;
// var email=undefined;
// let isExist=true;
// var name="Samid";
// name="filankes";
// name=13;
// console.log(name);
// var age=23;
// var age=55;
// console.log(age);
//hoisting
//console.log(typeof name);

// console.log(address);
// let address="Baki";
// console.log(email);
// const email="lorem@gmail.com";

//scope 1.block 2.function 3.global
// let sum;
// if (true) {
//    let sum=5+8;
//    console.log(sum);

// }
// let num=12;

// function Sum(){
//     console.log(num+10);
// }
// Sum();
// debugger;
// let age=12;
// if (age>12) 
//     console.log("12den boyuk");
// else if(age==12)
//     console.log("12ye beraberdir");
// else
//     console.log("12den kicikdir");

// let day = 1;
// switch (day) {
//     case 1:
//         console.log("1cigun");
//         break;
//     case 2:
//         console.log("2cigun");
//         break;

//     default:
//         console.log("duzgun daxil et..");
        
//         break;
// }
// const num1=parseInt(prompt("enter first number"));//12
// const num2=parseInt(prompt("enter second number"))
// let sum=0;
// if (!isNaN(num1)) {
//     sum+=num1;
// }
// if (!isNaN(num2)) {
//     sum+=num2;
// }
// console.log(sum);

//const array=[12,1,45,"lorem",false,[11,47],"ipsum"];
// array[10]=77;
// console.log(array.length);
// console.log(array[0]);
// console.log(array[array.length-1]);
// console.log(array[5][1]);
// console.log(typeof array);
// for (let i = 0; i < array.length; i++) {
//   console.log(array[i]);
  
// }
//let array=[12,6,14,555,1,100];
// let max=array[0];
// for (let i = 0; i < array.length; i++) {
//   if (array[i]>max) {
//     max=array[i]
//   }
// }
// console.log(max);
// let index=0;
// while (index<array.length) {
//     console.log(array[index]);
//     index++;
// }
// let index=0;
// do {
//     console.log(array[index]);
//     index++
    
// } while (index<array.length);
// let user={
//     name:"lorem",
//     surname:"ipsumov",
//     age:12,
//     "student address":"baki"
// }
// console.log(typeof user);
// console.log(user.name);
// console.log(user["name"]);
// console.log(user["student address"]);
//truthy any number without 0,[],{}
// falsy 0 null,undefined ""

// if ([]) {
//    console.log("true");
    
// }
// else{
//     console.log(false);
    
// }
// let array=[];
// if (array.length>0) {
//     console.log(true);
    
// }else{
//     console.log(false);
    
// }

//function
// function Info(){
//     console.log("helloo"); 
// }
// Info();
// console.log(Sum(2,3));

// function Sum(num1,num2){
//     return num1+num2;
// }
//console.log(Sum(12,35));
//console.log(Sum(1));

// let info=function StudentDetail(name,surname){
//     console.log(`name:${name} surname:${surname}`);
// }
// info("lorem","ipsum");
// sum();
// var sum=()=>{
//  console.log(3+4);
 
// }

//let info=(name,surname)=>`name: ${name} surname: ${surname}`

// let getArray=()=>[12,3,4,99];
// console.log(getArray());
// let getObject=(name,surname)=>({ name,surname})
// console.log(getObject("lorem","ipsum"));

function Sum(){
  let array=Array.from(arguments)
 let sum=0;
 for (let i = 0; i < array.length; i++) {
    const element = array[i];
    sum+=element;
    
 }
 console.log(sum);
}
console.log(Sum(22,11,25,66));

































