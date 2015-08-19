<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<List<MvcEmployees.Models.EmployeeViewModel>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>List</title>
</head>
<body>
    <div>
    <table>
    <tr> 
    <th>EmpId</th>
    <th>Name</th>
    <th></th>
    </tr>
    <%foreach(var employee in Model) {%>
    <tr>
    <td><%=employee.Id %></td>
     <td><%=employee.Name %></td>
     <td><%=Html.ActionLink("View Details","Details/"+employee.Id) %></td>
    </tr>
    <%} %>
    </table>
    </div>
</body>
</html>
