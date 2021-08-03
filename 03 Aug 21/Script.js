let tasks = [];     //Created the Empty Array


//Pushing input string to the created Array
document.getElementById('createTask').addEventListener('click', function () 
{
    let list = document.getElementById('toDoList');
    list.innerHTML = ''; 
    let todoInput = document.getElementById('myInput').value;
    tasks.push(todoInput)  
    let item = document.createElement("li");
    document.getElementById("myInput").value = "";


for (let i = 0; i < tasks.length; i++) 
{
    let listItem = document.createTextNode(tasks[i]);
    let li = document.createElement("li");
    li.appendChild(document.createTextNode(tasks[i]));
    list.append(li);
}


// Create close button and append it to each list item
var myNodelist = document.getElementsByTagName("li");
for (let i = 0; i < myNodelist.length; i++) 
{
    let span = document.createElement("SPAN");
    let txt = document.createTextNode("\u00D7");
    span.className = "close";
    span.appendChild(txt);
    myNodelist[i].appendChild(span);
}

// Close button to close the current list item
let close = document.getElementsByClassName("close");
let i;
for (i = 0; i < close.length; i++) 
{
    close[i].onclick = function() {
    let div = this.parentElement;
    div.style.display = "none";
}
}
//Local Storage of the Added Array
localStorage.setItem("tasks",JSON.stringify(tasks));

});

// Add a Tick symbol when clicking on a list item
var list = document.querySelector('ul');
list.addEventListener('dblclick', function(ev) 
{
    if (ev.target.tagName === 'LI') 
    {
      ev.target.classList.toggle('checked');
    }
}, false);







