<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcEmployees.Models.UserViewModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Login</title>
</head>
<body>
    <div>
    <%Html.BeginForm("Login", "Employees", "POST"); %>
    <%=Html.LabelFor(model=>model.Username) %>
    <%=Html.EditorFor(model=>model.Username) %><br /><br />
    <%=Html.LabelFor(model=>model.Password) %>
    <%=Html.EditorFor(model=>model.Password) %>
    <%Html.EndForm(); %>
    </div>
</body>
</html>
