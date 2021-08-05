window.onload = function()
{
    var request = new XMLHttpRequest();
    request.onreadystatechange = function() 
    {
        if (this.readyState == 4 && this.status == 200) 
        {
            var info = JSON.parse(this.responseText)
            var outputData = document.querySelector('#body')

            info.data.map((details) => {
                outputData.innerHTML += 
                `<tr>
                    <td>${details.id}</td>
                    <td>${details.first_name}</td>
                    <td>${details.last_name}</td>
                    <td>${details.email}</td>
                    <td><img src='${details.avatar}'</td>
                </tr>`
            })
        }
    }
    request.open('GET','https://reqres.in/api/users?page=2')
    request.send()
}