let allboxs = document.querySelectorAll(".box");
let id;
allboxs.forEach(box => {
    box.ondragstart = function () {
        id = this.id;
    }
});
let allArea = document.querySelectorAll(".area");
allArea.forEach(area => {
    area.ondragover = function (ev) {
        ev.preventDefault();
    };
    area.ondrop = function () {
        let dragElement = document.getElementById(id);
        if (dragElement.getAttribute("data-id") == area.getAttribute("data-id")) {
            area.append(dragElement);
            area.style.padding = "5px";
            area.style.display = "flex";
            Swal.fire({
                title: "Drag me!",
                icon: "success",
                draggable: true
            });
        } else {
            Swal.fire({
                icon: "error",
                title: "Oops...",
                text: "Something went wrong!",
                footer: '<a href="#">Why do I have this issue?</a>'
            });
        }
    }

});

let group = {
    name: "PB202",
    size: 20,
    students: [],
    getAllStudents:function(){
        //
    },
    addStudent:function(student){
        //
    },
    getStudentById:function(studentId){
        //
    },
    removeStudentById:function(studentId){
        //
    },
    updateStudentById:function(studentId,name,surname){
        //
    }
}
//crud
let stu1 = {
    id: 1,
    name: "",
    surname: ""
}
group.addStudent(stu1);