<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcEmployees.Models.EmployeeDetailsViewModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Create</title>
</head>
<body>
<center>
    <div>
    <%Html.BeginForm("Create", "Employees", "POST"); %>
        <%=Html.LabelFor(model=>model.Id) %>
        <%=Html.EditorFor(model=>model.Id)%><br /><br />
        <%=Html.LabelFor(model=>model.Name) %>
        <%=Html.EditorFor(model=>model.Name)%><br /><br />
        <%=Html.LabelFor(model=>model.Gender) %>
        <%=Html.DropDownListFor(model=>model.Gender,Model.GenderList)%><br /><br />
        <%=Html.LabelFor(model=>model.State) %>
        <%=Html.DropDownListFor(model=>model.State,Model.StatesList)%><br /><br />
        <%=Html.LabelFor(model=>model.City) %>
        <%=Html.DropDownListFor(model=>model.City,Model.CitiesList)%><br /><br />
        <%=Html.LabelFor(model=>model.Pincode) %>
        <%=Html.EditorFor(model=>model.Pincode)%><br /><br />
        <input type="submit" value="Add" />
    <%Html.EndForm(); %>
    </div>
</center>
   
</body>
</html>
