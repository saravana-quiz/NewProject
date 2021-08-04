const studentList=[]

class Student
{
    constructor(name, sclass, rollNumber, email, dob)
    {
        this.name=name;
        this.sclass=sclass;
        this.rollNumber=rollNumber;
        this.email=email;
        this.dob=dob;

    }
}
function StudentDetails()
{
    const name=document.getElementById("sname").value;
    const sclass=document.getElementById("sclass").value;
    const rollNumber=document.getElementById("rnumber").value;
    const email=document.getElementById("eid").value;
    const dob=document.getElementById("dob").value;

    var details=new Student(name,sclass,rollNumber,email,dob)
    studentList.push(details)
    localStorage.setItem("studentList",JSON.stringify(studentList))
    document.getElementById("sname").value="";
    document.getElementById("sclass").value="";
    document.getElementById("rnumber").value="";
    document.getElementById("eid").value="";
    document.getElementById("dob").value="";

}
var count=0;
function DisplayDetails()
{
    const displayTag=document.getElementById("detail")
    
    for (let student of studentList)
    {
        
        let add=`<div class="listStudent">
        <h2>Student ${++count}</h2>
        <h3>Name : ${student.name}<h3>
        <h5>Class : ${student.sclass}<h5>
        <h5>Roll Number : ${student.rollNumber}<h5>
        <h5>Email : ${student.email}<h5>
        <h5>Date Of Birth : ${student.dob}<h5>
        </div>`
        displayTag.insertAdjacentHTML("afterbegin",add)
    }
}