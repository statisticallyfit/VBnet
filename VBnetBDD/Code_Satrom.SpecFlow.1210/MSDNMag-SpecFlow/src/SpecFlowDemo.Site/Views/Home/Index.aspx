<%@ Page Language="vb" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData("Message")%></h2>
    <% If User.Identity.IsAuthenticated Then%>
    <p>
        <%: Html.ActionLink("Create New Customer", "Create", "Customers")%>
    </p>
    <%  Else%>
    <p>
        Please Log On to experience all the awesomeness this site has to offer.
    </p>
    <% End If%>
</asp:Content>
