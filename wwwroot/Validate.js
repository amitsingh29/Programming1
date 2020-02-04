console.log($('#FullName').val());
{

    $.ajax(
    {
        url: '/Add',
        type: 'POST',
        contentType: 'application/json;charset=utf-8',
        dataType: 'json',
        data: "{'FullName': '" + $('#FullName').val() + "','Age': '" + $('#Age').val() +"','EmailId': '" + $('#EmailId').val() + "','WorkExperience': " + $('#WorkExperience').val() + "}",
        success: function ()
        {
            alert("Data Inserted successfully!!!");
        },
        error: function ()
        {
            alert("Insert Error!!!");
        }
    });

    return true;
}
