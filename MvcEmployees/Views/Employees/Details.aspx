<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcEmployees.Models.Employee>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Details</title>
</head>
<body>
    <div>
        <%=Html.LabelFor(model=>model.Id) %>
        <%=Html.DisplayFor(model=>model.Id)%><br /><br />
        <%=Html.LabelFor(model=>model.Name) %>
        <%=Html.DisplayFor(model=>model.Name)%><br /><br />
        <%=Html.LabelFor(model=>model.Gender) %>
        <%=Html.DisplayFor(model=>model.Gender)%><br /><br />
        <%=Html.LabelFor(model=>model.State) %>
        <%=Html.DisplayFor(model=>model.State)%><br /><br />
        <%=Html.LabelFor(model=>model.City) %>
        <%=Html.DisplayFor(model=>model.City)%><br /><br />
        <%=Html.LabelFor(model=>model.Pincode) %>
        <%=Html.DisplayFor(model=>model.Pincode)%><br /><br />
    </div>
</body>
</html>
