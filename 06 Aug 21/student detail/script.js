const studentList=[]

class Student
{
    constructor(name, email, pwd, cpwd)
    {
        this.name=name;
        this.email=email;
        this.pwd=pwd;
        this.cpwd=cpwd;

    }
}
function StudentDetails()
{
    const name=document.getElementById("usernames").value;
    const email=document.getElementById("email").value;
    const password=document.getElementById("password").value;
    const conpassword=document.getElementById("conpassword").value;

    var details=new Student(name,email,pwd,cpwd)
    studentList.push(details)

    localStorage.setItem("studentList",JSON.stringify(studentList))

    document.getElementById("usernames").value="";
    document.getElementById("email").value="";
    document.getElementById("password").value="";
    document.getElementById("conpassword").value="";

}
var count=0;
function DisplayDetails()
{
    const displayTag=document.getElementById("detail")
    
    for (let student of studentList)
    {
        
        let add=`<div class="listStudent">
        <h2>Student ${++count}</h2>
        <h3>User Name : ${student.name}<h3>
        <h5>Email ID: ${student.sclass}<h5>
        </div>`
        displayTag.insertAdjacentHTML("afterbegin",add)
    }
}